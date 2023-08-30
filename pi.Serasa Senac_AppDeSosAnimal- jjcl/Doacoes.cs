
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    internal class Doacoes
    {
        public int id;
        public int valor;
        public bool nome;

        public Doacoes(int id, int valor, bool nome ) 
        {
            this.id = id;
            this.valor = valor;
            this.nome = nome;
        }
        public Doacoes()
        {

        }
        public List<Doacoes> busca_todos()
        {
            string query = "select * from doacoes;";

            DataTable tabela = Conexao.executaquery(query);

            List<Doacoes> doacao = new List<Doacoes>();
            foreach (DataRow linha in tabela.Rows)
            {
                Doacoes doacoes = carrega_dados(linha);
                doacao.Add(doacoes);
            }
            return doacao;
        }
        public Doacoes carrega_dados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            int valor = int.Parse(linha["valor"].ToString());
            bool nome = linha["nome"].ToString() == "1" ? true : false;

            Doacoes doacoes = new Doacoes(id, valor, nome);
            return doacoes;
        }
        public void Insere(Doacoes doacoes)
        {
            string query = $"insert into doacoes (id_doacao, valor, nome, ) values ('{doacoes.id}', '{doacoes.valor}', {doacoes.nome});";
            Conexao.executaquery(query);
        }
        public Doacoes Busca_ID(int id)
        {
            string query = $"select * from doacoes where id = {id};";

            DataTable tabela = Conexao.executaquery(query);
            Doacoes doacoes = carrega_dados(tabela.Rows[0]);

            return doacoes;
        }
    }
}
