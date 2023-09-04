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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void btncdcompleto_Click(object sender, EventArgs e)
        {

            string nome2 = txtcdcompletonome.Texts;
            string cpf2 = txtcdcompletocpf.Texts;
            string tel2 = txtcdcompletotel.Texts;
            string senha = txtcdcompletosenha.Texts;
            string email = txtcdcompletoemail.Texts;




            if (nome2 == "" || cpf2 == "" || tel2 == "" || email == "" || senha == "")
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
