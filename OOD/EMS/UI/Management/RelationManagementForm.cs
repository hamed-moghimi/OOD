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
using OOD.EMS.Exceptions;

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
            if (docType1.SelectedItem == null || docType2.SelectedItem == null ||
                rel1Grid.CurrentCell == null || rel2Grid.CurrentCell == null)
            {
                MessageBox.Show(new IncompleteFormException().Message);
            }
            else
            {
                String[] selected = new String[] { docType1.SelectedItem.ToString(), docType2.SelectedItem.ToString()};
                int genIndex = Array.IndexOf(selected, "اهداف کلان");
                int legalIndex = Array.IndexOf(selected, "الزامات قانونی");
                int effectIndex = Array.IndexOf(selected, "تاثیرات زیست‌محیطی");
                if (genIndex >= 0 && legalIndex >= 0)
                {
                    GeneralGoal goal = null;
                    LegalConstraint doc = null;
                    if (genIndex == 0)
                    {
                        String name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = LegalConstraintStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        
                    }
                    else
                    {
                        String name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = LegalConstraintStorage.getInstance().all().Find(x => x.Title.Equals(name));
                    }

                    GeneralGoal_LegalConstraintRelationStorage.getInstance().create(new GeneralGoal_LegalConstraintRelation
                            (goal, doc));
                }
                else if (genIndex >= 0 && effectIndex >= 0)
                {
                    GeneralGoal goal = null;
                    EnvironEffect doc = null;
                    if (genIndex == 0)
                    {
                        String name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = EnvironEffectStorage.getInstance().all().Find(x => x.Title.Equals(name));

                    }
                    else
                    {
                        String name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = GeneralGoalStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = EnvironEffectStorage.getInstance().all().Find(x => x.Title.Equals(name));
                    }

                    GeneralGoal_EnvironEffectRelationStorage.getInstance().create(new GeneralGoal_EnvironEffectRelation
                            (goal, doc));
                }
                else if (legalIndex >= 0 && effectIndex >= 0)
                {
                    EnvironEffect goal = null;
                    LegalConstraint doc = null;
                    if (effectIndex == 0)
                    {
                        String name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = EnvironEffectStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = LegalConstraintStorage.getInstance().all().Find(x => x.Title.Equals(name));

                    }
                    else
                    {
                        String name = (string)rel2Grid.Rows[rel2Grid.SelectedRows[0].Index].Cells[0].Value;
                        goal = EnvironEffectStorage.getInstance().all().Find(x => x.Title.Equals(name));
                        name = (string)rel1Grid.Rows[rel1Grid.SelectedRows[0].Index].Cells[0].Value;
                        doc = LegalConstraintStorage.getInstance().all().Find(x => x.Title.Equals(name));
                    }

                    LegalConstraint_EnvironEffectRelationStorage.getInstance().create(new LegalConstraint_EnvironEffectRelation
                            (goal, doc));
                }
                Close();
            }

            
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

        private void docType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected = docType2.SelectedItem;
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

            rel2Grid.Rows.Clear();
            foreach (ManagementDocument doc in list)
            {
                object[] row = new object[] { doc.Title };
                rel2Grid.Rows.Add(row);
            }

            List<String> docList = new List<String>(new String[] { "اهداف کلان", "الزامات قانونی", "تاثیرات زیست‌محیطی" });
            docList.Remove(selected.ToString());
            Object selected2 = docType1.SelectedItem;
            if (selected2 == null)
            {
                docType1.Items.Clear();
                docType1.Items.AddRange(docList.ToArray<String>());
            }
            else
            {
                int res = docType1.FindString(selected.ToString());
                if (res >= 0)
                {
                    int index = docList.FindIndex(x => x.Equals(selected2.ToString()));
                    docType1.Items.Clear();
                    docType1.Items.AddRange(docList.ToArray<String>());
                    docType1.SelectedIndex = index;
                }
            }
        }       
    }
}
