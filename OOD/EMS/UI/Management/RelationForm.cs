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
    public partial class RelationForm : TemplateForm
    {

        DataGridView goalLegalGrid, goalEffectGrid, legalEffectGrid;
        public RelationForm()
        {
            InitializeComponent();

            goalLegalGrid = getRelationGrid("goalLegalGrid");
            goalEffectGrid = getRelationGrid("goalEffectGrid");
            legalEffectGrid = getRelationGrid("legalEffectGrid");
            tabRelations.TabPages[0].Text = "هدف کلان - الزام قانونی";
            tabRelations.TabPages[0].Controls.Add(goalLegalGrid);
            tabRelations.TabPages[1].Text = "هدف کلان - تاثیر زیست‌محیطی";
            tabRelations.TabPages[1].Controls.Add(goalEffectGrid);
            tabRelations.TabPages[2].Text = "الزام قانونی - تاثیر زیست‌محیطی";
            tabRelations.TabPages[2].Controls.Add(legalEffectGrid);

            load_relations();
        }

        private void load_relations()
        {
            goalLegalGrid.Rows.Clear();
            foreach (GeneralGoal_LegalConstraintRelation rel in GeneralGoal_LegalConstraintRelationStorage.getInstance().all())
            {
                object[] row = new object[] { rel.GenGoal.Title, rel.LegConst.Title, rel.getDateString() };
                goalLegalGrid.Rows.Add(row);
            }

            goalEffectGrid.Rows.Clear();
            foreach (GeneralGoal_EnvironEffectRelation rel in GeneralGoal_EnvironEffectRelationStorage.getInstance().all())
            {
                object[] row = new object[] { rel.GenGoal.Title, rel.EnvEffect.Title, rel.getDateString() };
                goalEffectGrid.Rows.Add(row);
            }

            legalEffectGrid.Rows.Clear();
            foreach (LegalConstraint_EnvironEffectRelation rel in LegalConstraint_EnvironEffectRelationStorage.getInstance().all())
            {
                object[] row = new object[] { rel.LegConst.Title, rel.EnvEffect.Title, rel.getDateString() };
                legalEffectGrid.Rows.Add(row);
            }
        }

        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            (new RelationManagementForm()).ShowDialog();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            (new RelationManagementForm()).ShowDialog();
        }

        
        private DataGridView getRelationGrid(String name)
        {
            DataGridView dataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGrid)).BeginInit();

            DataGridViewColumn first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewColumn second = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DataGridViewColumn Date = new System.Windows.Forms.DataGridViewTextBoxColumn();

            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            first,
            second,
            Date});
            dataGrid.Location = new System.Drawing.Point(0,0);
            dataGrid.Name = name;
            dataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new System.Drawing.Size(591, 211);
            dataGrid.TabIndex = 3;

            // 
            // first
            // 
            first.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            first.HeaderText = "سند اول ارتباط";
            first.Name = "first";
            first.ReadOnly = true;
            first.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // second
            // 
            second.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            second.HeaderText = "سند دوم ارتباط";
            second.Name = "second";
            second.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "تاریخ";
            Date.Name = "Date";
            Date.ReadOnly = true;

            return dataGrid;
        }

    }
}
