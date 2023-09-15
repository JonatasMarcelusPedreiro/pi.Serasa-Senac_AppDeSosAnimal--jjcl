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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            carregainfos();
        }

        void carregainfos()
        {
            List<Animais> listaAnimais = new List<Animais>();
            Animais animais = new Animais();

            listaAnimais = animais.busca_todos();

            foreach (Animais a in listaAnimais)
            {
                geraInfos(a);
            }
        }

        int Xsitu = 100;
        int Ysitu = 300;
        int Ximagem = 20;
        int Yimagem = 300;

        int Xanimal = 0;
        int Yanimal = 0;

        int quebraLinha;

        void geraInfos(Animais animal)
        {
            PictureBox pic = new PictureBox();

            try
            {
                // Converte a string base64 de volta para um array de bytes
                byte[] imageBytes = Convert.FromBase64String(animal.imagem);

                // Cria um objeto de imagem a partir dos bytes
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    Image imagem = Image.FromStream(ms);

                    // Define a imagem no PictureBox
                    pic.Image = imagem;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }

            pic.Size = new Size(200, 200);
            

            painelANIMAL.Controls.Add(pic);

            //Label label = new Label();
            //label.Text = animal.situacao;
            //label.ForeColor = Color.White;
            //label.Location = new Point(Xsitu,Ysitu);

            //Label label2 = new Label();
            //label2.Text = animal.animal;
            //label2.ForeColor = Color.White;
            //label2.Location = new Point(Xanimal, Yanimal);


            //painelANIMAL.Controls.Add(label);
            //painelANIMAL.Controls.Add(label2);

            Xanimal = Xanimal + 100;
            Xsitu = Xsitu + 100;

            quebraLinha++;

            if (quebraLinha == 5)
            {
                Xsitu = 200;
                Ysitu = Ysitu + 300;
            }

            Xanimal = Xanimal + 100;

            quebraLinha++;

            if (quebraLinha == 5)
            {
                Xanimal = 200;
                Yanimal = Yanimal + 300;
            }

        }
    }
}
