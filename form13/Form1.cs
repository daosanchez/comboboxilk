using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int dogru, yanlıs;
            double netDogru;
            dogru = Convert.ToInt32(cmbDogru.Text);
            yanlıs = Convert.ToInt32(cmbYanlıs.Text);

            netDogru = dogru - yanlıs / 4.0;

            lblNet.Text = "Toplam Net Doğru :" + netDogru.ToString();
        }
    }
}
