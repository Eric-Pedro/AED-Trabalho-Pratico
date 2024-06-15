using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CrudAED
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUserID2.Text.Equals(""))
                {
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                    cadastroPessoa.UserID = txtUserID2.Text;

                    MySqlDataReader reader = cadastroPessoa.localizarPessoa();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblID2.Text = reader["id"].ToString();
                            txtUserID2.Text = reader["codigoUsuario"].ToString();
                            txtUserID2.Visible = true;
                            txtNome2.Text = reader["nome"].ToString();
                            lblNome2.Visible = true;
                            txtNome2.Visible=true;
                            txtSobrenome2.Text = reader["sobrenome"].ToString();
                            lblSobrenome2.Visible = true;
                            txtSobrenome2.Visible= true;
                            txtSexo2.Text = reader["sexo"].ToString();
                            lblSexo2.Visible = true;
                            txtSexo2.Visible=true;
                            txtData2.Text = reader["dataNascimento"].ToString();
                            lblData2.Visible = true;
                            txtData2.Visible = true;
                            txtTelefone2.Text = reader["telefone"].ToString();
                            lblTelefone2.Visible = true;
                            txtTelefone2.Visible=true;
                            txtCargo2.Text = reader["cargo"].ToString();
                            lblCargo2.Visible = true;
                            txtCargo2.Visible=true;
                        }
                        else
                        {
                            MessageBox.Show("Pessoa não encontrada.");
                            txtUserID2.Clear();
                            txtNome2.Clear();
                            txtSobrenome2.Clear();
                            txtData2.Clear();
                            txtSexo2.Clear();
                            txtTelefone2.Clear();
                            txtCargo2.Clear();
                            txtUserID2.Focus();
                            lblID2.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pessoa não encontrada.");
                        txtUserID2.Clear();
                        txtNome2.Clear();
                        txtSobrenome2.Clear();
                        txtData2.Clear();
                        txtSexo2.Clear();
                        txtTelefone2.Clear();
                        txtCargo2.Clear();
                        txtUserID2.Focus();
                        lblID2.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar pessoa: " + ex.Message);
            }
        }

        private void btnVoltarCrudAtualizar_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnLimparCrudPesquisar_Click(object sender, EventArgs e)
        {
            txtUserID2.Text = "";
            txtNome2.Text = "";
            txtSobrenome2.Text = "";
            txtData2.Text = "";
            txtSexo2.Text = "";
            txtTelefone2.Text = "";
            txtCargo2.Text = "";
        }
    }
}
