using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOD.EMS.Management;

namespace OOD.EMS.UI.Management
{
    public partial class RelationManagementForm : TemplateForm
    {
        public RelationManagementForm()
        {
            this.menu.Visible = false;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void docType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = docType1.SelectedItem;
            List<ManagementDocument> list = null;

            if (selected.ToString() == "اهداف کلان")
            {
                list = GeneralGoalStorage.getInstance().all().Cast<ManagementDocument>().ToList();    
            }
            else if (selected.ToString() == "الزامات قانونی")
            {
                list = LegalConstraintStorage.getInstance().all().Cast<ManagementDocument>().ToList();
            }
            else if (selected.ToString() == "تاثیرات زیست‌محیطی")
            {
                list = EnvironEffectStorage.getInstance().all().Cast<ManagementDocument>().ToList();
            }

            rel1Grid.Rows.Clear();
            foreach (ManagementDocument doc in list)
            {
                object[] row = new object[] { doc.Title };
                rel1Grid.Rows.Add(row);
            }

            List<String> docList = new List<String>(new String[] { "اهداف کلان", "الزامات قانونی", "تاثیرات زیست‌محیطی" });
            docList.Remove(selected.ToString());
            Object selected2 = docType2.SelectedItem;
            if (selected2 == null)
            {
                docType2.Items.Clear();
                docType2.Items.AddRange(docList.ToArray<String>());
            }
            else
            {
                int res = docType2.FindString(selected.ToString());
                if (res >= 0)
                {
                    int index = docList.FindIndex(x => x.Equals(selected2.ToString()));
                    docType2.Items.Clear();
                    docType2.Items.AddRange(docList.ToArray<String>());
                    docType2.SelectedIndex = index;
                }
            }
        }       
    }
}
