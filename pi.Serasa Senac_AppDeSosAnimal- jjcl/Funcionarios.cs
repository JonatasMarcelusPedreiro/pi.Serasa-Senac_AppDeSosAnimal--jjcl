
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    internal class Funcionarios
    {
        public int id;
        public string nome;
        public string senha;
        public string telefone;

        public Funcionarios (string nome,  string senha, string telefone)
        {
            this.id = id;
            this.nome = nome;
            
            this.senha = senha;
            this.telefone = telefone;
        }
        public Funcionarios()
        {

        }
        public List<Funcionarios> busca_todos()
        {
            string query = "select * from funcionarios;";

            DataTable tabela = Conexao.executaquery(query);

            List<Funcionarios> funcionario = new List<Funcionarios>();
            foreach (DataRow linha in tabela.Rows)
            {
                Funcionarios funcionarios = carrega_dados(linha);
                funcionario.Add(funcionarios);
            }
            return funcionario;
        }

        public Funcionarios carrega_dados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = linha["nome"].ToString();
            string senha = linha["senha"].ToString();
            string telefone = linha["telefone"].ToString();

            Funcionarios funcionarios = new Funcionarios( nome, senha, telefone);
            return funcionarios;
        }

        public void Insere(Funcionarios funcionarios)
        {
            string query = $"insert into funcionarios (nome, senha, telefone) values ('{funcionarios.nome}', '{funcionarios.senha}', '{funcionarios.telefone}' );";
            Conexao.executaquery(query);
        }

        public Funcionarios Busca_ID(int id)
        {
            string query = $"select * from funcionarios where id = {id};";

            DataTable tabela = Conexao.executaquery(query);
            Funcionarios funcionarios = carrega_dados(tabela.Rows[0]);

            return funcionarios;
        }
    }
}
