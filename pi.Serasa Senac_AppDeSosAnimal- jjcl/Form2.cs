﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi.Serasa_Senac_AppDeSosAnimal__jjcl
{
    public partial class Form2 : Form
    {
        public void atualizainterface()
        {
            Funcionarios funcionarios = new Funcionarios();

            List<Funcionarios> list_funcionarios = funcionarios.busca_todos();
            foreach (Funcionarios a in list_funcionarios)
            {
                listfuncionarioscadastrados.Items.Add($"{a.id} - {a.nome} - {a.telefone} ");
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void listfuncionarioscadastrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           atualizainterface();
        }

        private void btncadastrarfuncionarios_Click(object sender, EventArgs e)
        {
            string nome = txtnomeFuncionario.Text;
            string senha = txtsenhacdfuncionario.Text;
            string tel = txttelcdfuncionario.Text;

            if (nome == "" || senha == "" || tel == "")
            {
                MessageBox.Show("Preencha todos os campos!!");
            }
            else
            {
                Funcionarios funcionarios = new Funcionarios(nome, senha, tel);

                funcionarios.Insere(funcionarios);
                txtnomeFuncionario.Clear();
                txtsenhacdfuncionario.Clear();
                txttelcdfuncionario.Clear();
            }
        }

        private void btncadastrarfuncionarios_Click_1(object sender, EventArgs e)
        {

        }
    }
}
