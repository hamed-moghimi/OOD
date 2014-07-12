﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.UserManagement
{
    public partial class UserManagement : Template
    {
        public UserManagement()
        {
            InitializeComponent();
            foreach (object[] row in StaticData.users)
            {
                dataGridView1.Rows.Add(row);
            }
        }



        private void delete_Click(object sender, EventArgs e)
        {
            ask_confirm();
            int i = dataGridView1.SelectedRows[0].Index;
            dataGridView1.Rows.RemoveAt(i);
        }

        private void add_Click(object sender, EventArgs e)
        {
            (new Add_User()).ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new Edit_User()).ShowDialog();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}