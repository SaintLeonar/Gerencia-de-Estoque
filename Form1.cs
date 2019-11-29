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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
