using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            botepro.InserirPro(txtNome.Text, txtTipo.Text, quantidade, txtPreco.Text);
            MessageBox.Show("Produto inserido com sucesso!", "Inserir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botepro> produto = botepro.listaproduto();
            dgvProduto.DataSource = produto;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {
            Botepro botepro = new Botepro();
            List<Botepro> produto = botepro.listaproduto();
            dgvProduto.DataSource = produto;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            int quantidade = Convert.ToInt32(txtQuantidade.Text.Trim());
            Botepro botepro = new Botepro();
            botepro.AtualizarPro(id, txtNome.Text, txtTipo.Text, quantidade, txtPreco.Text);
            MessageBox.Show("Produto atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botepro> produto = botepro.listaproduto();
            dgvProduto.DataSource = produto;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botepro botepro = new Botepro();
            botepro.ExcluirPro(id);
            MessageBox.Show("Produto excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botepro> produto = botepro.listaproduto();
            dgvProduto.DataSource = produto;
            txtNome.Text = "";
            txtTipo.Text = "";
            txtQuantidade.Text = "";
            txtPreco.Text = "";
            txtId.Text = "";
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botepro botepro = new Botepro();
            botepro.LocalizaPro(id);
            txtNome.Text = botepro.nome;
            txtTipo.Text = botepro.tipo;
            txtQuantidade.Text = Convert.ToString(botepro.quantidade);
            txtPreco.Text = botepro.preco;
        }

        private void dgvProduto_DoubleClick(object sender, EventArgs e)
        {
            var PegarId = dgvProduto.CurrentCell.RowIndex;
            var PegarId2 = dgvProduto.Rows[PegarId].Cells[0].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            Botepro botepro = new Botepro();
            botepro.LocalizaPro(Id);
            txtId.Text = Convert.ToString(Id);
            txtNome.Text = botepro.nome;
            txtTipo.Text = botepro.tipo;
            txtQuantidade.Text = Convert.ToString(botepro.quantidade);
            txtPreco.Text = botepro.preco;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");
            string sql = "SELECT nome FROM Produto WHERE nome=@nome";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nome", SqlDbType.NChar).Value = txtNome.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Produto já existente em nossa base de dados", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtNome.Focus();
                rd.Close();
                con.Close();
            }
            rd.Close();
            con.Close();
        }
    }
}
