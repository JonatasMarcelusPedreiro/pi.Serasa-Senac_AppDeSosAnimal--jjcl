using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    internal class Conexao
    {
        
        const string host = "srv793.hstgr.io"; //192.168.0.16
        const string banco = "u647084545_serasa_ljjc";
        const string usuario = "u647084545_serasa_ljjc";
        const string senha = "Serasa2023";
        const string dados_conexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dados_conexao);


       public static void salva_imagem()
        {
            conexao.Open();
            
        }
        
     

        public static DataTable executaquery(string query) 
        {
            try
            {
                conexao.Open();
                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader dados = comando.ExecuteReader();
                
                DataTable tabela = new DataTable();
                tabela.Load(dados);
                return tabela;
                
            }
            catch (Exception erro)
            {
                MessageBox.Show("erro ao realizar consulta");
                MessageBox.Show(erro.Message);
                return null;
            }
            finally 
            {
                conexao.Close();
            }
            
        }
    }
}

