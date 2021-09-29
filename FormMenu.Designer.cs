
namespace Boteco
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFuncionário = new System.Windows.Forms.Label();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.pbCliente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDadosGerenciais = new System.Windows.Forms.GroupBox();
            this.lblTotalFunc = new System.Windows.Forms.Label();
            this.lblTotalFuncionários = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).BeginInit();
            this.gbDadosGerenciais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncionário
            // 
            this.lblFuncionário.AutoSize = true;
            this.lblFuncionário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionário.Location = new System.Drawing.Point(34, 191);
            this.lblFuncionário.Name = "lblFuncionário";
            this.lblFuncionário.Size = new System.Drawing.Size(122, 18);
            this.lblFuncionário.TabIndex = 1;
            this.lblFuncionário.Text = "FUNCIONÁRIO";
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Image = global::Boteco.Properties.Resources.funcionario;
            this.pbFuncionario.Location = new System.Drawing.Point(32, 61);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(126, 123);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFuncionario.TabIndex = 0;
            this.pbFuncionario.TabStop = false;
            this.pbFuncionario.Click += new System.EventHandler(this.pbFuncionario_Click);
            // 
            // pbCliente
            // 
            this.pbCliente.Image = global::Boteco.Properties.Resources.cliente;
            this.pbCliente.Location = new System.Drawing.Point(203, 61);
            this.pbCliente.Name = "pbCliente";
            this.pbCliente.Size = new System.Drawing.Size(129, 123);
            this.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCliente.TabIndex = 2;
            this.pbCliente.TabStop = false;
            this.pbCliente.Click += new System.EventHandler(this.pbCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTE";
            // 
            // gbDadosGerenciais
            // 
            this.gbDadosGerenciais.Controls.Add(this.lblTotalFunc);
            this.gbDadosGerenciais.Controls.Add(this.lblTotalFuncionários);
            this.gbDadosGerenciais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosGerenciais.Location = new System.Drawing.Point(37, 230);
            this.gbDadosGerenciais.Name = "gbDadosGerenciais";
            this.gbDadosGerenciais.Size = new System.Drawing.Size(295, 148);
            this.gbDadosGerenciais.TabIndex = 4;
            this.gbDadosGerenciais.TabStop = false;
            this.gbDadosGerenciais.Text = "Dados Gerenciais";
            // 
            // lblTotalFunc
            // 
            this.lblTotalFunc.AutoSize = true;
            this.lblTotalFunc.Location = new System.Drawing.Point(214, 36);
            this.lblTotalFunc.Name = "lblTotalFunc";
            this.lblTotalFunc.Size = new System.Drawing.Size(0, 18);
            this.lblTotalFunc.TabIndex = 1;
            // 
            // lblTotalFuncionários
            // 
            this.lblTotalFuncionários.AutoSize = true;
            this.lblTotalFuncionários.Location = new System.Drawing.Point(6, 36);
            this.lblTotalFuncionários.Name = "lblTotalFuncionários";
            this.lblTotalFuncionários.Size = new System.Drawing.Size(200, 18);
            this.lblTotalFuncionários.TabIndex = 0;
            this.lblTotalFuncionários.Text = "Nº Total de Funcionários:";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbDadosGerenciais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCliente);
            this.Controls.Add(this.lblFuncionário);
            this.Controls.Add(this.pbFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCliente)).EndInit();
            this.gbDadosGerenciais.ResumeLayout(false);
            this.gbDadosGerenciais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Label lblFuncionário;
        private System.Windows.Forms.PictureBox pbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDadosGerenciais;
        private System.Windows.Forms.Label lblTotalFuncionários;
        public System.Windows.Forms.Label lblTotalFunc;
    }
}