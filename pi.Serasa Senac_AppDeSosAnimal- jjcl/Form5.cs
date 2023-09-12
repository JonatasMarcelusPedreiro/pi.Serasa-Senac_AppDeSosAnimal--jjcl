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

        public InfoAnimais(Form5 form5)
        {
            InitializeComponent();
            form5Reference = form5; // Armazena a referência de Form1
        }

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

            if (animal == "" && situacao == "" && sexo == "")
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

        private void btnImagem_Click(object sender, EventArgs e)
        {
            InfoAnimais novoForm = new InfoAnimais();

            // Crie um PictureBox e um Label
            PictureBox pictureBox = new PictureBox();
            Label label = new Label();

            // Configure propriedades do PictureBox


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                openFileDialog.Filter = "Arquivos de Imagem|.jpg;.jpeg;.png;.gif;.bmp|Todos os Arquivos|.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoDaImagem = openFileDialog.FileName;
                    pbInfoAnimais = Image.FromFile(caminhoDaImagem);
                }

                pictureBox.Location = new Point(20, 20);
                pictureBox.Size = new Size(200, 200);

                // Configure propriedades do Label
                label.Location = new Point(20, 230);
                label.Text = "Texto do Label";

                // Adicione o PictureBox e o Label ao novo formulário
                novoForm.Controls.Add(pictureBox);
                novoForm.Controls.Add(label);
            }
        }
    }
}
