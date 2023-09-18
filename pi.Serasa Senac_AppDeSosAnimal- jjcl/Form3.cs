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

            
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            Painel3.Location = new Point(ClientSize.Width / 2 - Painel3.Size.Width / 2, ClientSize.Height / 2 - Painel3.Size.Height / 2);

            Painel3.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string nome = TXTnome.Texts;
            string senha = TXTsenha.Texts;

            Usuarios u = new Usuarios();
            u = u.Login(nome, senha);
            if (nome == "" && senha == "")
            {
                MessageBox.Show("Usuário ou senha incorreta");
                return;
            }
            if (u == null)
            {
                MessageBox.Show("Login incorreto");
                return;
            }
            this.Close();
            Form4 tela = new Form4();
            tela.Show();
        }
    }
}
