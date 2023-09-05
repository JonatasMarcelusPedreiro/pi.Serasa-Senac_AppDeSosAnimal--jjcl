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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void btncadastrarfuncionarios_Click(object sender, EventArgs e)
        {
            string animal = txtAnimal.Text;
            string situacao = txtSITUACAO.Text;
            string sexo = txtsexoanimal.Text;
            int id = 0;

            if (animal == "" && situacao == "" &&  sexo == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Animais animais = new Animais(id, animal, situacao, sexo);
                animais.Insere(animais);
                txtAnimal.Clear();
                txtsexoanimal.Clear();
                txtSITUACAO.Clear();
            }
        }
    }
}
