namespace ConsultorioFernandaHack
{
    partial class frmCadSessao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadSessao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarSessao = new System.Windows.Forms.Button();
            this.gbDadosAvaliacao = new System.Windows.Forms.GroupBox();
            this.cbPago = new System.Windows.Forms.CheckBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.btnBandeiraAzul = new System.Windows.Forms.Button();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.dtSessao = new System.Windows.Forms.DateTimePicker();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.toolTipSessao = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.gbDadosAvaliacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnSalvarSessao);
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 62);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(339, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "SALVAR";
            // 
            // btnSalvarSessao
            // 
            this.btnSalvarSessao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarSessao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnSalvarSessao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarSessao.BackgroundImage")));
            this.btnSalvarSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarSessao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarSessao.FlatAppearance.BorderSize = 0;
            this.btnSalvarSessao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvarSessao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarSessao.Location = new System.Drawing.Point(348, 1);
            this.btnSalvarSessao.Name = "btnSalvarSessao";
            this.btnSalvarSessao.Size = new System.Drawing.Size(39, 42);
            this.btnSalvarSessao.TabIndex = 10;
            this.toolTipSessao.SetToolTip(this.btnSalvarSessao, "Salvar Sessão");
            this.btnSalvarSessao.UseVisualStyleBackColor = false;
            this.btnSalvarSessao.Click += new System.EventHandler(this.btnSalvarSessao_Click);
            // 
            // gbDadosAvaliacao
            // 
            this.gbDadosAvaliacao.Controls.Add(this.cbPago);
            this.gbDadosAvaliacao.Controls.Add(this.txtValor);
            this.gbDadosAvaliacao.Controls.Add(this.lblValor);
            this.gbDadosAvaliacao.Controls.Add(this.cmbColaborador);
            this.gbDadosAvaliacao.Controls.Add(this.label1);
            this.gbDadosAvaliacao.Controls.Add(this.cmbPaciente);
            this.gbDadosAvaliacao.Controls.Add(this.btnBandeiraAzul);
            this.gbDadosAvaliacao.Controls.Add(this.lblPaciente);
            this.gbDadosAvaliacao.Controls.Add(this.dtSessao);
            this.gbDadosAvaliacao.Controls.Add(this.lblDtCadastro);
            this.gbDadosAvaliacao.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbDadosAvaliacao.Location = new System.Drawing.Point(11, 8);
            this.gbDadosAvaliacao.Name = "gbDadosAvaliacao";
            this.gbDadosAvaliacao.Size = new System.Drawing.Size(380, 138);
            this.gbDadosAvaliacao.TabIndex = 1;
            this.gbDadosAvaliacao.TabStop = false;
            this.gbDadosAvaliacao.Text = "Sessão";
            // 
            // cbPago
            // 
            this.cbPago.AutoSize = true;
            this.cbPago.Location = new System.Drawing.Point(302, 20);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(58, 18);
            this.cbPago.TabIndex = 3;
            this.cbPago.Text = "Pago";
            this.cbPago.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(110, 100);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 22);
            this.txtValor.TabIndex = 9;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(16, 105);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(73, 14);
            this.lblValor.TabIndex = 8;
            this.lblValor.Text = "Valor (R$):";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.DisplayMember = "Nome";
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(110, 73);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(250, 22);
            this.cmbColaborador.TabIndex = 7;
            this.cmbColaborador.ValueMember = "IDColaborador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Colaborador:";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DisplayMember = "Nome";
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(110, 45);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(250, 22);
            this.cmbPaciente.TabIndex = 5;
            this.cmbPaciente.ValueMember = "IDPaciente";
            // 
            // btnBandeiraAzul
            // 
            this.btnBandeiraAzul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBandeiraAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBandeiraAzul.FlatAppearance.BorderSize = 0;
            this.btnBandeiraAzul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBandeiraAzul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBandeiraAzul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBandeiraAzul.Location = new System.Drawing.Point(715, 134);
            this.btnBandeiraAzul.Name = "btnBandeiraAzul";
            this.btnBandeiraAzul.Size = new System.Drawing.Size(23, 32);
            this.btnBandeiraAzul.TabIndex = 30;
            this.btnBandeiraAzul.TabStop = false;
            this.btnBandeiraAzul.UseVisualStyleBackColor = true;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblPaciente.Location = new System.Drawing.Point(15, 48);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(66, 14);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Paciente:";
            // 
            // dtSessao
            // 
            this.dtSessao.CustomFormat = "dd/MM/yyyy";
            this.dtSessao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSessao.Location = new System.Drawing.Point(110, 18);
            this.dtSessao.Name = "dtSessao";
            this.dtSessao.Size = new System.Drawing.Size(121, 22);
            this.dtSessao.TabIndex = 2;
            this.dtSessao.Value = new System.DateTime(2010, 1, 12, 0, 0, 0, 0);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblDtCadastro.Location = new System.Drawing.Point(15, 21);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(42, 14);
            this.lblDtCadastro.TabIndex = 2;
            this.lblDtCadastro.Text = "Data:";
            // 
            // frmCadSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(398, 215);
            this.Controls.Add(this.gbDadosAvaliacao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE SESSÃO";
            this.Load += new System.EventHandler(this.frmCadSessao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDadosAvaliacao.ResumeLayout(false);
            this.gbDadosAvaliacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarSessao;
        private System.Windows.Forms.GroupBox gbDadosAvaliacao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPaciente;
        private System.Windows.Forms.Button btnBandeiraAzul;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.DateTimePicker dtSessao;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.ToolTip toolTipSessao;
        private System.Windows.Forms.CheckBox cbPago;
    }
}