using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom
{
    public partial class RAKA : Form
    {
        public RAKA()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.katAVTOTableAdapter.Fill(this.roman_KursovoyDataSet.KatAVTO, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(data1ToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
