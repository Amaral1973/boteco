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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            Boteco boteco = new Boteco();
            int total = boteco.NFuncionario();
            lblTotalFunc.Text = Convert.ToString(total);
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            var func = new FormFuncionario();
            func.MdiParent = this.MdiParent;
            func.WindowState = FormWindowState.Normal;
            func.Show();
        }

        private void pbCliente_Click(object sender, EventArgs e)
        {
            var cli = new FormCliente();
            cli.MdiParent = this.MdiParent;
            cli.Show();
        }
    }
}
