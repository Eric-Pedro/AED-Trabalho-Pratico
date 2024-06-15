using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TP02
{
    class Pessoa
    {
        public int index;
        public string userId;
        public string firstName;
        public string LastName;
        public string dateOfBirth;
        public string phone;
        public string jobTitle;
        public string sex;
        public string email;

        public Pessoa(int index, string userId, string firstName, string LastName, string sex, string email, string phone, string dateOfBirth, string jobTitle)
        {
            this.index = index;
            this.userId = userId;
            this.firstName = firstName;
            this.LastName = LastName;
            this.sex = sex;
            this.email = email;
            this.phone = phone;
            this.dateOfBirth = dateOfBirth;
            this.jobTitle = jobTitle;
        }

        public Pessoa()
        {
            this.index = 0;
            this.userId = "";
            this.firstName = "";
            this.LastName = "";
            this.sex = "";
            this.email = "";
            this.phone = "";
            this.dateOfBirth = "";
            this.jobTitle = "";
        }
    }

    class Program
    {
        /*public static void Main(string[] args)
        {
            Dictionary<int, Pessoa> tabelaHash = new Dictionary<int, Pessoa>();

            Console.Clear();
            Stream entrada = File.Open("people-100.csv", FileMode.Open);
            StreamReader leitor = new StreamReader(entrada);
            leitor.ReadLine(); // Pula a primeira linha do cabeçalho

            while (!leitor.EndOfStream)
            {
                string[] linha = leitor.ReadLine().Split(','); // Divide a string em um vetor de strings onde cada índice é determinado pelo separador ","
                Pessoa p = new Pessoa(
                    int.Parse(linha[0]),
                    linha[1],
                    linha[2],
                    linha[3],
                    linha[4],
                    linha[5],
                    linha[6],
                    linha[7],
                    linha[8]
                );
                tabelaHash.Add(p.index, p);
            }

            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Adicionar nova pessoa");
                Console.WriteLine("2 - Pesquisar pessoa");
                Console.WriteLine("3 - Listar todas as pessoas");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        AdicionarPessoa(tabelaHash);
                        break;
                    case 2:
                        PesquisarPessoa(tabelaHash);
                        break;
                    case 3:
                        ListarPessoas(tabelaHash);
                        break;
                    case 4:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
                Console.WriteLine();
            }
        }*/

        public static void AdicionarPessoa(Dictionary<int, Pessoa> tabelaHash)
        {
            Console.WriteLine("Adicionar nova pessoa:");

            Console.Write("Índice: ");
            int index = int.Parse(Console.ReadLine());

            if (tabelaHash.ContainsKey(index))
            {
                Console.WriteLine("Erro: Já existe uma pessoa com este índice.");
                return;
            }

            Console.Write("UserID: ");
            string userId = Console.ReadLine();

            Console.Write("Primeiro Nome: ");
            string firstName = Console.ReadLine();

            Console.Write("Último Nome: ");
            string LastName = Console.ReadLine();

            Console.Write("Sexo: ");
            string sex = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Telefone: ");
            string phone = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            string dateOfBirth = Console.ReadLine();

            Console.Write("Cargo: ");
            string jobTitle = Console.ReadLine();

            Pessoa novaPessoa = new Pessoa(index, userId, firstName, LastName, sex, email, phone, dateOfBirth, jobTitle);
            tabelaHash.Add(index, novaPessoa);

            Console.WriteLine("Pessoa adicionada com sucesso!");
        }

       public static void PesquisarPessoa(Dictionary<int, Pessoa> tabelaHash, int opcao)
        {

            switch (opcao)
            {
                case 1:
                    Console.Write("Índice: ");
                    int index = int.Parse(Console.ReadLine());
                    if (tabelaHash.TryGetValue(index, out Pessoa pessoaIndex))
                    {
                        MostrarInformacoesPessoa(pessoaIndex);
                    }
                    else
                    {
                        Console.WriteLine("Pessoa não encontrada.");
                    }
                    break;
                case 2:
                    Console.Write("UserID: ");
                    string userId = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.userId == userId);
                    break;
                case 3:
                    Console.Write("Primeiro Nome: ");
                    string firstName = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.firstName == firstName);
                    break;
                case 4:
                    Console.Write("Último Nome: ");
                    string LastName = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.LastName == LastName);
                    break;
                case 5:
                    Console.Write("Sexo: ");
                    string sex = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.sex == sex);
                    break;
                case 6:
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.email == email);
                    break;
                case 7:
                    Console.Write("Telefone: ");
                    string phone = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.phone == phone);
                    break;
                case 8:
                    Console.Write("Data de Nascimento: ");
                    string dateOfBirth = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.dateOfBirth == dateOfBirth);
                    break;
                case 9:
                    Console.Write("Cargo: ");
                    string jobTitle = Console.ReadLine();
                    PesquisarPorCampo(tabelaHash, p => p.jobTitle == jobTitle);
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }

        static void PesquisarPorCampo(Dictionary<int, Pessoa> tabelaHash, Func<Pessoa, bool> criterio)
        {
            var pessoasEncontradas = tabelaHash.Values.Where(criterio).ToList();

            if (pessoasEncontradas.Count > 0)
            {
                foreach (var pessoa in pessoasEncontradas)
                {
                    MostrarInformacoesPessoa(pessoa);
                }
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa encontrada.");
            }
        }

        static void ListarPessoas(Dictionary<int, Pessoa> tabelaHash)
        {
            if (tabelaHash.Count == 0)
            {
                Console.WriteLine("A tabela está vazia.");
                return;
            }

            foreach (var pessoa in tabelaHash.Values)
            {
                MostrarInformacoesPessoa(pessoa);
            }
        }

        static void MostrarInformacoesPessoa(Pessoa pessoa)
        {
            Console.WriteLine($"[## {pessoa.index} ## {pessoa.userId} ## {pessoa.firstName} ## {pessoa.LastName} ## {pessoa.sex} ## {pessoa.phone} ## {pessoa.dateOfBirth} ## {pessoa.jobTitle} ##]");
        }
    }
}
