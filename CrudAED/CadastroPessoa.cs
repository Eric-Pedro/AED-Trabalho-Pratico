using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using leitura;
using Org.BouncyCastle.Math;
using System.Transactions;
using Org.BouncyCastle.Bcpg;
using System.Data;

namespace CrudAED
{
    internal class CadastroPessoa
    {
        private int id;
        private string userID;
        private string nome;
        private string sobrenome;
        private string sexo;
        private string dataNascimento;
        private string telefone;
        private string cargo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
       
        //Método para cadastrar pessoas ao banco de Dados
        public bool cadastrarPessoa()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"insert into pessoas (codigoUsuario,nome,sobrenome,sexo,dataNascimento,telefone,cargo) values ('{UserID}','{Nome}','{Sobrenome}','{Sexo}','{DataNascimento}','{Telefone}','{Cargo}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método cadastrarPessoa:" + ex.Message);
                return false;
            }
        }
        //Método para cadastrar a Lista no banco de dados
        public bool cadastrarLista(ListaDupla x)
        {
            MySqlConnection MysqlConexaoBanco = null;
            MySqlTransaction transaction = null;

            try
            {
                MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                transaction = MysqlConexaoBanco.BeginTransaction();

                string insert = "INSERT INTO pessoas (codigoUsuario, nome, sobrenome, sexo, dataNascimento, telefone, cargo) " +
                                "VALUES (@codigoUsuario, @nome, @sobrenome, @sexo, @dataNascimento, @telefone, @cargo)";

                using (MySqlCommand comandoSql = new MySqlCommand(insert, MysqlConexaoBanco, transaction))
                {
                    comandoSql.Parameters.Add("@codigoUsuario", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@nome", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@sobrenome", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@sexo", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@dataNascimento", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@telefone", MySqlDbType.VarChar);
                    comandoSql.Parameters.Add("@cargo", MySqlDbType.VarChar);

                    for (CelulaDupla i = x.primeiro.prox; i != null; i = i.prox)
                    {
                        comandoSql.Parameters["@codigoUsuario"].Value = i.elemento.userId;
                        comandoSql.Parameters["@nome"].Value = i.elemento.firstName;
                        comandoSql.Parameters["@sobrenome"].Value = i.elemento.lastName;
                        comandoSql.Parameters["@sexo"].Value = i.elemento.sex;
                        comandoSql.Parameters["@dataNascimento"].Value = i.elemento.dateOfBirth;
                        comandoSql.Parameters["@telefone"].Value = i.elemento.phone;
                        comandoSql.Parameters["@cargo"].Value = i.elemento.jobTitle;

                        comandoSql.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show("Erro no banco de dados - Método cadastrarPessoa: " + ex.Message);
                return false;
            }
            finally
            {
                if (MysqlConexaoBanco != null)
                {
                    MysqlConexaoBanco.Close();
                }
            }
        }

        public MySqlDataReader localizarPessoa()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id,codigoUsuario,nome,sobrenome,sexo,dataNascimento,telefone,cargo from pessoas where codigoUsuario = '{UserID}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText= select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método localizar pessoas: " + ex.Message);
                return null;
            }
        }
        public MySqlDataReader localizarCargo()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select * from pessoas where cargo = '{Cargo}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método localizar pessoas: " + ex.Message);
                return null;
            }
        }
        public bool atualizarPessoa()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update pessoas set telefone = '{Telefone}', cargo = '{Cargo}' where id = '{id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Banco de dados - Método atualizarPessoa: " + ex.Message);
                return false;
            }
        }
        public bool deletarPessoa()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"delete from pessoas where id='{id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery ();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método deletarPessoa: " + ex.Message);
                return false;
            }
        }
        //método utilizado para deletar lista do banco de dados
        public bool deletarLista(ListaDupla x)
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();
                string update = $"delete from pessoas;";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;
                comandoSql.ExecuteNonQuery();
                

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método deletarLista: " + ex.Message);
                return false;
            }
        }

        public string preencherGrid()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string query = $"select * from pessoas where cargo='{Cargo}'";
                return query;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exibir informações do banco de dados!" + ex.Message);
                return "";
            }

        }
    }
}
