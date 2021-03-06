﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using OOD.EMS.Management;
using OOD.EMS.Users;
using OOD.EMS.Exceptions;

namespace OOD.EMS.UI.Execution
{
    public partial class SelectGeneralGoalForm : TemplateDialog
    {

        public GeneralGoal goal { get; set; }
        public int cont { get; set; }

        public SelectGeneralGoalForm()
        {
            InitializeComponent();
            load_goals();
        }


        private void load_goals()
        {
            dataGridView1.Rows.Clear();
            foreach (GeneralGoal goal in GeneralGoalStorage.getInstance().all())
            {
               dataGridView1.Rows.Add(new Object[] { goal.Title, goal.getDateString() });
                
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    String contStr = convert(conBox.Text.Trim());
                    cont = Convert.ToInt32(contStr);
                    String name = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
                    goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(new IncompleteFormException().Message);
                }
            }
        }



    }
}
