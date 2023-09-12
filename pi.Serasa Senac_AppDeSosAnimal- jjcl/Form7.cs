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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnadmentrar_Click(object sender, EventArgs e)
        {

            string nomeadm = txtnomeadm.Text;
            string senhaadm = txtsenhaadm.Text;






            if (nomeadm == "adm" && senhaadm == "adm123")
            {


                // Todos os campos estão preenchidos, então abra a Form4
                Form2 tela = new Form2();
                tela.Show();




            }
            else
            {
                MessageBox.Show("Faça login com funcionário!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtnomeadm.Text;
            string senha = txtsenhaadm.Text;
            Funcionarios f = new Funcionarios();
            f = f.Login(nome, senha);
            if(nome == "" && senha == "")
            {
                MessageBox.Show("Usuário ou senha incorreta");
                return;
            }
            if(f == null)
            {
                MessageBox.Show("Login incorreto");
                return;
            }
            
            // Todos os campos estão preenchidos, então abra a Form4
            Form5 tela = new Form5();
            tela.Show();
            
        }
    }
}
