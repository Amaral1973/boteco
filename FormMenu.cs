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
        }

        private void pbFuncionario_Click(object sender, EventArgs e)
        {
            var func = new FormFuncionario();
            FormPrincipal principal = (FormPrincipal)this.Owner;
            func.WindowState = FormWindowState.Normal;
            func.Show();
        }
    }
}
