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
            WindowState = FormWindowState.Maximized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
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
                
                
                Usuarios usuarios = new Usuarios(nome, cpf, tel);
                

                usuarios.Insere_rapido(usuarios);
                // Todos os campos est�o preenchidos, ent�o abra a Form4
                Form4 tela = new Form4();
                tela.Show();

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrocompleto_Click(object sender, EventArgs e)
        {
            Form6 tela = new Form6();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
            Form7 tela = new Form7();
            tela.Show();
        }

        private void Painel_Paint(object sender, PaintEventArgs e)
        {
            Painel.Location = new Point((Painel.ClientSize.Width - Painel.Width) / 2, (Painel.ClientSize.Height - Painel.Height) / 2);

            this.WindowState = FormWindowState.Maximized;
            Painel.Dock = DockStyle.Fill;


        }

        private void btncadastrocompleto_Click_1(object sender, EventArgs e)
        {
            Form6 tela = new Form6();
            tela.Show();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Painel.Location = new Point((Painel.ClientSize.Width - Painel.Width) / 2, (Painel.ClientSize.Height - Painel.Height) / 2);
        }

        private void cadastrorapido_Click(object sender, EventArgs e)
        {

            string nome = txtnome.Texts;
            string cpf = txtcpf.Texts;
            string tel = txttelefone.Texts;


            if (nome == "" || cpf == "" || tel == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");
                return;
            }
            Usuarios u = new Usuarios();
            u = u.verifica_nome(nome);
            if (u == null)
            {
                Usuarios usuarios = new Usuarios(nome, cpf, tel);


                usuarios.Insere_rapido(usuarios);
                // Todos os campos est�o preenchidos, ent�o abra a Form4
                Form3 tela = new Form3();
                tela.Show();


            }
            else
            {
                MessageBox.Show("Nome ja esta em uso");
                return;
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();
        }
    }

}