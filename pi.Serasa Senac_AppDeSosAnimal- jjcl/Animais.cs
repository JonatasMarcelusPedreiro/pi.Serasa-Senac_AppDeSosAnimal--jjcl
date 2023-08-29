using _08_conexaoBD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    internal class Animais
    {
        public int id;
        public string animal;
        public string situacao;
        public string sexo;
        public bool domestico;

        public Animais(int id, string animal, string situacao, string sexo, bool domestico)
        {
            this.id = id;
            this.animal = animal;
            this.situacao = situacao;
            this.sexo = sexo;
            this.domestico = domestico;
        }

        public List<Animais> busca_todos()
        {
            string query = "select * from animais;";

            DataTable tabela = Conexao.executaquery(query);

            List<Animais> animal = new List<Animais>();
            foreach (DataRow linha in tabela.Rows)
            {
                Animais animais = carrega_dados(linha);
                animal.Add(animais);
            }
            return animal;
        }

        public Animais carrega_dados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string animal = linha["animal"].ToString();
            string situacao = linha["situacao"].ToString();
            string sexo = linha["sexo"].ToString();
            bool domestico = linha["domestico"].ToString() == "1" ? true : false;

            Animais animais = new Animais(id, animal, situacao, sexo, domestico);
            return animais;
        }

        public void Insere(Animais animais)
        {
            string query = $"insert into animais (animal, situacao, sexo, domestico) values ('{animais.animal}', {animais.situacao}', {animais.sexo}', {animais.domestico} );";
            Conexao.executaquery(query);
        }

        public Animais Busca_ID(int id)
        {
            string query = $"select * from animais where id = {id};";

            DataTable tabela = Conexao.executaquery(query);
            Animais animais = carrega_dados(tabela.Rows[0]);

            return animais;
        }
    }
}
