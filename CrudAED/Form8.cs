using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void btnOkCargo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCargo2.Text))
                {
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                    cadastroPessoa.Cargo = txtCargo2.Text;

                    using (MySqlDataReader reader = cadastroPessoa.localizarCargo())
                    {
                        if (reader != null && reader.HasRows)
                        {
                            string query = cadastroPessoa.preencherGrid();

                            using (MySqlConnection connection = new MySqlConnection(ConexaoBanco.bancoServidor))
                            {
                                connection.Open();
                                using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection))
                                {
                                    DataTable dt = new DataTable();
                                    dataAdapter.Fill(dt);
                                    if (dt.Rows.Count > 0)
                                    {
                                        dataGridView2.Visible = true;
                                        dataGridView2.DataSource = dt;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Nenhum dado encontrado para exibir.");
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com o cargo especificado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um cargo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir dados: " + ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVoltarPesquisaCargo_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
