
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
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
        public string imagem;

       /* public Animais(int id, string animal, string situacao, string sexo)
        {
            this.id = id;
            this.animal = animal;
            this.situacao = situacao;
            this.sexo = sexo;
            
        }*/

        public Animais(int id, string animal, string situacao, string sexo, string imagem)
        {
            this.id = id;
            this.animal = animal;
            this.situacao = situacao;
            this.sexo = sexo;
            this.imagem = imagem;

        }
        public Animais()
        {

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
            string imagem = linha["imagem"].ToString();
            

            Animais animais = new Animais(id, animal, situacao, sexo, imagem);
            return animais;
        }

        public void Insere(Animais animais)
        {
            string query = $"insert into animais (animal, situacao, sexo, imagem) values ('{animais.animal}', '{animais.situacao}', '{animais.sexo}', '{animais.imagem}' );";
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
