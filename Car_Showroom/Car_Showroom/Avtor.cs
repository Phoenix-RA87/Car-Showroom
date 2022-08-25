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
    public partial class RAAvtor : Form
    {
        DataBase dataBase = new DataBase();

        Thread th;



        public RAAvtor()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void open(Object obj)
        {
            Application.Run(new RAMenu());
        }

        private void textBox1_Password_TextChanged(object sender, EventArgs e)
        {

        }

    }

}

