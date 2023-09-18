using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string link = "https://wa.me/5516996468617";

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            };

            Process.Start(psi);




        }
        public void btnAbrirWhatsApp_Click(object sender, EventArgs e)
        {

        }

        public void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public void AbrirLink(string link)
        {

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            string link1 = "https://www.paypal.com/donate/?hosted_button_id=Q8S97X9F2RCUA";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = link1,
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void btnanimais_Click(object sender, EventArgs e)
        {
            Form8 tela = new Form8();
            tela.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {

        }
    }

}
