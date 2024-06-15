using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAED
{
    static class ConexaoBanco
    {
        private const string servidor = "crudaed.cbg804k6ifpv.us-east-1.rds.amazonaws.com";
        private const string bancoDados = "aed";
        private const string usuario = "f28788b";
        private const string senha = "Trabalho123";

        //declarando uma variável para fazer a conexão do banco de dados
        static public string bancoServidor = $"server={servidor};user id={usuario};database={bancoDados};password={senha}";
    }
}
