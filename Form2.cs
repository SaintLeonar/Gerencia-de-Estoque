using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerenciamentoDeEstoqueInterface;
using backend;

namespace GerenciamentoDeEstoqueInterface
{
    public partial class Form2 : Form
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

        public Form2(Form1 form ,Estoque atualEstoque)
        {
            InitializeComponent();
            estoqueAtual = atualEstoque;
            formParent = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            marca = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            categoria = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            preco = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            vendidos = Convert.ToInt16(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            quantidade = Convert.ToInt16(textBox6.Text);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            demandaAnterior = Convert.ToInt16(textBox7.Text);
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            demanda = Convert.ToInt16(textBox8.Text);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            dataVencimento = textBox9.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = estoqueAtual.GetListaProdutos().Count() + 1 ;
            Produto newProduct = new Produto(id, nome, marca, categoria, preco, quantidade, vendidos, demandaAnterior, demanda, Convert.ToDateTime(dataVencimento));
            estoqueAtual.produtos.Add(newProduct);
            formParent.UpdateList(sender,e);
            Close();
        }
    }
}
