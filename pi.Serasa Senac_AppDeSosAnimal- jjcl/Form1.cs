using System.Windows.Automation;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            Painel.Location = new Point(ClientSize.Width / 2 - Painel.Size.Width / 2, ClientSize.Height / 2 - Painel.Size.Height / 2);

            this.WindowState=FormWindowState.Maximized;
        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

            string nome = txtnome.Texts; 
            string cpf = txtcpf.Texts;
            string tel = txttelefone.Texts;



          
            if (nome == "" || cpf == "" || tel == "")
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrocompleto_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2 ();
            tela.Show();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }

        private void txtnome__TextChanged(object sender, EventArgs e)
        {

        }
    }

}