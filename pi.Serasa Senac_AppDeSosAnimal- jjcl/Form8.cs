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

        int Ximagem = 100;
        int Yimagem = 0;
        int Xnome = 100;
        int Ynome = 200;
        int Xsitu = 100;
        int Ysitu = 240;
        int Xsexo = 100;
        int Ysexo = 290;

        int quebraLinha;

        void geraInfos(Animais animal)
        {
            PictureBox pic = new PictureBox();

            try
            {
                byte[] imageBytes = Convert.FromBase64String(animal.imagem);
                using (var ms = new System.IO.MemoryStream(imageBytes))
                {
                    Image originalImage = Image.FromStream(ms);

                    // Defina as dimensões desejadas para a imagem redimensionada
                    int novaLargura = 300;
                    int novaAltura = 200;

                    // Redimensione a imagem para se ajustar às dimensões desejadas
                    Image imagemRedimensionada = RedimensionarImagem(originalImage, novaLargura, novaAltura);

                    // Atribua a imagem redimensionada ao controle PictureBox
                    pic.Image = imagemRedimensionada;

                    // Defina o tamanho do PictureBox
                    pic.Size = new Size(novaLargura, novaAltura);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem: " + ex.Message);
            }

            
             Image RedimensionarImagem(Image imagemOriginal, int largura, int altura)
            {
                Bitmap imagemRedimensionada = new Bitmap(largura, altura);
                using (Graphics g = Graphics.FromImage(imagemRedimensionada))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(imagemOriginal, 0, 0, largura, altura);
                }
                return imagemRedimensionada;
            }



            Label label = new Label();
            label.Text = animal.animal;
            label.ForeColor = Color.White;
            label.Location = new Point(Xnome, Ynome);
            label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            label.Size = new Size(200, 40);

            Label label2 = new Label();
            label2.Text = animal.situacao;
            label2.ForeColor = Color.White;
            label2.Location = new Point(Xsitu, Ysitu);
            label2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            label2.Size = new Size(200, 50);

            Label label3 = new Label();
            label3.Text = $"Gênero:{animal.sexo}";
            label3.ForeColor = Color.White;
            label3.Location = new Point(Xsexo, Ysexo);
            label2.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            label2.Size = new Size(100, 50);





            painelANIMAL.Controls.Add(pic);
            painelANIMAL.Controls.Add(label);
            painelANIMAL.Controls.Add(label2);
            painelANIMAL.Controls.Add(label3);
            pic.Location = new Point(Ximagem, Yimagem);
            Xsitu = Xsitu + 300;
            Ximagem = Ximagem + 350;
            Xnome = Xnome + 300;
            Xsexo = Xsexo + 300;
            quebraLinha++;

            if (quebraLinha == 4)
            {
                Ximagem = 100;
                Yimagem = Yimagem + 350;
                Xnome = 100;
                Ynome = Ynome + 350;
                Xsitu = 100;
                Ysitu = Ysitu + 350;
                Xsexo = 100;
                Ysexo = Ysexo + 350;
            }
            if (quebraLinha == 8)
            {
                Ximagem = 100;
                Yimagem = Yimagem + 350;
                Xnome = 100;
                Ynome = Ynome + 350;
                Xsitu = 100;
                Ysitu = Ysitu + 350;
                Xsexo = 100;
                Ysexo = Ysexo + 350;
            }
            if (quebraLinha == 12)
            {
                Ximagem = 100;
                Yimagem = Yimagem + 350;
                Xnome = 100;
                Ynome = Ynome + 350;
                Xsitu = 100;
                Ysitu = Ysitu + 350;
                Xsexo = 100;
                Ysexo = Ysexo + 350;
            }
            if (quebraLinha == 14)
            {
                Ximagem = 100;
                Yimagem = Yimagem + 350;
                Xnome = 100;
                Ynome = Ynome + 350;
                Xsitu = 100;
                Ysitu = Ysitu + 350;
                Xsexo = 100;
                Ysexo = Ysexo + 350;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void painelANIMAL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form8_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            carregainfos();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }
    }
}
