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

            string nome = txtdecompletonome.Texts;
            string cpf = txtcdcompletocpf.Texts;
            string telefone = txtcdcompletotel.Texts;
            string email = txtcdcompletoemail.Texts;
            string senha = txtcdcompletosenha.Texts;




            if (nome == "" || cpf == "" || telefone == ""|| email == ""|| senha == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");


            }
            else
            {
                int cpf = int.Parse(txtcdcompletocpf.Texts);
                
                Usuarios usuarios = new Usuarios(nome, cpf, email, senha, telefone);


                usuarios.Insere_completo(usuarios);
                // Todos os campos estão preenchidos, então abra a Form4
                Form4 tela = new Form4();
                tela.Show();

            }
        }
    }
}
