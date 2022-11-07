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

namespace BotecoTDS08
{
    public partial class FrmVenda : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\BotecoTDS08\\DbBoteco.mdf;Integrated Security=True");

        public FrmVenda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCbxCliente()
        {
            string cli = "SELECT Id,nome FROM Cliente";
            SqlCommand cmd = new SqlCommand(cli, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cli, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "cliente");
            cbxCliente.ValueMember = "Id";
            cbxCliente.DisplayMember = "nome";
            cbxCliente.DataSource = ds.Tables["cliente"];
            con.Close();
        }

        public void CarregaCbxProduto()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            string pro = "SELECT Id,nome FROM Produto";
            SqlCommand cmd = new SqlCommand(pro, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(pro, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "produto");
            cbxProduto.ValueMember = "Id";
            cbxProduto.DisplayMember = "nome";
            cbxProduto.DataSource = ds.Tables["produto"];
            con.Close();
        }

        private void FrmVenda_Load(object sender, EventArgs e)
        {
            CarregaCbxCliente();
            cbxProduto.Enabled = false;
            txtIdProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtValor.Enabled = false;
            txtTotal.Enabled = false;
            btnAtualizarPedido.Enabled = false;
            btnFinalizarPedido.Enabled = false;
            btnFinalizarVenda.Enabled = false;
            btnNovoItem.Enabled = false;
            btnEditarItem.Enabled = false;
            btnExcluirItem.Enabled = false;
        }

        private void btnNovoPedido_Click(object sender, EventArgs e)
        {
            cbxProduto.Enabled = true;
            CarregaCbxProduto();
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;
            txtTotal.Enabled = true;
            btnAtualizarPedido.Enabled = true;
            btnFinalizarPedido.Enabled = true;
            btnFinalizarVenda.Enabled = true;
            btnEditarItem.Enabled = true;
            btnNovoItem.Enabled = true;
            btnExcluirItem.Enabled = true;
            dgvPedido.Columns.Add("ID", "ID");
            dgvPedido.Columns.Add("Produto", "Produto");
            dgvPedido.Columns.Add("Quantidade", "Quantidade");
            dgvPedido.Columns.Add("Valor", "Valor");
            dgvPedido.Columns.Add("Total", "Total");
        }

        private void cbxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Produto WHERE Id=@Id", con);
            cmd.Parameters.AddWithValue("@Id", cbxProduto.SelectedValue);
            cmd.CommandType = CommandType.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtValor.Text = dr["preco"].ToString();
                txtIdProduto.Text = dr["Id"].ToString();
                txtQuantidade.Focus();
                dr.Close();
                con.Close();
            }
            con.Open();
            SqlCommand cmd2 = new SqlCommand("Quantidade_Produto", con);
            cmd2.Parameters.AddWithValue("@Id", txtIdProduto.Text);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                lblEstoque.Text = dr2["quantidade"].ToString();
            }
            dr2.Close();
            con.Close();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            var repetido = false;
            foreach (DataGridViewRow dr in dgvPedido.Rows)
            {
                if (txtIdProduto.Text == Convert.ToString(dr.Cells[0].Value))
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                DataGridViewRow item = new DataGridViewRow();
                item.CreateCells(dgvPedido);
                item.Cells[0].Value = txtIdProduto.Text;
                item.Cells[1].Value = cbxProduto.Text;
                item.Cells[2].Value = txtQuantidade.Text;
                item.Cells[3].Value = txtValor.Text;
                item.Cells[4].Value = Convert.ToDecimal(txtValor.Text) * Convert.ToDecimal(txtQuantidade.Text);
                dgvPedido.Rows.Add(item);
                txtIdProduto.Text = "";
                txtValor.Text = "";
                txtQuantidade.Text = "";
                cbxProduto.Text = "";
                decimal soma = 0;
                foreach (DataGridViewRow dr in dgvPedido.Rows)
                    soma += Convert.ToDecimal(dr.Cells[4].Value);
                txtTotal.Text = Convert.ToString(soma);
            }
            else
            {
                MessageBox.Show("Produto já cadastrado!", "Produto repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
