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
    public partial class ViewRelationForm : TemplateDialog
    {
        ManagementDocument first, second;
        
        public ViewRelationForm(ManagementDocumentRelation relation)
        {
            InitializeComponent();
            if (relation is GeneralGoal_LegalConstraintRelation)
            {
                first = ((GeneralGoal_LegalConstraintRelation)relation).GenGoal;
                second =  ((GeneralGoal_LegalConstraintRelation)relation).LegConst;
                
            }
            else if (relation is GeneralGoal_EnvironEffectRelation)
            {
                first = ((GeneralGoal_EnvironEffectRelation)relation).GenGoal;
                second = ((GeneralGoal_EnvironEffectRelation)relation).EnvEffect;
            }
            else if (relation is LegalConstraint_EnvironEffectRelation)
            {
                first = ((LegalConstraint_EnvironEffectRelation)relation).LegConst;
                second = ((LegalConstraint_EnvironEffectRelation)relation).EnvEffect;
            }

            DateBox.Text = relation.getDateString();
            userBox.Text = relation.RelationUser.Firstname + " " + relation.RelationUser.Lastname;
            viewDoc1.Text = first.Title;
            viewDoc2.Text = second.Title;
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewDoc1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (first is GeneralGoal)
            {
                (new ViewGeneralGoalForm((GeneralGoal)first)).Show();
            }
            else if (first is LegalConstraint)
            {
                (new ViewLegalReqForm((LegalConstraint)first)).Show();
            }
            else if (first is EnvironEffect)
            {
                (new ViewEffectForm((EnvironEffect)first)).Show();
            }
        }

        private void viewDoc2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (second is GeneralGoal)
            {
                (new ViewGeneralGoalForm((GeneralGoal)second)).Show();
            }
            else if (second is LegalConstraint)
            {
                (new ViewLegalReqForm((LegalConstraint)second)).Show();
            }
            else if (second is EnvironEffect)
            {
                (new ViewEffectForm((EnvironEffect)second)).Show();
            }
        }


    }
}
