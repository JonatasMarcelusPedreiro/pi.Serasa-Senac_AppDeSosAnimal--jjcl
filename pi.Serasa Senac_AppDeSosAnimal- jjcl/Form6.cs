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

            string nome = txtcdcompletonome.Texts;
            string cpf = txtcdcompletocpf.Texts;
            string telefone = txtcdcompletotel.Texts;
            string email = txtcdcompletoemail.Texts;
            string senha = txtcdcompletosenha.Texts;



            if (nome == "" || cpf == "" || telefone == "" || email == "" || senha == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");
                return;
            }
            Usuarios u = new Usuarios();
            u = u.verifica_cpf(cpf);
            if (u == null)
            {
                if (cpf.Length != 11)
                {
                    MessageBox.Show("CPF invalido");
                    return;
                }
                Usuarios usuarios = new Usuarios(nome, email, senha, cpf, telefone);


                usuarios.Insere_completo(usuarios);
                // Todos os campos estão preenchidos, então abra a Form4
                Form3 tela = new Form3();
                tela.Show();


            }
            else
            {
                MessageBox.Show("CPF já está em uso");
                return;
            }


        }

        private void Painel_Paint_1(object sender, PaintEventArgs e)
        {
            Painelcadastrar.Location = new Point((Painelcadastrar.ClientSize.Width - Painelcadastrar.Width) / 2, (Painelcadastrar.ClientSize.Height - Painelcadastrar.Height) / 2);

            Painelcadastrar.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }
    }
}
