﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.Management
{
    public partial class Relation : Template
    {
        public Relation()
        {
            InitializeComponent();
            foreach (object[] row in StaticData.relations)
            {
                dataGridView1.Rows.Add(row);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            (new RelationManagement()).ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new RelationManagement()).ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
        }


    }
}