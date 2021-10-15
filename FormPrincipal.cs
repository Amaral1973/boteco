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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            var menu = new FormMenu();
            menu.MdiParent = this;
            menu.WindowState = FormWindowState.Maximized;
            menu.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var func = new FormFuncionario();
            func.MdiParent = this;
            func.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Deseja mesmo sair do sistema?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cli = new FormCliente();
            cli.MdiParent = this;
            cli.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackColor = Color.White;
                    break;
                }
            }
        }

        private void cardápioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pro = new FormProduto();
            pro.MdiParent = this;
            pro.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ven = new FormVenda();
            ven.MdiParent = this;
            ven.Show();
        }
    }
}
