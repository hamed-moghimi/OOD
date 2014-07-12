using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOD.Audit
{
    public partial class Audit_Executive_List : Template
    {
        public Audit_Executive_List()
        {
            InitializeComponent();
            foreach (object[] row in StaticData.executiveGoals)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }

        private void Audit_Click(object sender, EventArgs e)
        {
            (new Audit_Executive()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
