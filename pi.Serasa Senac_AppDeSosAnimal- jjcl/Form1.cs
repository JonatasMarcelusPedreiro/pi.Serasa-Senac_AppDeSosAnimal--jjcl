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
            string senha = txttelefone.Texts;




            if (nome == "" || cpf == "" || senha == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");


            }
            else
            {


                Usuarios usuarios = new Usuarios(nome, cpf, senha);


                usuarios.Insere_rapido(usuarios);
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
            string senha = txttelefone.Texts;


            if (nome == "" || cpf == "" || senha == "")
            {

                MessageBox.Show("Preencha todos os campos acima.");
                return;
            }
            // Verifica se o nome já está em uso
            Usuarios u = new Usuarios();
            u = u.verifica_nome(nome);
            if (u != null)
            {
                MessageBox.Show("Nome já está em uso.");
                return;
            }

            // Verifica se o CPF tem 11 dígitos
            if (cpf.Length != 11)
            {
                MessageBox.Show("CPF inválido.");
                return;
            }

            // Verifica se o CPF já está em uso
            Usuarios o = new Usuarios();
            o = o.verifica_cpf(cpf);
            if (o != null)
            {
                MessageBox.Show("CPF já está em uso.");
                return;
            }

            // Se nenhum dos casos acima for verdadeiro, você pode inserir o novo registro
            Usuarios usuarios = new Usuarios(nome, cpf, senha);
            usuarios.Insere_rapido(usuarios);
            Form3 tela = new Form3();
            tela.Show();

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form3 tela = new Form3();
            tela.Show();

        }
    }

}