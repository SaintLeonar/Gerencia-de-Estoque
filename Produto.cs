using System;

namespace backend
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public string categoria { get; set; }
        public double preco { get; set; }
        public int quantidade { get; set; }
        public int vendidos { get; set; }
        private int demandaAnterior;
        private int demanda;
        public DateTime dataVencimento { get; set; }

        public Produto() { }

        public Produto(int id, string nome, string marca, string categoria, double preco, int quantidade, int vendidos, int demandaAnterior, int demanda, DateTime dataVencimento)
        {
            this.id = id;
            this.nome = nome;
            this.marca = marca;
            this.categoria = categoria;
            this.preco = preco;
            this.quantidade = quantidade;
            this.vendidos = vendidos;
            this.demandaAnterior = demandaAnterior;
            this.demanda = demanda;
            this.dataVencimento = dataVencimento;
        }

        public Produto(Produto pr)
        {
            this.id = pr.id;
            this.nome = pr.nome;
            this.marca = pr.marca;
            this.categoria = pr.categoria;
            this.preco = pr.preco;
            this.quantidade = pr.quantidade;
            this.vendidos = pr.vendidos;
            this.demandaAnterior = pr.demandaAnterior;
            this.demanda = pr.demanda;
            this.dataVencimento = pr.dataVencimento;
        }

        public void setDemanda(int demanda)
        {
            this.demandaAnterior = this.demanda;
            this.demanda = demanda;
        }
        public int getDemanda()
        {
            return this.demanda;
        }

        public int getDemandaAnterior()
        {
            return this.demandaAnterior;
        }

        public void showInfo()
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("ID: {0}\nNome: {1}\nMarca: {2}\nCategoria: {3}\nPreco: {4}\nQuantidade em Estoque: {5}\nVendidos até o momento: {6}\nDemanda: {7}\nData Vencimento: {8}", this.id, this.nome, this.marca, this.categoria, this.preco, this.quantidade, this.vendidos, this.demanda, this.dataVencimento);
            Console.WriteLine("-----------------------------------------------------------------------------\n");
        }

        /*
        *
        *   Verifica o estoque de UM produto
        *
        *   Retorna true caso o produto precise de reabastecimento.
        *   Retorna false caso contrário
        *
        *   O quesito escolhido para reabastecer o estoque foi
        *   o estoque estar com menos ou igual a 10% da Capacidade.
        *   Capacidade se refere a demanda do produto.
        *
        */
        public bool verificaEstoque()
        {
            if (this.quantidade <= this.demanda * 0.1)
            {
                Console.WriteLine("Produto {0} - {1} Precisa de reabastecimento!\n", this.id, this.nome);
                return true;
            }
            return false;
        }

        /*
        *
        *   Verifica a validade de UM produto
        *
        *   Retorna true se a validade estiver à x dias da data de validade (armazenado na variável diasLimite).
        *   No caso foi escolhido como 3 dias.
        *   Retorna false caso o produto não esteja perto de vencer ( > x (diasLimite) )
        *              OU caso o produto já esteja vencido. Nesse caso o sistema recomenda limpar o estoque;
        *
        */
        public int verificaValidade()
        {
            int diasLimite = 3; // Caso queira aumentar ou diminuir o limite de dias basta alterar nessa variável.

            DateTime dataAtual = DateTime.Today;
            TimeSpan diff = this.dataVencimento.Subtract(dataAtual); // Subtração da data de vencimento do produto pela data atual. (Não retorna em dias)

            int diasRestantes = (int)diff.TotalDays; // O método TotalDays realiza um parse para o número de dias em double. Ao fim foi feito um type casting para int.

            if (diasRestantes <= 0)
            {
                Console.WriteLine("Produto {0} - {1} {2} está vencido.\nLimpe o estoque desse produto!\n", this.id, this.nome, this.marca);
                return -1;
            }
            else if (diasRestantes <= diasLimite)
            {
                Console.WriteLine("Produto {0} - {1} {2} está a {3} dia(s) da data de vencimento.\nRecomenda-se aplicar descontos!\n", this.id, this.nome, this.marca, diasRestantes);
                return 0;
            }

            return 1;
        }
    }
}