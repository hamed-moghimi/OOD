using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class StructureSelectForm : OOD.TemplateDialog
    {
        public string Section { get; set; }

        public StructureSelectForm()
        {
            InitializeComponent();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            Section = treeView1.SelectedNode.Text;
            this.Close();
        }
    }
}
