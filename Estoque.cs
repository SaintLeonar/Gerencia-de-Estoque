using System;
using System.Collections;
using System.Collections.Generic;

namespace backend
{
    public class Estoque
    {
        public List<Produto> produtos = new List<Produto>();

        public Estoque(){}

        /*
        *   Reabastece o Estoque por completo
        *
        *   Percorre os Produtos do Estoque reabastecendo aqueles produtos
        *   que precisam ser reabastecidos.
        *   
        *   Primeiro é verificado se o produto precisa ser reabastecido. Pelo método verificaEstoque().
        *   Caso o produto corrente precise de reabastecimento ele irá reabastecer na quantidade
        *   correspondente à demanda menos a ( quantidade em estoque + quantidade já vendida )
        *
        */
        public void reabasteceEstoque()
        {
            foreach(Produto p in this.produtos)
            {
                if(p.verificaEstoque())
                {
                    p.quantidade += p.getDemanda() - (p.quantidade + p.vendidos);
                    Console.WriteLine("Produto {0} - {1} foi Reabastecido!\n", p.id, p.nome);
                    p.showInfo();
                }
            }
        }

        /*
        *
        *   Alerta sobre os Produtos perto de vencer.
        *
        *   Percorre os Produtos do Estoque alertanto caso o produto esteja perto de vencer.
        *                                           e caso o produto esteja vencido.
        */
        public void alertaVencimento()
        {
            foreach(Produto p in this.produtos)
            {
                p.verificaValidade();
            }
        }

        /*
        *
        *   Aplica desconto sobre os Produtos perto de vencer ou oferta/demanda
        *
        *   Desconto de Vencimento:
        *       Valor default: 0.5 (50% de Desconto)
        *       Utiliza o método verificaValidade() para determinar se o desconto vai ser aplicado ou não
        *
        *   Desconto de Demanda:
        *       Valor default: 0.2 (20% de Desconto)
        *       Aplicará 20% de desconto naqueles produtos em que a demanda atual diminuiu na metade
        *       em comparação à demanda anterior ( demandaAnterior/2 ).
        *
        *   Observação:
        *       Caso algum produto seja verdadeiro para o Desconto de Vencimento e Desconto de Demanda
        *       O desconto de Vencimento será priorizado.
        *       Ou seja, será aplicado apenas o Desconto de Validade.
        *   
        */
        public void aplicaDesconto()
        {
            double descontoVencimento = 0.5; // Caso queira alterar o desconto de vencimento basta alterar essa variável.
            double descontoDemanda = 0.2; // Caso queira alterar o desconto de Demanda basta alterar essa variável.

            foreach(Produto p in this.produtos)
            {
                if(p.verificaValidade())
                {
                    Console.WriteLine("Aplicando desconto de {0} sobre o produto: {1} - {2} {3}", descontoVencimento, p.id, p.nome, p.marca);
                    p.preco = p.preco*descontoVencimento;
                    p.showInfo();
                }
                else
                    if(p.getDemanda() <= p.getDemandaAnterior()/2)
                    {
                        Console.WriteLine("Aplicando desconto de {0} sobre o produto: {1} - {2} {3}", descontoDemanda, p.id, p.nome, p.marca);
                        p.preco = p.preco*descontoDemanda;
                        p.showInfo();
                    }
            }
        }
    }
}