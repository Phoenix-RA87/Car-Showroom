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
    public partial class RAVA : Form
    {
        public RAVA()
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

        private void aVTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aVTOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.roman_KursovoyDataSet);

        }

        private void RAVA_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "roman_KursovoyDataSet.AVTO". При необходимости она может быть перемещена или удалена.
            this.aVTOTableAdapter.Fill(this.roman_KursovoyDataSet.AVTO);

        }
    }
}
