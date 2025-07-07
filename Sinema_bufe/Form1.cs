using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_bufe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        int kasatura = 0;  // global alana tanımladım her seferinde kasatutarı sıfır olmasın diye
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, cay, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);

            toplam = misir * 4 + su * 1 + bilet * 8 + cay * 2;
            LblToplam.Text=toplam.ToString() + "TL" ;

            kasatura = kasatura + toplam;
            LblKasa.Text= kasatura.ToString() + "TL";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtBilet.Text = " ";
            TxtCay.Text = " ";
            TxtMisir.Text = " ";
            TxtSu.Text = " ";
            TxtMisir.Focus(); // TEMİZLEDİKTEN SONRA MISIRA FOKUSLASIN
        }
    }
}
