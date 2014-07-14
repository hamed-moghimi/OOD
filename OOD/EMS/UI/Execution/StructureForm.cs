using System;
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

namespace OOD.EMS.UI.ExecutiveForms
{
    public partial class StructureForm : TemplateForm
    {
        public StructureForm()
        {
            InitializeComponent();
            load_structure();    
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
                OrganizationStructure.getInstance().remove(getDepartment(selected));
                structureTree.Nodes.Remove(selected);
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
                MessageBox.Show(new IncompleteFormException().Message);
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
    }
}
