using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boteco
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Botepro botepro = new Botepro();
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            decimal preco = Convert.ToDecimal(txtPreco.Text);
            botepro.InserirPro(txtNome.Text, txtTipo.Text, quantidade, preco);
            MessageBox.Show("Produto inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botepro> produto = botepro.listaproduto();
            dgvProduto.DataSource = produto;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }
    }
}
