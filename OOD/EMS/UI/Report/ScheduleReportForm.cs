﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.EMS.UI.ReportForms
{
    public partial class ScheduleReportForm : TemplateForm
    {
        public ScheduleReportForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ScheduleReportForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.schedules)
                dataGridView1.Rows.Add(row);
        }
    }
}