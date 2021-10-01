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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.LocalizaCli(id);
            txtNome.Text = botecli.nome;
            txtCPF.Text = botecli.cpf;
            txtDataNascimento.Text = botecli.data_nascimento;
            txtCelular.Text = botecli.celular;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Botecli botecli = new Botecli();
            botecli.InserirCli(txtNome.Text, txtCPF.Text, txtDataNascimento.Text, txtCelular.Text);
            MessageBox.Show("Cliente inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.AtualizaCli(id,txtNome.Text, txtCPF.Text, txtDataNascimento.Text, txtCelular.Text);
            MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Botecli botecli = new Botecli();
            botecli.ExcluirCli(id);
            MessageBox.Show("Cliente apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            Botecli botecli = new Botecli();
            List<Botecli> cliente = botecli.listacli();
            dgvCliente.DataSource = cliente;
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            var PegarId = dgvCliente.CurrentCell.RowIndex;
            var PegarId2 = dgvCliente.Rows[PegarId].Cells[0].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            Botecli boteco = new Botecli();
            boteco.LocalizaCli(Id);
            txtId.Text = Convert.ToString(Id);
            txtNome.Text = boteco.nome;
            txtCPF.Text = boteco.cpf;
            txtDataNascimento.Text = boteco.data_nascimento;
            txtCelular.Text = boteco.celular;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");
            string sql = "SELECT nome FROM Cliente WHERE cpf=@cpf";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Cliente já existente em nossa base de dados", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Text = "";
                txtCPF.Text = "";
                txtNome.Focus();
                rd.Close();
                con.Close();
            }
            rd.Close();
            con.Close();
        }
    }
}
