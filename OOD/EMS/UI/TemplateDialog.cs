using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOD.EMS.UI
{
    public partial class TemplateDialog : Form
    {
        public TemplateDialog()
        {
            InitializeComponent();
        }

        private void DialogTemplate_Load(object sender, EventArgs e)
        {

        }

        protected String convert(String old)
        {
            char[][] numbers = new char[][]
            {
                "0123456789".ToCharArray(),"۰۱۲۳۴۵۶۷۸۹".ToCharArray()
            };
            for (int x = 0; x <= 9; x++)
            {
                old.Replace(numbers[0][x], numbers[1][x]);
            }
            return old;
        }
    }
}
