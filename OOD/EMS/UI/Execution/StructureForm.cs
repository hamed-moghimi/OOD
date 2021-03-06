﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Execution;
using OOD.EMS.Exceptions;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Execution
{
    public partial class StructureForm : TemplateForm
    {
        public StructureForm()
        {
            InitializeComponent();
            load_structure();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyExecutiveDocs())
            {
                groupBox2.Visible = false;
                groupBox1.Location = new System.Drawing.Point(groupBox1.Location.X, groupBox1.Location.Y + 80);
                delete.Visible = false;
                ViewButton.Location = new System.Drawing.Point(ViewButton.Location.X + 23, ViewButton.Location.Y);
                next.Location = new System.Drawing.Point(next.Location.X - 22, next.Location.Y);
                prev.Location = new System.Drawing.Point(prev.Location.X - 22, prev.Location.Y);
            }
        }

        private void load_structure()
        {
            structureTree.Nodes.Clear();
            OrganizationStructure org = OrganizationStructure.getInstance();
            Department dept = org.Root;
            TreeNode[] children = getChildrenNodes(dept);
            TreeNode node;
            if (children.Count() > 0)
            {
                node = new TreeNode(dept.Name, children);
            }
            else
            {
                node = new TreeNode(dept.Name);
            }
            structureTree.Nodes.Add(node);
        }

        private TreeNode[] getChildrenNodes(Department dept)
        {
            if (dept == null)
                return new TreeNode[] { };
            List<Department> childs = dept.getChildren();
            List<TreeNode> resList = new List<TreeNode>();
            foreach (Department c in childs)
            {
                TreeNode[] cChild = getChildrenNodes(c);
                if (cChild.Count() == 0)
                {
                    resList.Add(new TreeNode(c.Name));
                }
                else
                {
                    resList.Add(new TreeNode(c.Name, cChild));
                }
            }
            return resList.ToArray();
        }

        private void next_Click(object sender, EventArgs e)
        {
            TreeNode selected = structureTree.SelectedNode;
            if (selected == null)
            {
                structureTree.SelectedNode = structureTree.Nodes[0];
                structureTree.Focus();
            }
            else
            {
                structureTree.SelectedNode = selected.NextVisibleNode;
                structureTree.Focus();
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            TreeNode selected = structureTree.SelectedNode;
            if (selected == null)
            {
                structureTree.SelectedNode = structureTree.Nodes[0];
                structureTree.Focus();
            }
            else
            {
                structureTree.SelectedNode = selected.PrevVisibleNode;
                structureTree.Focus();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            TreeNode selected = structureTree.SelectedNode;
            if (selected != null)
            {

                Department dept = getDepartment(selected);
                if (dept.Equals(OrganizationStructure.getInstance().Root))
                {
                    MessageBox.Show("سازمان نمی‌تواند حذف شود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                    return;
                }
                Department resp = dept.getResponsible();
                if (resp != null)
                {
                    MessageBox.Show("بخش " + resp.Name + " مسئول یک هدف اجرایی یا مسئولیت است و نمی‌توان آن را حذف کرد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
                }
                else
                {
                    OrganizationStructure.getInstance().remove(getDepartment(selected));
                    structureTree.Nodes.Remove(selected);
                }
            }
            
        }

        

        private Department getDepartment(TreeNode node)
        {
            if (node != null)
            {
                TreeNode parent = node.Parent;
                if (parent == null)
                {
                    return OrganizationStructure.getInstance().all().Find(x => x.Name.Equals(node.Text) && x.Supervisor == null);
                }
                else
                {
                    Department parentDept = getDepartment(parent);
                    return OrganizationStructure.getInstance().all().Find(x => x.Name.Equals(node.Text) && x.Supervisor.Equals(parentDept));
                }
            }
            return null;
            
        }

        private void addDepartment_Click(object sender, EventArgs e)
        {
            if (deptName.Text.Trim().Count() == 0 || structureTree.SelectedNode == null)
            {
                MessageBox.Show(new IncompleteFormException().Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading| MessageBoxOptions.RightAlign);
            }
            else
            {
                Department parent = getDepartment(structureTree.SelectedNode);
                Department newDept = new Department(deptName.Text.Trim(), parent, null);
                List<Department> deptList = OrganizationStructure.getInstance().all();
                if (deptList.Contains(newDept))
                {
                    MessageBox.Show(new DepartmentExistsException().Message);
                }
                else
                {
                    SelectManagerForm f = new SelectManagerForm();
                    DialogResult res = f.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        newDept.Manager = f.selectedUser;
                        OrganizationStructure.getInstance().create(newDept);
                        TreeNode newNode = new TreeNode(newDept.Name);
                        structureTree.SelectedNode.Nodes.Add(newNode);
                        structureTree.SelectedNode = newNode;
                        structureTree.Focus();
                        deptName.Text = "";
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (structureTree.SelectedNode != null)
            {
                Department dept = getDepartment(structureTree.SelectedNode);
                if (dept.Equals(OrganizationStructure.getInstance().Root))
                {
                    MessageBox.Show("سازمان نمی‌تواند برای مشاهده انتخاب شود", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    (new ViewDepartmentForm(dept)).ShowDialog();
                }
            }
        }
    }
}
