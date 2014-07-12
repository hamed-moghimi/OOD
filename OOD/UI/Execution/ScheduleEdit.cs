using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class ScheduleEdit : OOD.DialogTemplate
    {
        private object[] resource;
        private bool canEdit = false;

        public ScheduleEdit(bool canEdit, object[] resource)
        {
            this.resource = resource;
            this.canEdit = canEdit;
            InitializeComponent();
        }

        private void ScheduleEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.tasks)
                dataGridView1.Rows.Add(row);
        }
    }
}
