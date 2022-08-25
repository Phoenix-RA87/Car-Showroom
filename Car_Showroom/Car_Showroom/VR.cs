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
    public partial class RAVR : Form
    {
        public RAVR()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("Вы действительно хотите выйти?",
                                             "Выход из программы",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            { Close(); }
            else
            { return; }
        }

        private void reklamacBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reklamacBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.roman_KursovoyDataSet);

        }

        private void RAVR_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roman_KursovoyDataSet.Reklamac". При необходимости она может быть перемещена или удалена.
            this.reklamacTableAdapter.Fill(this.roman_KursovoyDataSet.Reklamac);

        }
    }
}
