using MySql.Data.MySqlClient;
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

        public Form5 form5Reference;

        InfoAnimais infoAnimais = new InfoAnimais();

        //public InfoAnimais(Form5 form5)
        //{
        //    InitializeComponent();
        //    form5Reference = form5; // Armazena a referência de Form1
        //}

        public Form5()
        {
            InitializeComponent();
        }

        private void btncadastrarfuncionarios_Click(object sender, EventArgs e)
        {

        }

        private void btnImagem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Imagens|*.jpg;*.jpeg;*.png;*.jpg_large";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    try
                    {
                      
                        string animal = txtAnimal.Text;
                        string situacao = txtSITUACAO.Text;
                        string sexo = txtsexoanimal.Text;
                        int id = 0;
                        string imagem = "";

                        string imagemBase64 = Convert.ToBase64String(imageBytes);

                        Animais animais = new Animais(id, animal, situacao, sexo, imagemBase64);
                        animais.Insere(animais);

                      //  string sql = $"insert into animais (animal, situacao, sexo, imagem) values ('{animais.animal}', '{animais.situacao}', '{animais.sexo}', '@imagem' );";

                        txtAnimal.Clear();
                        txtsexoanimal.Clear();
                        txtSITUACAO.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir imagem: " + ex.Message);
                    }
                }
                

                /*if (animal == "" && situacao == "" && sexo == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    
                }*/
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
