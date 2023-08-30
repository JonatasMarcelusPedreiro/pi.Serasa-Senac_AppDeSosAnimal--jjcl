using _08_conexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    internal class Usuarios
    {
        public int id;
        public string nome;
        public int cpf;
        public string email;
        public string senha;
        public string telefone;

        public Usuarios(int id, string nome, int cpf, string email, string senha, string telefone)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
        }
        public Usuarios()
        {

        }

        public List<Usuarios> busca_todos()
        {
            string query = "select * from usuarios;";

            DataTable tabela = Conexao.executaquery(query);

            List<Usuarios> usuario = new List<Usuarios>();
            foreach (DataRow linha in tabela.Rows)
            {
                Usuarios usuarios = carrega_dados(linha);
                usuario.Add(usuarios);
            }
            return usuario;
        }

        public Usuarios carrega_dados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = linha["nome"].ToString();
            int cpf = int.Parse(linha["cpf"].ToString());
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            string telefone = linha["telefone"].ToString();

            Usuarios usuarios = new Usuarios(id, nome, cpf, email, senha, telefone);
            return usuarios;
        }

        public void Insere(Usuarios usuarios)
        {
            string query = $"insert into usuarios (nome, cpf, email, senha, telefone) values ('{usuarios.nome}', {usuarios.cpf}', {usuarios.email}', {usuarios.senha}', {usuarios.telefone} );";
            Conexao.executaquery(query);
        }

        public Usuarios Busca_ID(int id)
        {
            string query = $"select * from usuarios where id = {id};";

            DataTable tabela = Conexao.executaquery(query);
            Usuarios usuarios = carrega_dados(tabela.Rows[0]);

            return usuarios;
        }
    }
}
