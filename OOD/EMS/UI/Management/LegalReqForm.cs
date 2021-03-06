﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Users;

namespace OOD.EMS.UI.Management
{
    public partial class LegalReqForm : TemplateForm
    {
        public LegalReqForm()
        {
            InitializeComponent();
            load_goals();

            AccessLevel level = Authentication.getInstance().ActiveUser.ALevel;
            if (!level.canModifyManagementDocs())
            {
                add.Visible = false;
                edit.Location = new System.Drawing.Point(edit.Location.X, edit.Location.Y + 45);
            }
        }
       

        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (LegalConstraint doc in LegalConstraintStorage.getInstance().all())
            {
                object[] row = new object[] { doc.Title, doc.getDateString(), doc.Description };
                this.dataGridView1.Rows.Add(row);
            }
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddLegalReqForm add = new AddLegalReqForm("", "");
            DialogResult res = add.ShowDialog();
            if (res == DialogResult.OK)
            {
                LegalConstraint doc = new LegalConstraint(add.name, add.dscp);
                foreach (Attachment attach in add.attachments)
                {
                    doc.addAttachment(attach);
                }
                LegalConstraintStorage.getInstance().create(doc);
            }
            load_goals();
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                LegalConstraint goal = null;
                try
                {
                    goal = LegalConstraintStorage.getInstance().all().Find(x => x.Title.Equals(name));
                }
                catch (Exception)
                {
                }

                if (goal != null)
                {
                    (new ViewLegalReqForm(goal)).ShowDialog();
                }
            }
        }

        
    }
}
