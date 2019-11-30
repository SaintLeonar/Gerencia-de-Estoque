using backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoqueInterface
{
    public partial class Form1 : Form
    {
        private Estoque estoqueAtual;
        public Form1(Estoque atualEstoque)
        {
            InitializeComponent();
            estoqueAtual = atualEstoque;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateList(sender, e);
            if (estoqueAtual != null)
            {
                DescontoDemanda.Text = (estoqueAtual.descontoDemanda * 100).ToString() + "%";
                DescontoVencimento.Text = (estoqueAtual.descontoVencimento * 100).ToString() + "%";
            }
        }
        public void UpdateList(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                var produtos = estoqueAtual.GetListaProdutos();
                listViewProd.Items.Clear();
                foreach (Produto prod in produtos)
                {
                    var row = new string[] { prod.id.ToString(), prod.nome, prod.marca, prod.preco.ToString(), prod.quantidade.ToString(), prod.vendidos.ToString(), prod.getDemandaAnterior().ToString(), prod.getDemanda().ToString(), prod.dataVencimento.ToShortDateString() };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = prod;
                    listViewProd.Items.Add(lvi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                var produtos = estoqueAtual.GetListaProdutos();
                listViewProd.Items.Clear();
                foreach (Produto prod in produtos)
                {
                    var row = new string[] { prod.id.ToString(), prod.nome, prod.marca, prod.preco.ToString(), prod.quantidade.ToString(), prod.vendidos.ToString(), prod.getDemandaAnterior().ToString(), prod.getDemanda().ToString(), prod.dataVencimento.ToShortDateString() };
                    var lvi = new ListViewItem(row);
                    if(prod.verificaValidade() == -1)
                    {
                        lvi.ForeColor = Color.Red; // Produto vencido
                    }
                    else if(prod.verificaValidade() == 0)
                    {
                        lvi.ForeColor = Color.DarkOrange; // Produto perto do prazo de validade
                    }
                    else if (prod.verificaValidade() == 1)
                    {
                        lvi.ForeColor = Color.Black; // Produto dentro do prazo de validade
                    }

                    lvi.Tag = prod;
                    listViewProd.Items.Add(lvi);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                var oldProdutosList = new List<Produto>();
                foreach (Produto produto in estoqueAtual.GetListaProdutos())
                {
                    oldProdutosList.Add(new Produto(produto));
                }
                estoqueAtual.aplicaDesconto();
                var newProdutosList = estoqueAtual.GetListaProdutos();

                listViewProd.Items.Clear();
                foreach (Produto prod in newProdutosList)
                {
                    var row = new string[] { prod.id.ToString(), prod.nome, prod.marca, prod.preco.ToString(), prod.quantidade.ToString(), prod.vendidos.ToString(), prod.getDemandaAnterior().ToString(), prod.getDemanda().ToString(), prod.dataVencimento.ToShortDateString() };
                    var lvi = new ListViewItem(row);
                    var prodOld = oldProdutosList.Find(x => x.id == prod.id);
                    if(prod.preco < prodOld.preco)
                    {
                        lvi.ForeColor = Color.Green;
                    }

                    lvi.Tag = prod;
                    listViewProd.Items.Add(lvi);
                }
            }
        }

        private void listViewProd_DoubleClick(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                var produtos = estoqueAtual.GetListaProdutos();
                listViewProd.Items.Clear();
                foreach (Produto prod in produtos)
                {
                    var row = new string[] { prod.id.ToString(), prod.nome, prod.marca, prod.preco.ToString(), prod.quantidade.ToString(), prod.vendidos.ToString(), prod.getDemandaAnterior().ToString(), prod.getDemanda().ToString(), prod.dataVencimento.ToShortDateString() };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = prod;
                    lvi.ForeColor = Color.Black;
                    listViewProd.Items.Add(lvi);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (estoqueAtual != null)
            {
                estoqueAtual.reabasteceEstoque();
                var produtos = estoqueAtual.GetListaProdutos();
                listViewProd.Items.Clear();
                foreach (Produto prod in produtos)
                {
                    var row = new string[] { prod.id.ToString(), prod.nome, prod.marca, prod.preco.ToString(), prod.quantidade.ToString(), prod.vendidos.ToString(), prod.getDemandaAnterior().ToString(), prod.getDemanda().ToString(), prod.dataVencimento.ToShortDateString() };
                    var lvi = new ListViewItem(row);

                    lvi.Tag = prod;
                    lvi.ForeColor = Color.Black;
                    listViewProd.Items.Add(lvi);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2(this,estoqueAtual);
            popup.Show(this);
            //if (dialogresult == DialogResult.OK)
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listViewProd.SelectedItems.Count > 0)
            {
               // Produto item = listViewProd.SelectedItems[0];
                //rest of your logic
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
