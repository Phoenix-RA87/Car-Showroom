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
    public partial class RAVD : Form
    {
        public RAVD()
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

        private void dogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.roman_KursovoyDataSet);

        }

        private void RAVD_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roman_KursovoyDataSet.Dog". При необходимости она может быть перемещена или удалена.
            this.dogTableAdapter.Fill(this.roman_KursovoyDataSet.Dog);

        }
    }
}
