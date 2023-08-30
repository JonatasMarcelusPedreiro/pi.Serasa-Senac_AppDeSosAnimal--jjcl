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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Painel2.Location = new Point(ClientSize.Width / 2 - Painel2.Size.Width / 2, ClientSize.Height / 2 - Painel2.Size.Height / 2);
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            string nome = txtnomecdcompleto.Texts;
            string senha = txtsenhacdcompleto.Texts;
            string tel = txttelcdcompleto.Texts;
            string email = txtemailcdcompleto.Texts;
            string cpf = txtcpfcompleto.Texts;




            if (nome == "" || cpf == "" || tel == "" || senha == "" || email == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");


            }
            else
            {
                // Todos os campos estão preenchidos, então abra a Form4
                Form4 tela = new Form4();
                tela.Show();

            }
        }
    }
}