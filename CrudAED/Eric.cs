using System;
using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;

namespace leitura
{
    public class Pessoa // classe pessoa
    {
        public int index;
        public string userId, firstName, lastName, sex, email, phone, dateOfBirth, jobTitle;
        //construtor vazio passa todos os parâmetros como -1
        public Pessoa() : this(-1, "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1") { }
        public Pessoa(int ind, string id, string firstn, string lastn, string sexo, string mail, string telefone, string niver, string job)
        {
            index = ind;
            userId = id;
            firstName = firstn;
            lastName = lastn;
            sex = sexo;
            email = mail;
            phone = telefone;
            dateOfBirth = niver;
            jobTitle = job;
        }
        public override string ToString() // método que escreve todas variáveis em uma única string
        {
            return ($"[## {index} ## {userId} ## {firstName} ## {lastName} ## {sex} ## {email} ## {phone} ##{dateOfBirth} ## {jobTitle} ##]");
        }
    }
    public class CelulaDupla 
    {
        public Pessoa elemento;
        public CelulaDupla prox, ant;
        public CelulaDupla() : this(null) { }
        public CelulaDupla(Pessoa x)
        {
            this.elemento = x;
            this.prox = this.ant = null;
        }
    }
    public class ListaDupla
    {
        public CelulaDupla primeiro, ultimo,passo; // passo utilizado para não cadastrar a lista mais de uma vez no banco de dados
        public ListaDupla()
        {
            primeiro = new CelulaDupla();
            passo= ultimo = primeiro;
        }
        public void InserirInicio(Pessoa x)
        {
            CelulaDupla tmp = new CelulaDupla(x);
            tmp.ant = primeiro;
            tmp.prox = primeiro.prox;
            primeiro.prox = tmp;
            if (primeiro == ultimo)
            {
                ultimo = tmp;
            }
            else
            {
                tmp.prox.ant = tmp;
            }
            tmp = null;
        }
        public void InserirFim(Pessoa x)
        {
            ultimo.prox = new CelulaDupla(x);
            ultimo.prox.ant = ultimo;
            ultimo = ultimo.prox;
        }
        public Pessoa RemoverInicio()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            CelulaDupla tmp = primeiro;
            primeiro = primeiro.prox;
            Pessoa elemento = primeiro.elemento;
            tmp.prox = primeiro.ant = null;
            tmp = null;
            return elemento;
        }
        public Pessoa RemoverFim()
        {
            if (primeiro == ultimo)
                throw new Exception("Erro!");
            Pessoa elemento = ultimo.elemento;
            ultimo = ultimo.ant;
            ultimo.prox.ant = null;
            ultimo.prox = null;
            return elemento;
        }
        public int Tamanho()
        {
            int tamanho = 0;
            for (CelulaDupla i = primeiro.prox; i != null; i = i.prox)
                tamanho++;
            return tamanho;
        }
        public void Inserir(Pessoa x, int pos)
        {
            int tamanho = Tamanho();
            if (pos < 0 || pos > tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                InserirInicio(x);
            }
            else if (pos == tamanho)
            {
                InserirFim(x);
            }
            else
            {
                CelulaDupla i = primeiro;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                CelulaDupla tmp = new CelulaDupla(x);
                tmp.ant = i;
                tmp.prox = i.prox;
                tmp.ant.prox = tmp.prox.ant = tmp;
                tmp = i = null;
            }
        }
        public Pessoa Remover(int pos)
        {
            Pessoa elemento;
            int tamanho = Tamanho();
            if (primeiro == ultimo)
            {
                throw new Exception("Erro!");
            }
            else if (pos < 0 || pos >= tamanho)
            {
                throw new Exception("Erro!");
            }
            else if (pos == 0)
            {
                elemento = RemoverInicio();
            }
            else if (pos == tamanho - 1)
            {
                elemento = RemoverFim();
            }
            else
            {
                CelulaDupla i = primeiro.prox;
                for (int j = 0; j < pos; j++, i = i.prox) ;
                i.ant.prox = i.prox;
                i.prox.ant = i.ant;
                elemento = i.elemento;
                i.prox = i.ant = null;
                i = null;
            }
            return elemento;
        }
        public void Mostrar()
        {
            for (CelulaDupla i = primeiro.prox; i != null; i = i.prox)
            {
                Console.WriteLine(i.elemento.ToString());
            }
        }
        public void MostrarNome()
        {
            for (CelulaDupla i = primeiro.prox; i != null; i = i.prox)
            {
                Console.WriteLine(i.elemento.firstName + " " + i.elemento.lastName);
            }
        }
        public void Importar(string caminho) //método utilizado para importar os dados de um arquivo
        {
            using (Stream entra = File.Open(caminho, FileMode.Open))
            using (StreamReader leitor = new StreamReader(entra))
            {
                // linha recebe string da primeira linha
                string linha = leitor.ReadLine();
                // string recebe segunda linha, pois a primeira linha não contém valores
                linha = leitor.ReadLine();
                // Separando e armazenando os atributos
                while (linha != null)
                {
                    string[] itens = linha.Split(',');
                    Pessoa tmp = new Pessoa(int.Parse(itens[0]), itens[1], itens[2], itens[3], itens[4], itens[5], itens[6], itens[7], itens[8]);
                    linha = leitor.ReadLine();
                    InserirFim(tmp);
                }
            }
        }
            // método utilizado para comparar as partições realizadas pelo quicksort (usando nome como parâmetro)
        private CelulaDupla PartitionName(CelulaDupla low, CelulaDupla high)
        {
            string pivot = high.elemento.firstName + high.elemento.lastName;
            CelulaDupla i = low.ant;

            for (CelulaDupla j = low; j != high; j = j.prox)
            {
                if (string.Compare((j.elemento.firstName + j.elemento.lastName), pivot) <= 0)
                {
                    i = (i == null) ? low : i.prox;
                    Pessoa temp = i.elemento;
                    i.elemento = j.elemento;
                    j.elemento = temp;
                }
            }

            i = (i == null) ? low : i.prox;
            Pessoa temp1 = i.elemento;
            i.elemento = high.elemento;
            high.elemento = temp1;

            return i;
        }
        //Método quick sort usando nome como parâmetro
        public void QuickSortName()
        {
            QuickSortName(primeiro.prox, ultimo);
        }
        private void QuickSortName(CelulaDupla low, CelulaDupla high)
        {
            if (high != null && low != high && low != high.prox)
            {
                CelulaDupla pi = PartitionName(low, high);
                QuickSortName(low, pi.ant);
                QuickSortName(pi.prox, high);
            }
        }
        // método utilizado para comparar as partições realizadas pelo quicksort (usando trabalho como parâmetro)
        private CelulaDupla PartitionJob(CelulaDupla low, CelulaDupla high)
        {
            string pivot = high.elemento.jobTitle;
            CelulaDupla i = low.ant;

            for (CelulaDupla j = low; j != high; j = j.prox)
            {
                if (string.Compare((j.elemento.jobTitle), pivot) <= 0)
                {
                    i = (i == null) ? low : i.prox;
                    Pessoa temp = i.elemento;
                    i.elemento = j.elemento;
                    j.elemento = temp;
                }
            }

            i = (i == null) ? low : i.prox;
            Pessoa temp1 = i.elemento;
            i.elemento = high.elemento;
            high.elemento = temp1;

            return i;
        }
        //método quicksort usando trabalho como parâmetro
        public void QuickSortJob()
        {
            QuickSortJob(primeiro.prox, ultimo);
        }
        private void QuickSortJob(CelulaDupla low, CelulaDupla high)
        {
            if (high != null && low != high && low != high.prox)
            {
                CelulaDupla pi = PartitionJob(low, high);
                QuickSortJob(low, pi.ant);
                QuickSortJob(pi.prox, high);
            }
        }
        public void ApagaLista()
        {
            while (primeiro.prox != ultimo)
            {
                _ = RemoverFim();
            }
        }
    }
    }
