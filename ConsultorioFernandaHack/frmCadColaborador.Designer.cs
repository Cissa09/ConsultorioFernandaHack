namespace ConsultorioFernandaHack
{
    partial class frmCadColaborador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadColaborador));
            this.gbDadosColaborador = new System.Windows.Forms.GroupBox();
            this.txtDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtComissao = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnBandeiraAzul = new System.Windows.Forms.Button();
            this.lblComissao = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPaciente = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRGPaciente = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbDadosColaborador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDadosColaborador
            // 
            this.gbDadosColaborador.Controls.Add(this.txtDtNascimento);
            this.gbDadosColaborador.Controls.Add(this.lblNascimento);
            this.gbDadosColaborador.Controls.Add(this.txtComissao);
            this.gbDadosColaborador.Controls.Add(this.txtCPF);
            this.gbDadosColaborador.Controls.Add(this.btnBandeiraAzul);
            this.gbDadosColaborador.Controls.Add(this.lblComissao);
            this.gbDadosColaborador.Controls.Add(this.txtEmail);
            this.gbDadosColaborador.Controls.Add(this.lblEmailPaciente);
            this.gbDadosColaborador.Controls.Add(this.txtRG);
            this.gbDadosColaborador.Controls.Add(this.txtCodPaciente);
            this.gbDadosColaborador.Controls.Add(this.lblCodigo);
            this.gbDadosColaborador.Controls.Add(this.lblRGPaciente);
            this.gbDadosColaborador.Controls.Add(this.lblCpfPaciente);
            this.gbDadosColaborador.Controls.Add(this.txtCelular);
            this.gbDadosColaborador.Controls.Add(this.txtNome);
            this.gbDadosColaborador.Controls.Add(this.lblNomePaciente);
            this.gbDadosColaborador.Controls.Add(this.lblCelular);
            this.gbDadosColaborador.Controls.Add(this.lblTelefones);
            this.gbDadosColaborador.Controls.Add(this.txtTelefone1);
            this.gbDadosColaborador.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbDadosColaborador.Location = new System.Drawing.Point(12, 15);
            this.gbDadosColaborador.Name = "gbDadosColaborador";
            this.gbDadosColaborador.Size = new System.Drawing.Size(558, 184);
            this.gbDadosColaborador.TabIndex = 1;
            this.gbDadosColaborador.TabStop = false;
            this.gbDadosColaborador.Text = "Dados do Colaborador";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Checked = false;
            this.txtDtNascimento.CustomFormat = "dd/MM/yyyy";
            this.txtDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtNascimento.Location = new System.Drawing.Point(419, 17);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.ShowCheckBox = true;
            this.txtDtNascimento.Size = new System.Drawing.Size(118, 22);
            this.txtDtNascimento.TabIndex = 3;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblNascimento.Location = new System.Drawing.Point(340, 20);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(75, 14);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Data nasc:";
            // 
            // txtComissao
            // 
            this.txtComissao.BackColor = System.Drawing.Color.White;
            this.txtComissao.ForeColor = System.Drawing.Color.Black;
            this.txtComissao.Location = new System.Drawing.Point(92, 151);
            this.txtComissao.MaxLength = 20;
            this.txtComissao.Name = "txtComissao";
            this.txtComissao.Size = new System.Drawing.Size(118, 22);
            this.txtComissao.TabIndex = 17;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(419, 96);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(118, 22);
            this.txtCPF.TabIndex = 13;
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
            // lblComissao
            // 
            this.lblComissao.AutoSize = true;
            this.lblComissao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblComissao.ForeColor = System.Drawing.Color.Black;
            this.lblComissao.Location = new System.Drawing.Point(5, 154);
            this.lblComissao.Name = "lblComissao";
            this.lblComissao.Size = new System.Drawing.Size(79, 14);
            this.lblComissao.TabIndex = 16;
            this.lblComissao.Text = "Percentual:";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(92, 124);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // lblEmailPaciente
            // 
            this.lblEmailPaciente.AutoSize = true;
            this.lblEmailPaciente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblEmailPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblEmailPaciente.Location = new System.Drawing.Point(6, 127);
            this.lblEmailPaciente.Name = "lblEmailPaciente";
            this.lblEmailPaciente.Size = new System.Drawing.Size(50, 14);
            this.lblEmailPaciente.TabIndex = 14;
            this.lblEmailPaciente.Text = "E-mail:";
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.White;
            this.txtRG.ForeColor = System.Drawing.Color.Black;
            this.txtRG.Location = new System.Drawing.Point(92, 97);
            this.txtRG.MaxLength = 20;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(242, 22);
            this.txtRG.TabIndex = 11;
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.ForeColor = System.Drawing.Color.Black;
            this.txtCodPaciente.Location = new System.Drawing.Point(92, 17);
            this.txtCodPaciente.MaxLength = 60;
            this.txtCodPaciente.Name = "txtCodPaciente";
            this.txtCodPaciente.ReadOnly = true;
            this.txtCodPaciente.Size = new System.Drawing.Size(45, 22);
            this.txtCodPaciente.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(6, 21);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 14);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código:";
            // 
            // lblRGPaciente
            // 
            this.lblRGPaciente.AutoSize = true;
            this.lblRGPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblRGPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblRGPaciente.Location = new System.Drawing.Point(6, 100);
            this.lblRGPaciente.Name = "lblRGPaciente";
            this.lblRGPaciente.Size = new System.Drawing.Size(29, 14);
            this.lblRGPaciente.TabIndex = 10;
            this.lblRGPaciente.Text = "RG:";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCpfPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblCpfPaciente.Location = new System.Drawing.Point(340, 99);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(36, 14);
            this.lblCpfPaciente.TabIndex = 12;
            this.lblCpfPaciente.Text = "CPF:";
            // 
            // txtCelular
            // 
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(419, 68);
            this.txtCelular.Mask = "(99) 0000-00000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(118, 22);
            this.txtCelular.TabIndex = 9;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(92, 42);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(445, 22);
            this.txtNome.TabIndex = 5;
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblNomePaciente.ForeColor = System.Drawing.Color.Black;
            this.lblNomePaciente.Location = new System.Drawing.Point(5, 45);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(48, 14);
            this.lblNomePaciente.TabIndex = 4;
            this.lblNomePaciente.Text = "Nome:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblCelular.ForeColor = System.Drawing.Color.Black;
            this.lblCelular.Location = new System.Drawing.Point(340, 72);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 14);
            this.lblCelular.TabIndex = 8;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblTelefones.ForeColor = System.Drawing.Color.Black;
            this.lblTelefones.Location = new System.Drawing.Point(5, 73);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(72, 14);
            this.lblTelefones.TabIndex = 6;
            this.lblTelefones.Text = "Telefones:";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone1.Location = new System.Drawing.Point(92, 70);
            this.txtTelefone1.Mask = "(99) 0000-00000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(118, 22);
            this.txtTelefone1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-12, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 62);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(522, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "SALVAR";
            // 
            // btnSalvarPaciente
            // 
            this.btnSalvarPaciente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnSalvarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarPaciente.BackgroundImage")));
            this.btnSalvarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarPaciente.FlatAppearance.BorderSize = 0;
            this.btnSalvarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarPaciente.Location = new System.Drawing.Point(519, 215);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(39, 42);
            this.btnSalvarPaciente.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnSalvarPaciente, "Salvar Colaborador");
            this.btnSalvarPaciente.UseVisualStyleBackColor = false;
            this.btnSalvarPaciente.Click += new System.EventHandler(this.btnSalvarPaciente_Click);
            // 
            // frmCadColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 275);
            this.Controls.Add(this.btnSalvarPaciente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbDadosColaborador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE COLABORADOR";
            this.Load += new System.EventHandler(this.frmCadColaborador_Load);
            this.gbDadosColaborador.ResumeLayout(false);
            this.gbDadosColaborador.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDadosColaborador;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnBandeiraAzul;
        private System.Windows.Forms.Label lblComissao;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailPaciente;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRGPaciente;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefones;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.TextBox txtComissao;
        private System.Windows.Forms.DateTimePicker txtDtNascimento;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}