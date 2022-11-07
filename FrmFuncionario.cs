using BotecoTDS07;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotecoTDS08
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            List<Funcionario> funcionarios = funcionario.listafuncionario();
            dgvFuncionario.DataSource = funcionarios;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtCpf.Text == "" && txtCep.Text == "" && txtCelular.Text == "")
                {
                    MessageBox.Show("Por favor, preencha o formulário!", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtNome.Focus();
                }
                else
                {
                    Funcionario funcionario = new Funcionario();
                    if (funcionario.RegistroRepetido(txtNome.Text, txtCpf.Text) != false)
                    {
                        MessageBox.Show("Este funcionário já existe em nossa base de dados!", "Funcionário Repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Text = "";
                        txtCelular.Text = "";
                        txtEndereco.Text = "";
                        txtComplemento.Text = "";
                        txtCidade.Text = "";
                        txtCep.Text = "";
                        txtCpf.Text = "";
                        txtCc.Text = "";
                        txtPix.Text = "";
                        txtGenero.Text = "";
                        txtDataNascimento.Text = "";
                        txtFuncao.Text = "";
                        this.txtNome.Focus();

                    }
                    else
                    {
                        funcionario.Inserir(txtNome.Text,txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, txtCc.Text, txtPix.Text, txtGenero.Text, txtDataNascimento.Text, txtFuncao.Text);
                        MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        List<Funcionario> funcionarios = funcionario.listafuncionario();
                        dgvFuncionario.DataSource = funcionarios;
                        txtNome.Text = "";
                        txtCelular.Text = "";
                        txtEndereco.Text = "";
                        txtComplemento.Text = "";
                        txtCidade.Text = "";
                        txtCep.Text = "";
                        txtCpf.Text = "";
                        txtCc.Text = "";
                        txtPix.Text = "";
                        txtGenero.Text = "";
                        txtDataNascimento.Text = "";
                        txtFuncao.Text = "";
                        this.txtNome.Focus();
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Por favor digite um ID!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtId.Focus();
            }
            else
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Localizar(Id);
                txtNome.Text = funcionario.nome;
                txtCelular.Text = funcionario.celular;
                txtEndereco.Text = funcionario.endereco;
                txtComplemento.Text = funcionario.complemento;
                txtCidade.Text = funcionario.cidade;
                txtCep.Text = funcionario.cep;
                txtCpf.Text = funcionario.cpf;
                txtCc.Text = funcionario.cc;
                txtPix.Text = funcionario.pix;
                txtGenero.Text = funcionario.genero;
                txtDataNascimento.Text = funcionario.data_nascimento;
                txtFuncao.Text = funcionario.funcao;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Atualizar(Id, txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCep.Text, txtCpf.Text, txtCc.Text, txtPix.Text, txtGenero.Text, txtDataNascimento.Text, txtFuncao.Text);
                MessageBox.Show("Funcionário atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtCidade.Text = "";
                txtCep.Text = "";
                txtCpf.Text = "";
                txtCc.Text = "";
                txtPix.Text = "";
                txtGenero.Text = "";
                txtDataNascimento.Text = "";
                txtFuncao.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtId.Text.Trim());
                Funcionario funcionario = new Funcionario();
                funcionario.Excluir(Id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Funcionario> funcionarios = funcionario.listafuncionario();
                dgvFuncionario.DataSource = funcionarios;
                txtId.Text = "";
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEndereco.Text = "";
                txtComplemento.Text = "";
                txtCidade.Text = "";
                txtCep.Text = "";
                txtCpf.Text = "";
                txtCc.Text = "";
                txtPix.Text = "";
                txtGenero.Text = "";
                txtDataNascimento.Text = "";
                txtFuncao.Text = "";
                this.txtNome.Focus();
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvFuncionario.Rows[e.RowIndex];
                row.Selected = true;
                txtId.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                txtCelular.Text = row.Cells[2].Value.ToString();
                txtEndereco.Text = row.Cells[3].Value.ToString();
                txtComplemento.Text = row.Cells[4].Value.ToString();
                txtCidade.Text = row.Cells[5].Value.ToString();
                txtCep.Text = row.Cells[6].Value.ToString();
                txtCpf.Text = row.Cells[7].Value.ToString();
                txtCc.Text = row.Cells[8].Value.ToString();
                txtPix.Text = row.Cells[9].Value.ToString();
                txtGenero.Text = row.Cells[10].Value.ToString();
                txtDataNascimento.Text = row.Cells[11].Value.ToString();
                txtFuncao.Text = row.Cells[12].Value.ToString();
            }
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            BuscaCEP busca = new BuscaCEP();
            busca.Busca(txtCep.Text);
            txtCidade.Text = busca.cidade;
            txtComplemento.Text = busca.complemento;
            txtEndereco.Text = busca.endereco;
        }
    }
}
