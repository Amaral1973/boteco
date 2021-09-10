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
    public partial class FormFuncionario : Form
    {
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
            DateTime nascimento = Convert.ToDateTime(txtDataNascimento.Text);
            boteco.InserirFunc(txtNome.Text, txtCelular.Text, txtEndereco.Text, txtComplemento.Text, txtCidade.Text, txtCEP.Text, txtCPF.Text, txtCC.Text, txtPix.Text, genero, nascimento, funcao);
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
        }
    }
}
