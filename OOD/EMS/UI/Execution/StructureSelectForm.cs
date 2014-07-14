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

namespace OOD.EMS.UI.Execution
{
    public partial class StructureSelectForm : TemplateDialog
    {
        public Department Section { get; set; }

        public StructureSelectForm()
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            TreeNode selected = structureTree.SelectedNode;
            if (selected != null)
            {
                Section = getDepartment(selected);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
        }

    }
}
