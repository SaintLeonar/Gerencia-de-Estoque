using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend;
using GerenciamentoDeEstoqueInterface;

namespace InterfaceGerEstoque
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Produto produto1 = new Produto(1, "Caneta Azul", "Bic", "Material Escolar", 2.99, 3, 5, 30, 30, new DateTime(2019, 12, 31));
            Produto produto2 = new Produto(2, "Calculadora", "Matemática", "Material Escolar", 10.00, 25, 5, 30, 30, new DateTime(2030, 01, 01));
            Produto produto3 = new Produto(3, "Leite", "Batavo", "Alimentos", 6.90, 10, 5, 15, 15, new DateTime(2019, 11, 30));
            Produto produto4 = new Produto(4, "iPhone X", "Apple", "Smart Phone", 2000.00, 20, 4, 20, 10, new DateTime(2030, 11, 30));
            Produto produto5 = new Produto(5, "Pringles", "Alimentos", "Elma Chips", 14.99, 50, 3, 20, 10, new DateTime(2019, 11, 30));

            Estoque estoque = new Estoque();

            estoque.produtos.Add(produto1);
            estoque.produtos.Add(produto2);
            estoque.produtos.Add(produto3);
            estoque.produtos.Add(produto4);
            estoque.produtos.Add(produto5);

            foreach (Produto p in estoque.produtos)
            {
                p.showInfo();
            }

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Execução da Funcionalidade 1.3.1.3 (Verificar Dicionario da EAP)\n");
            estoque.reabasteceEstoque();
            Console.WriteLine("-----------------------------------------------------------------------------\n");
            Console.WriteLine("Execução da Funcionalidade 1.3.1.1 (Verificar Dicionario da EAP)\n");
            estoque.alertaVencimento();
            Console.WriteLine("-----------------------------------------------------------------------------\n");
            Console.WriteLine("Execução da Funcionalidade 1.3.1.2 (Verificar Dicionario da EAP)\n");
            estoque.aplicaDesconto();
            Console.WriteLine("-----------------------------------------------------------------------------\n");

            Console.ReadLine();

            Application.Run(new Form1());
        }
    }
}
