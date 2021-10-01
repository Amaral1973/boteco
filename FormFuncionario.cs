using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Data.SqlClient;

namespace Boteco
{
    public partial class FormFuncionario : Form
    {
        public FormMenu Total = null;

        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Boteco boteco = new Boteco();
            string genero = Convert.ToString(cbxGenero.SelectedItem);
            string funcao = Convert.ToString(cbxFuncao.SelectedItem);
            boteco.InserirFunc(txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, genero, txtDataNascimento.Text, funcao);
            MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Boteco> funcionario = boteco.listafuncionario();
            dgvFuncionario.DataSource = funcionario;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCC.Text = "";
            txtPix.Text = "";
            cbxFuncao.SelectedIndex = -1;
            cbxGenero.SelectedIndex = -1;
            string total = Convert.ToString(boteco.NFuncionario());
            if (Total != null)
            {
                Total.lblTotalFunc.Text = total;
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            Boteco boteco = new Boteco();
            List<Boteco> botecos = boteco.listafuncionario();
            dgvFuncionario.DataSource = botecos;
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Boteco boteco = new Boteco();
            boteco.LocalizaFunc(id);
            txtNome.Text = boteco.nome;
            txtCPF.Text = boteco.cpf;
            txtDataNascimento.Text = boteco.data_nascimento;
            txtCelular.Text = boteco.celular;
            txtCEP.Text = boteco.cep;
            txtEndereco.Text = boteco.endereco;
            txtCidade.Text = boteco.cidade;
            txtComplemento.Text = boteco.complemento;
            txtCC.Text = boteco.cc;
            txtPix.Text = boteco.pix;
            cbxGenero.Text = boteco.genero;
            cbxFuncao.Text = boteco.funcao;
            txtCidade.Enabled = true;
            txtEndereco.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Boteco boteco = new Boteco();
            string genero = Convert.ToString(cbxGenero.SelectedItem);
            string funcao = Convert.ToString(cbxFuncao.SelectedItem);
            boteco.AtualizarFunc(id,txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, genero, txtDataNascimento.Text, funcao);
            MessageBox.Show("Funcionário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Boteco> funcionario = boteco.listafuncionario();
            dgvFuncionario.DataSource = funcionario;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCC.Text = "";
            txtPix.Text = "";
            cbxFuncao.SelectedIndex = -1;
            cbxGenero.SelectedIndex = -1;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text.Trim());
            Boteco boteco = new Boteco();
            boteco.ExcluirFunc(id);
            MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Boteco> funcionario = boteco.listafuncionario();
            dgvFuncionario.DataSource = funcionario;
            txtNome.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            txtCelular.Text = "";
            txtCEP.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtComplemento.Text = "";
            txtCC.Text = "";
            txtPix.Text = "";
            cbxFuncao.SelectedIndex = -1;
            cbxGenero.SelectedIndex = -1;
            string total = Convert.ToString(boteco.NFuncionario());
            if (Total != null)
            {
                Total.lblTotalFunc.Text = total;
            }
        }

        private void dgvFuncionario_DoubleClick(object sender, EventArgs e)
        {
            var PegarId = dgvFuncionario.CurrentCell.RowIndex;
            var PegarId2 = dgvFuncionario.Rows[PegarId].Cells[0].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            Boteco boteco = new Boteco();
            boteco.LocalizaFunc(Id);
            txtId.Text = Convert.ToString(Id);
            txtNome.Text = boteco.nome;
            txtCPF.Text = boteco.cpf;
            txtDataNascimento.Text = boteco.data_nascimento;
            txtCelular.Text = boteco.celular;
            txtCEP.Text = boteco.cep;
            txtEndereco.Text = boteco.endereco;
            txtCidade.Text = boteco.cidade;
            txtComplemento.Text = boteco.complemento;
            txtCC.Text = boteco.cc;
            txtPix.Text = boteco.pix;
            cbxGenero.Text = boteco.genero;
            cbxFuncao.Text = boteco.funcao;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + txtCEP.Text + "/json/");
            request.AllowAutoRedirect = false;
            HttpWebResponse ChecaServidor = (HttpWebResponse)request.GetResponse();
            if (ChecaServidor.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Servidor indisponível!");
                return; // Sai da rotina
            }
            using (Stream webStream = ChecaServidor.GetResponseStream())
            {
                if (webStream != null)
                {
                    using (StreamReader responseReader = new StreamReader(webStream))
                    {
                        string response = responseReader.ReadToEnd();
                        response = Regex.Replace(response, "[{},]", string.Empty);
                        response = response.Replace("\"", "");

                        String[] substrings = response.Split('\n');

                        int cont = 0;
                        foreach (var substring in substrings)
                        {
                            if (cont == 1)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                if (valor[0] == "  erro")
                                {
                                    MessageBox.Show("CEP não encontrado", "CEP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtCEP.Text = "";
                                    txtCEP.Focus();
                                    return;
                                }
                            }

                            //Logradouro
                            if (cont == 2)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtEndereco.Text = valor[1];
                            }

                            //Localidade (Cidade)
                            if (cont == 5)
                            {
                                string[] valor = substring.Split(":".ToCharArray());
                                txtCidade.Text = valor[1];
                            }
                            cont++;
                        }
                    }
                }
            }

        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Programas\\Boteco\\DbBoteco.mdf;Integrated Security=True");
            string sql = "SELECT nome FROM Funcionario WHERE cpf=@cpf";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cpf", SqlDbType.NChar).Value = txtCPF.Text.Trim();
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                MessageBox.Show("Funcionário já existente em nossa base de dados", "Produto Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
