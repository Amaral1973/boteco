
namespace Boteco
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardápioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbVenda = new System.Windows.Forms.PictureBox();
            this.pbProduto = new System.Windows.Forms.PictureBox();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.cardápioToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // cardápioToolStripMenuItem
            // 
            this.cardápioToolStripMenuItem.Name = "cardápioToolStripMenuItem";
            this.cardápioToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cardápioToolStripMenuItem.Text = "Cardápio";
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pbVenda
            // 
            this.pbVenda.Image = global::Boteco.Properties.Resources.venda;
            this.pbVenda.Location = new System.Drawing.Point(546, 38);
            this.pbVenda.Name = "pbVenda";
            this.pbVenda.Size = new System.Drawing.Size(172, 182);
            this.pbVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbVenda.TabIndex = 5;
            this.pbVenda.TabStop = false;
            // 
            // pbProduto
            // 
            this.pbProduto.Image = global::Boteco.Properties.Resources.produto;
            this.pbProduto.Location = new System.Drawing.Point(368, 38);
            this.pbProduto.Name = "pbProduto";
            this.pbProduto.Size = new System.Drawing.Size(172, 182);
            this.pbProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProduto.TabIndex = 4;
            this.pbProduto.TabStop = false;
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Boteco.Properties.Resources.cliente;
            this.pbCliente.Location = new System.Drawing.Point(190, 38);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(172, 182);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 3;
            this.pbCliente.TabStop = false;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Boteco.Properties.Resources.funcionario;
            this.pbFuncionario.Location = new System.Drawing.Point(12, 38);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(172, 182);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 2;
            this.pbFuncionario.TabStop = false;
            this.pbFuncionario.Click += new System.EventHandler(this.pbFuncionario_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.pbVenda);
            this.Controls.Add(this.pbProduto);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.pbFuncionario);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.Text = "Boteco";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardápioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.PictureBox pbProduto;
        private System.Windows.Forms.PictureBox pbVenda;
    }
}

