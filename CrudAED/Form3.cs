using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAED
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUserID.Text.Equals("") && !txtNome.Text.Equals("") && !txtSobrenome.Text.Equals("") && !txtData.Text.Equals("") && !txtSexo.Text.Equals("") && !txtTelefone.Text.Equals("") && !txtCargo.Text.Equals(""))
                {
                    CadastroPessoa cadastroPessoas = new CadastroPessoa();
                    cadastroPessoas.UserID = txtUserID.Text;
                    cadastroPessoas.Nome = txtNome.Text;
                    cadastroPessoas.Sobrenome = txtSobrenome.Text;
                    cadastroPessoas.DataNascimento = txtData.Text;
                    cadastroPessoas.Sexo = txtSexo.Text;
                    cadastroPessoas.Telefone = txtTelefone.Text;
                    cadastroPessoas.Cargo = txtCargo.Text;

                    if (cadastroPessoas.cadastrarPessoa())
                    {
                        MessageBox.Show($"A pessoa {cadastroPessoas.Nome} foi cadastrado com sucesso!");
                        txtUserID.Clear();
                        txtNome.Clear();
                        txtSobrenome.Clear();
                        txtData.Clear();
                        txtSexo.Clear();
                        txtTelefone.Clear();
                        txtCargo.Clear();
                        txtUserID.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar pessoa");
                    }
                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    txtUserID.Clear();
                    txtNome.Clear();
                    txtSobrenome.Clear();
                    txtData.Clear();
                    txtSexo.Clear();
                    txtTelefone.Clear();
                    txtCargo.Clear();
                    txtUserID.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar pessoa" + ex.Message);
            }
        }
    }
}
