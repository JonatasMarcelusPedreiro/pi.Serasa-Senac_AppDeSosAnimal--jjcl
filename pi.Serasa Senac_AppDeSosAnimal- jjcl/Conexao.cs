﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_conexaoBD
{
    internal class Conexao
    {
        const string host = "localhost";
        const string banco = "trabalho_final";
        const string usuario = "root";
        const string senha = "";
        const string dados_conexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dados_conexao);


       
        
     

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

