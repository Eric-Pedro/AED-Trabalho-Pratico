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

        public void btnEnviarLista_Click(object sender, EventArgs e)
        {
            try
            {
                Variaveis.ListaPessoa.Importar(Variaveis.caminhoPasta);
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

        

        private void btnOrdenar_Click(object sender, EventArgs e, ListaDupla x)
        {
            try
            {
                Variaveis.ListaPessoa.QuickSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar lista: " + ex.Message);
            }

        }

        private void btnDeletarLista_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = $"select * from pessoas";

                if (query!=null)
                {
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

