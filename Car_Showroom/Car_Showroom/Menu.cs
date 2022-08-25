using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Car_Showroom
{
    public partial class RAMenu : Form
    {
        Thread th;
        public RAMenu()
        {
            InitializeComponent();
        }

        private void сменаПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread (openSP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openSP(Object obj)
        {
            Application.Run(new RAAvtor());
        }

        private void вводПоставщикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openVP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openVP(Object obj)
        {
            Application.Run(new RAVP());
        }

        private void вводДоговораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openVA);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openVA(Object obj)
        {
            Application.Run(new RAVA());
        }

        private void вводДоговораToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            th = new Thread(openVD);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openVD(Object obj)
        {
            Application.Run(new RAVD());
        }

        private void вводРекламацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openVR);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openVR(Object obj)
        {
            Application.Run(new RAVR());
        }

        private void сводныйОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openSO);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openSO(Object obj)
        {
            Application.Run(new RASO());
        }

        private void журналПоступившейРекламацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openJPR);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openJPR(Object obj)
        {
            Application.Run(new RAJPR());
        }

        private void журналПродажАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openJPA);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openJPA(Object obj)
        {
            Application.Run(new RAJPA());
        }

        private void каталогАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openKA);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openKA(Object obj)
        {
            Application.Run(new RAKA());
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            th = new Thread(openOP);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openOP(Object obj)
        {
            Application.Run(new RAATP());
        }
    }
}
