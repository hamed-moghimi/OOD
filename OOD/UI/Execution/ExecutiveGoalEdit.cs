﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OOD.ExecutiveForms
{
    public partial class ExecutiveGoalEdit : OOD.DialogTemplate
    {
        private object[] resource;
        private bool canEdit = false;

        public ExecutiveGoalEdit(bool canEdit, object[] resource)
        {
            this.resource = resource;
            this.canEdit = canEdit;
            InitializeComponent();
        }

        public object[] Resource
        {
            get { return resource; }
        }

        private void ResourceEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StructureSelect s = new StructureSelect();
            s.ShowDialog();
            responsibleBox.Text = s.Section;
        }

        private void ExecutiveGoalEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (object[] row in StaticData.generalGoals)
            {
                this.dataGridView1.Rows.Add(row);
            }
        }
    }
}