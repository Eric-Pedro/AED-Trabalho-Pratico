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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void lblSobrenome2_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltarCrudExcluir_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUserID3.Text.Equals("") && !txtNome3.Text.Equals("") && !txtSobrenome3.Text.Equals("") && !txtSexo3.Text.Equals("") && !txtData3.Text.Equals("") && !txtTelefone3.Text.Equals("") && !txtCargo3.Text.Equals(""))
                {
                    CadastroPessoa cadastroPessoas = new CadastroPessoa();
                    cadastroPessoas.Id = int.Parse(lblID3.Text);
                    cadastroPessoas.Telefone = txtTelefone3.Text;
                    cadastroPessoas.Cargo = txtCargo3.Text;

                    if (cadastroPessoas.atualizarPessoa())
                    {
                        MessageBox.Show("Os dados da pessoa foram atualizados com sucesso!");
                        txtUserID3.Clear();
                        txtNome3.Clear();
                        txtSobrenome3.Clear();
                        txtData3.Clear();
                        txtSexo3.Clear();
                        txtTelefone3.Clear();
                        txtCargo3.Clear();
                        txtUserID3.Focus();
                        lblID3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar as informações da pessoa!");
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar a pessoa que deseja atualizar!");
                    txtUserID3.Clear();
                    txtNome3.Clear();
                    txtSobrenome3.Clear();
                    txtData3.Clear();
                    txtSexo3.Clear();
                    txtTelefone3.Clear();
                    txtCargo3.Clear();
                    txtUserID3.Focus();
                    lblID3.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados da pessoa " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUserID3.Text.Equals("") && !txtNome3.Text.Equals("") && !txtSobrenome3.Text.Equals("") && !txtSexo3.Text.Equals("") && !txtData3.Text.Equals("") && !txtTelefone3.Text.Equals("") && !txtCargo3.Text.Equals(""))
                {
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                    cadastroPessoa.Id = int.Parse(lblID3.Text);

                    if (cadastroPessoa.deletarPessoa())
                    {
                        MessageBox.Show("A pessoa foi excluída com sucesso!");
                        txtUserID3.Clear();
                        txtNome3.Clear();
                        txtSobrenome3.Clear();
                        txtData3.Clear();
                        txtSexo3.Clear();
                        txtTelefone3.Clear();
                        txtCargo3.Clear();
                        txtUserID3.Focus();
                        lblID3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir a pessoa!");
                        txtUserID3.Clear();
                        txtNome3.Clear();
                        txtSobrenome3.Clear();
                        txtData3.Clear();
                        txtSexo3.Clear();
                        txtTelefone3.Clear();
                        txtCargo3.Clear();
                        txtUserID3.Focus();
                        lblID3.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor pesquisar a pessoa que deseja excluir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir pessoa: " + ex.Message);
            }
        }

        private void btnLimparCrudAtualizar_Click(object sender, EventArgs e)
        {
            txtUserID3.Text = "";
            txtNome3.Text = "";
            txtSobrenome3.Text = "";
            txtData3.Text = "";
            txtSexo3.Text = "";
            txtTelefone3.Text = "";
            txtCargo3.Text = "";
            txtUserID3.Focus();
            lblID3.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUserID3.Text.Equals(""))
                {
                    CadastroPessoa cadastroPessoa = new CadastroPessoa();
                    cadastroPessoa.UserID = txtUserID3.Text;

                    MySqlDataReader reader = cadastroPessoa.localizarPessoa();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblID3.Text = reader["id"].ToString();
                            txtUserID3.Text = reader["codigoUsuario"].ToString();
                            txtUserID3.Visible = true;
                            txtNome3.Text = reader["nome"].ToString();
                            lblNome3.Visible = true;
                            txtNome3.Visible = true;
                            txtSobrenome3.Text = reader["sobrenome"].ToString();
                            lblSobrenome3.Visible = true;
                            txtSobrenome3.Visible = true;
                            txtSexo3.Text = reader["sexo"].ToString();
                            lblSexo3.Visible = true;
                            txtSexo3.Visible = true;
                            txtData3.Text = reader["dataNascimento"].ToString();
                            lblData3.Visible = true;
                            txtData3.Visible = true;
                            txtTelefone3.Text = reader["telefone"].ToString();
                            lblTelefone3.Visible = true;
                            txtTelefone3.Visible = true;
                            txtCargo3.Text = reader["cargo"].ToString();
                            lblCargo3.Visible = true;
                            txtCargo3.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Pessoa não encontrada.");
                            txtUserID3.Clear();
                            txtNome3.Clear();
                            txtSobrenome3.Clear();
                            txtData3.Clear();
                            txtSexo3.Clear();
                            txtTelefone3.Clear();
                            txtCargo3.Clear();
                            txtUserID3.Focus();
                            lblID3.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Pessoa não encontrada.");
                        txtUserID3.Clear();
                        txtNome3.Clear();
                        txtSobrenome3.Clear();
                        txtData3.Clear();
                        txtSexo3.Clear();
                        txtTelefone3.Clear();
                        txtCargo3.Clear();
                        txtUserID3.Focus();
                        lblID3.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar pessoa: " + ex.Message);
            }
        }
    }
}
