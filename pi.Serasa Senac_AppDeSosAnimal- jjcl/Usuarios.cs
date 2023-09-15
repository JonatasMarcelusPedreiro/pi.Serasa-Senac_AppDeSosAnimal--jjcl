
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
        public string cpf;
        public string email;
        public string senha;
        public string telefone;

        //cadastro completo
        public Usuarios(string nome, string email, string senha,string cpf, string telefone)
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
        
        public Usuarios (string nome, string cpf, string senha)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.senha = senha;
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
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            string cpf = (linha["cpf"].ToString());
            string telefone = linha["telefone"].ToString();

            Usuarios usuarios = new Usuarios( nome, email, senha,cpf, telefone);
            return usuarios;
        }

        public void Insere_completo(Usuarios usuarios)
        {
            string query = $"insert into usuarios (nome, email, senha, cpf, telefone) values ('{usuarios.nome}', '{usuarios.email}', '{usuarios.senha}', '{usuarios.cpf}', '{usuarios.telefone}' );";
            Conexao.executaquery(query);
        }
        public void Insere_rapido(Usuarios usuarios)
        {
            string query = $"insert into usuarios (nome, cpf, senha) values ('{usuarios.nome}', {usuarios.cpf}, '{usuarios.senha}' );";
            Conexao.executaquery(query);
        }
        public Usuarios verifica_nome(string nome)
        {
            string query = $"select * from usuarios where nome = '{nome}';";
            DataTable tabela = Conexao.executaquery(query);
            if (tabela.Rows.Count == 0)
                return null;
            Usuarios usuarios = carrega_dados(tabela.Rows[0]);

            return usuarios;
        }
        
        public Usuarios verifica_cpf(string cpf)
        {
            string query = $"select * from usuarios where cpf = '{cpf}';";
            DataTable tabela = Conexao.executaquery(query);
            if (tabela.Rows.Count == 0)
                return null;
            Usuarios usuarios = carrega_dados(tabela.Rows[0]);

            return usuarios;
        }
        public Usuarios Busca_ID(int id)
        {
            string query = $"select * from usuarios where id = {id};";

            DataTable tabela = Conexao.executaquery(query);
            Usuarios usuarios = carrega_dados(tabela.Rows[0]);

            return usuarios;

        }
        public Usuarios Login(string nome, string senha)
        {
            string query = $"select * from usuarios where nome = '{nome}' and senha = '{senha}';";
            
            DataTable tabela = Conexao.executaquery(query);
            if (tabela.Rows.Count == 0)
                return null;
            Usuarios usuarios = carrega_dados(tabela.Rows[0]);

            return usuarios;
        }

    }
}
