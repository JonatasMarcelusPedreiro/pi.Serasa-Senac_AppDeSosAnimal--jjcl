using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form4 tela = new Form4();
            tela.Show();
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            Painel3.Location = new Point(ClientSize.Width / 2 - Painel3.Size.Width / 2, ClientSize.Height / 2 - Painel3.Size.Height / 2);
        }
    }
}
