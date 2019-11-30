using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using backend;

namespace GerenciamentoDeEstoqueInterface
{
    public partial class Form3 : Form
    {
        public int id;
        public string nome;
        public string marca;
        public string categoria;
        public double preco;
        public int quantidade;
        public int vendidos;
        private int demandaAnterior;
        private int demanda;
        public string dataVencimento;


        private Estoque estoqueAtual;

        private Form1 formParent;

        public Form3(Form1 form, Estoque atualEstoque)
        {
            InitializeComponent();
            estoqueAtual = atualEstoque;
            formParent = form;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                var produtos = estoqueAtual.GetListaProdutos();
                comboBox1.Items.Clear();
                foreach (Produto prod in produtos)
                {
                    var item = prod.nome;

                    comboBox1.Items.Add(item);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeItem = comboBox1.Text;
            if (estoqueAtual != null)
            {
                var produtos = estoqueAtual.GetListaProdutos();
                foreach (Produto prod in produtos)
                {
                    if (prod.nome == nomeItem)
                    {
                        int nRemover = Convert.ToInt16(textBox1.Text);
                        if(nRemover <= 0)
                        {
                            Close();
                        }
                        if(prod.quantidade == 1 || prod.quantidade <= nRemover)
                        {
                           estoqueAtual.produtos.Remove(prod);
                        }
                        else if (prod.quantidade > 1 && prod.quantidade > nRemover)
                        {
                            prod.quantidade = prod.quantidade - nRemover;
                            prod.vendidos = prod.vendidos + nRemover;
                            prod.setDemanda(nRemover);
                        }
                        formParent.UpdateList(sender, e);
                        break;
                    }
                }
            }
            Close();
        }


    }
}
