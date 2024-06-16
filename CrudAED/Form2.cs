using leitura;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAED
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "CSV files (*.csv)|*.csv";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Variaveis.caminhoPasta = ofd.FileName;
                    txtCaminho.Text = Variaveis.caminhoPasta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar arquivos:" + ex.Message);
            }
        }

        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
        //Ao clicar o botão a lista recebe os dados e envia para o banco de dados
        public void btnEnviarLista_Click(object sender, EventArgs e)
        {
            try
            {
                Variaveis.ListaPessoa.Importar(Variaveis.caminhoPasta);
                Variaveis.caminhoPasta = "";
                CadastroPessoa cadastrarLista = new CadastroPessoa();

                if (cadastrarLista.cadastrarLista(Variaveis.ListaPessoa))
                {
                    MessageBox.Show("Lista cadastrada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar lista: " + ex.Message);
            }
        }

        
        //Ao clicar nesse botão a lista e o banco de dados são organizado a partir do Trabalho
        private void button1_Click(object sender, EventArgs e)
        {
            // Deletar lista do banco de dados
            try
            {
                Variaveis.ListaPessoa.passo = Variaveis.ListaPessoa.primeiro;
                Variaveis.ListaPessoa.QuickSortJob();
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = $"select * from pessoas";


                if (query != null)
                {
                    string truncateQuery = "TRUNCATE TABLE pessoas";
                    MySqlCommand truncateCommand = new MySqlCommand(truncateQuery, MysqlConexaoBanco);
                    truncateCommand.ExecuteNonQuery();
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                }
            }
            catch (Exception ex) { }
            try
            {
                CadastroPessoa cadastrarLista = new CadastroPessoa();

                if (cadastrarLista.cadastrarLista(Variaveis.ListaPessoa))
                {
                    MessageBox.Show("Lista ordenada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao ordenar lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar lista: " + ex.Message);
            }

        }
        //ao clicar nesse botão a lista e o banco de dados são organizado a partir do nome e sobrenome
        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Deletar lista do banco de dados
            try
            {
                Variaveis.ListaPessoa.passo = Variaveis.ListaPessoa.primeiro;
                Variaveis.ListaPessoa.QuickSortName();
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = $"select * from pessoas";


                if (query != null)
                {
                    string truncateQuery = "TRUNCATE TABLE pessoas";
                    MySqlCommand truncateCommand = new MySqlCommand(truncateQuery, MysqlConexaoBanco);
                    truncateCommand.ExecuteNonQuery();
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                }
            }
            catch (Exception ex) { }
            try
            {
                CadastroPessoa cadastrarLista = new CadastroPessoa();

                if (cadastrarLista.cadastrarLista(Variaveis.ListaPessoa))
                {
                    MessageBox.Show("Lista ordenada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao ordenar lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ordenar lista: " + ex.Message);
            }

        }
        // ao clicar nesse botão a lista será apagada do banco de dados
        private void btnDeletarLista_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = $"select * from pessoas";
               

                if (query!=null)
                {
                    Variaveis.ListaPessoa.ApagaLista();
                    string truncateQuery = "TRUNCATE TABLE pessoas";
                    MySqlCommand truncateCommand = new MySqlCommand(truncateQuery, MysqlConexaoBanco);
                    truncateCommand.ExecuteNonQuery();
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();

                    if (cadastroPessoa.deletarLista(Variaveis.ListaPessoa))
                    {
                        MessageBox.Show("A lista foi excluída com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao apagar a lista!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao apagar lista: " + ex.Message);
            }
            

        }
    }
}

