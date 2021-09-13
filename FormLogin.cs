using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Boteco
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormSplash splash = new FormSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;
            if (login == "admin" && senha == "admin")
            {
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Suas credencias não foram validadas, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}
