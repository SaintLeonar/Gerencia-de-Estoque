namespace GerenciamentoDeEstoqueInterface
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ColumnHeader Nome;
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewProd = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Preço = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qntd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vendidos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DemandaAnterior = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DemandaAtual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 88;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 556);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1045, 23);
            this.panel2.TabIndex = 2;
            // 
            // listViewProd
            // 
            this.listViewProd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            Nome,
            this.Marca,
            this.Categoria,
            this.Preço,
            this.Qntd,
            this.Vendidos,
            this.DemandaAnterior,
            this.DemandaAtual,
            this.DataVencimento});
            this.listViewProd.Font = new System.Drawing.Font("Rubik", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProd.FullRowSelect = true;
            this.listViewProd.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listViewProd.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listViewProd.HideSelection = false;
            this.listViewProd.Location = new System.Drawing.Point(168, 29);
            this.listViewProd.Name = "listViewProd";
            this.listViewProd.Size = new System.Drawing.Size(1033, 480);
            this.listViewProd.TabIndex = 3;
            this.listViewProd.UseCompatibleStateImageBehavior = false;
            this.listViewProd.View = System.Windows.Forms.View.Details;
            this.listViewProd.Click += new System.EventHandler(this.UpdateList);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 82;
            // 
            // Preço
            // 
            this.Preço.Text = "Preço";
            // 
            // Qntd
            // 
            this.Qntd.Text = "Qntd";
            // 
            // Vendidos
            // 
            this.Vendidos.Text = "Vendidos";
            // 
            // DemandaAnterior
            // 
            this.DemandaAnterior.Text = "DemandaAnterior";
            this.DemandaAnterior.Width = 103;
            // 
            // DemandaAtual
            // 
            this.DemandaAtual.Text = "Demanda Atual";
            this.DemandaAtual.Width = 102;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Text = "Data Vencimento";
            this.DataVencimento.Width = 101;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1213, 556);
            this.Controls.Add(this.listViewProd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listViewProd;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Preço;
        private System.Windows.Forms.ColumnHeader Qntd;
        private System.Windows.Forms.ColumnHeader Vendidos;
        private System.Windows.Forms.ColumnHeader DemandaAnterior;
        private System.Windows.Forms.ColumnHeader DemandaAtual;
        private System.Windows.Forms.ColumnHeader DataVencimento;
    }
}

