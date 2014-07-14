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

namespace OOD.EMS.UI.ExecutiveForms
{
    public partial class TaskForm : TemplateForm
    {
        public TaskForm()
        {
            InitializeComponent();
            load_tasks();
        }

        private void load_tasks()
        {
            dataGridView1.Rows.Clear();
            foreach (OOD.EMS.Execution.Task r in TaskStorage.getInstance().all())
            {
                object[] row = new object[] { r.Title, r.Description };
                dataGridView1.Rows.Add(row);
            }
        }


        private void editButton_Click(object sender, EventArgs e)
        {
            String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            EMS.Execution.Task prev = TaskStorage.getInstance().all().Find(x => x.Title.Equals(title));
            TaskEditForm f = new TaskEditForm(prev); DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                prev.Title = (string)f.name;
                prev.StartDate = Convert.ToDateTime(f.fromDate);
                prev.DueDate = Convert.ToDateTime(f.toDate);
                prev.Description = f.dscp;
                prev.department = f.manager;
            }
            load_tasks();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            TaskEditForm f = new TaskEditForm(null);
            DialogResult res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                TaskStorage.getInstance().create(new EMS.Execution.Task(f.name, Convert.ToDateTime(f.fromDate),
                            Convert.ToDateTime(f.toDate), 0, f.manager, f.dscp));
                
            }
            load_tasks();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String title = (string)dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value;
            EMS.Execution.Task prev = TaskStorage.getInstance().all().Find(x => x.Title.Equals(title));
            (new ViewTaskForm(prev)).ShowDialog();
        }
    }
}
