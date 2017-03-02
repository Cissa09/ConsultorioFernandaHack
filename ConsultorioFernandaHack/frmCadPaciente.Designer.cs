namespace ConsultorioFernandaHack
{
    partial class frmCadPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadPaciente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.tbPaciente = new System.Windows.Forms.TabControl();
            this.tbDados = new System.Windows.Forms.TabPage();
            this.gbDadosPaciente = new System.Windows.Forms.GroupBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnBandeiraAzul = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObsPaciente = new System.Windows.Forms.Label();
            this.txtDtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmailPaciente = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtCodPaciente = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblRGPaciente = new System.Windows.Forms.Label();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblTelefones = new System.Windows.Forms.Label();
            this.txtTelefone1 = new System.Windows.Forms.MaskedTextBox();
            this.tbEvolucao = new System.Windows.Forms.TabPage();
            this.GEvolucao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuEvolucao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarEvolucao = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcluirEvolucao = new System.Windows.Forms.ToolStripMenuItem();
            this.tbAvaliacao = new System.Windows.Forms.TabPage();
            this.GAvaliacao = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuAvaliacao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuNovaAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.EditarAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcluirAvaliacao = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tbPaciente.SuspendLayout();
            this.tbDados.SuspendLayout();
            this.gbDadosPaciente.SuspendLayout();
            this.tbEvolucao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GEvolucao)).BeginInit();
            this.ctxMenuEvolucao.SuspendLayout();
            this.tbAvaliacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GAvaliacao)).BeginInit();
            this.ctxMenuAvaliacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-12, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(606, 62);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(529, 44);
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
            this.btnSalvarPaciente.Location = new System.Drawing.Point(525, 315);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(39, 42);
            this.btnSalvarPaciente.TabIndex = 22;
            this.btnSalvarPaciente.UseVisualStyleBackColor = false;
            this.btnSalvarPaciente.Click += new System.EventHandler(this.btnSalvarPaciente_Click);
            // 
            // tbPaciente
            // 
            this.tbPaciente.Controls.Add(this.tbDados);
            this.tbPaciente.Controls.Add(this.tbEvolucao);
            this.tbPaciente.Controls.Add(this.tbAvaliacao);
            this.tbPaciente.Location = new System.Drawing.Point(12, 12);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.SelectedIndex = 0;
            this.tbPaciente.Size = new System.Drawing.Size(572, 282);
            this.tbPaciente.TabIndex = 31;
            this.tbPaciente.SelectedIndexChanged += new System.EventHandler(this.tbPaciente_SelectedIndexChanged);
            // 
            // tbDados
            // 
            this.tbDados.Controls.Add(this.gbDadosPaciente);
            this.tbDados.Location = new System.Drawing.Point(4, 22);
            this.tbDados.Name = "tbDados";
            this.tbDados.Padding = new System.Windows.Forms.Padding(3);
            this.tbDados.Size = new System.Drawing.Size(564, 256);
            this.tbDados.TabIndex = 0;
            this.tbDados.Text = "Dados:";
            this.tbDados.UseVisualStyleBackColor = true;
            // 
            // gbDadosPaciente
            // 
            this.gbDadosPaciente.Controls.Add(this.txtCPF);
            this.gbDadosPaciente.Controls.Add(this.btnBandeiraAzul);
            this.gbDadosPaciente.Controls.Add(this.txtObservacao);
            this.gbDadosPaciente.Controls.Add(this.lblObsPaciente);
            this.gbDadosPaciente.Controls.Add(this.txtDtNascimento);
            this.gbDadosPaciente.Controls.Add(this.txtEmail);
            this.gbDadosPaciente.Controls.Add(this.lblEmailPaciente);
            this.gbDadosPaciente.Controls.Add(this.lblNascimento);
            this.gbDadosPaciente.Controls.Add(this.dtDesde);
            this.gbDadosPaciente.Controls.Add(this.txtRG);
            this.gbDadosPaciente.Controls.Add(this.cmbSexo);
            this.gbDadosPaciente.Controls.Add(this.lblSexo);
            this.gbDadosPaciente.Controls.Add(this.txtCodPaciente);
            this.gbDadosPaciente.Controls.Add(this.lblCodigo);
            this.gbDadosPaciente.Controls.Add(this.lblRGPaciente);
            this.gbDadosPaciente.Controls.Add(this.lblCpfPaciente);
            this.gbDadosPaciente.Controls.Add(this.lblDtCadastro);
            this.gbDadosPaciente.Controls.Add(this.txtCelular);
            this.gbDadosPaciente.Controls.Add(this.txtNome);
            this.gbDadosPaciente.Controls.Add(this.lblNomePaciente);
            this.gbDadosPaciente.Controls.Add(this.lblCelular);
            this.gbDadosPaciente.Controls.Add(this.lblTelefones);
            this.gbDadosPaciente.Controls.Add(this.txtTelefone1);
            this.gbDadosPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbDadosPaciente.Location = new System.Drawing.Point(9, 8);
            this.gbDadosPaciente.Name = "gbDadosPaciente";
            this.gbDadosPaciente.Size = new System.Drawing.Size(547, 241);
            this.gbDadosPaciente.TabIndex = 3;
            this.gbDadosPaciente.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.ForeColor = System.Drawing.Color.Black;
            this.txtCPF.Location = new System.Drawing.Point(419, 122);
            this.txtCPF.MaxLength = 20;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(118, 22);
            this.txtCPF.TabIndex = 17;
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
            // txtObservacao
            // 
            this.txtObservacao.ForeColor = System.Drawing.Color.Black;
            this.txtObservacao.Location = new System.Drawing.Point(92, 177);
            this.txtObservacao.MaxLength = 400;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(445, 56);
            this.txtObservacao.TabIndex = 21;
            // 
            // lblObsPaciente
            // 
            this.lblObsPaciente.AutoSize = true;
            this.lblObsPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblObsPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblObsPaciente.Location = new System.Drawing.Point(5, 180);
            this.lblObsPaciente.Name = "lblObsPaciente";
            this.lblObsPaciente.Size = new System.Drawing.Size(87, 14);
            this.lblObsPaciente.TabIndex = 20;
            this.lblObsPaciente.Text = "Observação:";
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Checked = false;
            this.txtDtNascimento.CustomFormat = "dd/MM/yyyy";
            this.txtDtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDtNascimento.Location = new System.Drawing.Point(419, 68);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.ShowCheckBox = true;
            this.txtDtNascimento.Size = new System.Drawing.Size(118, 22);
            this.txtDtNascimento.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(92, 150);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(445, 22);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmailPaciente
            // 
            this.lblEmailPaciente.AutoSize = true;
            this.lblEmailPaciente.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblEmailPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblEmailPaciente.Location = new System.Drawing.Point(6, 153);
            this.lblEmailPaciente.Name = "lblEmailPaciente";
            this.lblEmailPaciente.Size = new System.Drawing.Size(50, 14);
            this.lblEmailPaciente.TabIndex = 18;
            this.lblEmailPaciente.Text = "E-mail:";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblNascimento.Location = new System.Drawing.Point(340, 71);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(75, 14);
            this.lblNascimento.TabIndex = 8;
            this.lblNascimento.Text = "Data nasc:";
            // 
            // dtDesde
            // 
            this.dtDesde.CustomFormat = "dd/MM/yyyy";
            this.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDesde.Location = new System.Drawing.Point(416, 18);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(121, 22);
            this.dtDesde.TabIndex = 3;
            this.dtDesde.Value = new System.DateTime(2010, 1, 12, 0, 0, 0, 0);
            // 
            // txtRG
            // 
            this.txtRG.BackColor = System.Drawing.Color.White;
            this.txtRG.ForeColor = System.Drawing.Color.Black;
            this.txtRG.Location = new System.Drawing.Point(92, 123);
            this.txtRG.MaxLength = 20;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(242, 22);
            this.txtRG.TabIndex = 15;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Selecione:",
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(92, 68);
            this.cmbSexo.MaxLength = 3;
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(242, 22);
            this.cmbSexo.TabIndex = 7;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline);
            this.lblSexo.ForeColor = System.Drawing.Color.Black;
            this.lblSexo.Location = new System.Drawing.Point(6, 71);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(43, 14);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtCodPaciente
            // 
            this.txtCodPaciente.Enabled = false;
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
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblRGPaciente
            // 
            this.lblRGPaciente.AutoSize = true;
            this.lblRGPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblRGPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblRGPaciente.Location = new System.Drawing.Point(6, 126);
            this.lblRGPaciente.Name = "lblRGPaciente";
            this.lblRGPaciente.Size = new System.Drawing.Size(29, 14);
            this.lblRGPaciente.TabIndex = 14;
            this.lblRGPaciente.Text = "RG:";
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblCpfPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblCpfPaciente.Location = new System.Drawing.Point(340, 125);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(36, 14);
            this.lblCpfPaciente.TabIndex = 16;
            this.lblCpfPaciente.Text = "CPF:";
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblDtCadastro.Location = new System.Drawing.Point(294, 21);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(99, 14);
            this.lblDtCadastro.TabIndex = 2;
            this.lblDtCadastro.Text = "Cliente desde:";
            // 
            // txtCelular
            // 
            this.txtCelular.ForeColor = System.Drawing.Color.Black;
            this.txtCelular.Location = new System.Drawing.Point(419, 94);
            this.txtCelular.Mask = "(99) 0000-00000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(118, 22);
            this.txtCelular.TabIndex = 13;
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
            this.lblCelular.Location = new System.Drawing.Point(340, 98);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(56, 14);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "Celular:";
            // 
            // lblTelefones
            // 
            this.lblTelefones.AutoSize = true;
            this.lblTelefones.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblTelefones.ForeColor = System.Drawing.Color.Black;
            this.lblTelefones.Location = new System.Drawing.Point(5, 99);
            this.lblTelefones.Name = "lblTelefones";
            this.lblTelefones.Size = new System.Drawing.Size(72, 14);
            this.lblTelefones.TabIndex = 10;
            this.lblTelefones.Text = "Telefones:";
            // 
            // txtTelefone1
            // 
            this.txtTelefone1.ForeColor = System.Drawing.Color.Black;
            this.txtTelefone1.Location = new System.Drawing.Point(92, 96);
            this.txtTelefone1.Mask = "(99) 0000-00000";
            this.txtTelefone1.Name = "txtTelefone1";
            this.txtTelefone1.Size = new System.Drawing.Size(118, 22);
            this.txtTelefone1.TabIndex = 11;
            // 
            // tbEvolucao
            // 
            this.tbEvolucao.Controls.Add(this.GEvolucao);
            this.tbEvolucao.Location = new System.Drawing.Point(4, 22);
            this.tbEvolucao.Name = "tbEvolucao";
            this.tbEvolucao.Padding = new System.Windows.Forms.Padding(3);
            this.tbEvolucao.Size = new System.Drawing.Size(564, 256);
            this.tbEvolucao.TabIndex = 1;
            this.tbEvolucao.Text = "Evolução:";
            this.tbEvolucao.UseVisualStyleBackColor = true;
            // 
            // GEvolucao
            // 
            this.GEvolucao.AllowUserToAddRows = false;
            this.GEvolucao.AllowUserToDeleteRows = false;
            this.GEvolucao.AllowUserToOrderColumns = true;
            this.GEvolucao.AllowUserToResizeRows = false;
            this.GEvolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GEvolucao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GEvolucao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GEvolucao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GEvolucao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GEvolucao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GEvolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GEvolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.GEvolucao.ContextMenuStrip = this.ctxMenuEvolucao;
            this.GEvolucao.Location = new System.Drawing.Point(7, 6);
            this.GEvolucao.MultiSelect = false;
            this.GEvolucao.Name = "GEvolucao";
            this.GEvolucao.ReadOnly = true;
            this.GEvolucao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GEvolucao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GEvolucao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GEvolucao.ShowCellToolTips = false;
            this.GEvolucao.Size = new System.Drawing.Size(550, 244);
            this.GEvolucao.TabIndex = 24;
            this.GEvolucao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GEvolucao_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDEvolucao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DataEvolucao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // ctxMenuEvolucao
            // 
            this.ctxMenuEvolucao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovo,
            this.EditarEvolucao,
            this.ExcluirEvolucao});
            this.ctxMenuEvolucao.Name = "ctxEspecie";
            this.ctxMenuEvolucao.Size = new System.Drawing.Size(153, 92);
            // 
            // MenuNovo
            // 
            this.MenuNovo.Name = "MenuNovo";
            this.MenuNovo.Size = new System.Drawing.Size(152, 22);
            this.MenuNovo.Text = "Novo ";
            this.MenuNovo.ToolTipText = "Cadastrar evolução";
            this.MenuNovo.Click += new System.EventHandler(this.MenuNovo_Click);
            // 
            // EditarEvolucao
            // 
            this.EditarEvolucao.Name = "EditarEvolucao";
            this.EditarEvolucao.Size = new System.Drawing.Size(152, 22);
            this.EditarEvolucao.Text = "Editar";
            this.EditarEvolucao.ToolTipText = "Editar evolução selecionada";
            this.EditarEvolucao.Click += new System.EventHandler(this.EditarEvolucao_Click);
            // 
            // ExcluirEvolucao
            // 
            this.ExcluirEvolucao.Name = "ExcluirEvolucao";
            this.ExcluirEvolucao.Size = new System.Drawing.Size(152, 22);
            this.ExcluirEvolucao.Text = "Excluir ";
            this.ExcluirEvolucao.ToolTipText = "Excluir evolução selecionada";
            this.ExcluirEvolucao.Visible = false;
            this.ExcluirEvolucao.Click += new System.EventHandler(this.ExcluirEvolucao_Click);
            // 
            // tbAvaliacao
            // 
            this.tbAvaliacao.Controls.Add(this.GAvaliacao);
            this.tbAvaliacao.Location = new System.Drawing.Point(4, 22);
            this.tbAvaliacao.Name = "tbAvaliacao";
            this.tbAvaliacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbAvaliacao.Size = new System.Drawing.Size(564, 256);
            this.tbAvaliacao.TabIndex = 2;
            this.tbAvaliacao.Text = "Avaliação:";
            this.tbAvaliacao.UseVisualStyleBackColor = true;
            // 
            // GAvaliacao
            // 
            this.GAvaliacao.AllowUserToAddRows = false;
            this.GAvaliacao.AllowUserToDeleteRows = false;
            this.GAvaliacao.AllowUserToOrderColumns = true;
            this.GAvaliacao.AllowUserToResizeRows = false;
            this.GAvaliacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GAvaliacao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GAvaliacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GAvaliacao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GAvaliacao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GAvaliacao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GAvaliacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GAvaliacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Celular,
            this.Nome});
            this.GAvaliacao.ContextMenuStrip = this.ctxMenuAvaliacao;
            this.GAvaliacao.Location = new System.Drawing.Point(7, 6);
            this.GAvaliacao.MultiSelect = false;
            this.GAvaliacao.Name = "GAvaliacao";
            this.GAvaliacao.ReadOnly = true;
            this.GAvaliacao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GAvaliacao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GAvaliacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GAvaliacao.ShowCellToolTips = false;
            this.GAvaliacao.Size = new System.Drawing.Size(550, 244);
            this.GAvaliacao.TabIndex = 23;
            this.GAvaliacao.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GAvaliacao_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IDAvaliacao";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 60;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "DataAvaliacao";
            this.Celular.HeaderText = "Data:";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 130;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Descricao";
            this.Nome.HeaderText = "Descrição:";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 150;
            // 
            // ctxMenuAvaliacao
            // 
            this.ctxMenuAvaliacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovaAvaliacao,
            this.EditarAvaliacao,
            this.ExcluirAvaliacao});
            this.ctxMenuAvaliacao.Name = "ctxEspecie";
            this.ctxMenuAvaliacao.Size = new System.Drawing.Size(153, 92);
            // 
            // MenuNovaAvaliacao
            // 
            this.MenuNovaAvaliacao.Name = "MenuNovaAvaliacao";
            this.MenuNovaAvaliacao.Size = new System.Drawing.Size(152, 22);
            this.MenuNovaAvaliacao.Text = "Novo";
            this.MenuNovaAvaliacao.ToolTipText = "Cadastrar nova avaliação";
            this.MenuNovaAvaliacao.Click += new System.EventHandler(this.MenuNovaAvaliacao_Click);
            // 
            // EditarAvaliacao
            // 
            this.EditarAvaliacao.Name = "EditarAvaliacao";
            this.EditarAvaliacao.Size = new System.Drawing.Size(152, 22);
            this.EditarAvaliacao.Text = "Editar ";
            this.EditarAvaliacao.ToolTipText = "Editar avaliação selecionada";
            this.EditarAvaliacao.Click += new System.EventHandler(this.EditarAvaliacao_Click);
            // 
            // ExcluirAvaliacao
            // 
            this.ExcluirAvaliacao.Name = "ExcluirAvaliacao";
            this.ExcluirAvaliacao.Size = new System.Drawing.Size(152, 22);
            this.ExcluirAvaliacao.Text = "Excluir";
            this.ExcluirAvaliacao.ToolTipText = "Excluir avaliação selecionada";
            this.ExcluirAvaliacao.Visible = false;
            this.ExcluirAvaliacao.Click += new System.EventHandler(this.ExcluirAvaliacao_Click);
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 375);
            this.Controls.Add(this.tbPaciente);
            this.Controls.Add(this.btnSalvarPaciente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE PACIENTE";
            this.Load += new System.EventHandler(this.frmCadPaciente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbPaciente.ResumeLayout(false);
            this.tbDados.ResumeLayout(false);
            this.gbDadosPaciente.ResumeLayout(false);
            this.gbDadosPaciente.PerformLayout();
            this.tbEvolucao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GEvolucao)).EndInit();
            this.ctxMenuEvolucao.ResumeLayout(false);
            this.tbAvaliacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GAvaliacao)).EndInit();
            this.ctxMenuAvaliacao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.TabControl tbPaciente;
        private System.Windows.Forms.TabPage tbDados;
        private System.Windows.Forms.TabPage tbAvaliacao;
        private System.Windows.Forms.TabPage tbEvolucao;
        private System.Windows.Forms.GroupBox gbDadosPaciente;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnBandeiraAzul;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObsPaciente;
        private System.Windows.Forms.DateTimePicker txtDtNascimento;
        public System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmailPaciente;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtCodPaciente;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblRGPaciente;
        private System.Windows.Forms.Label lblCpfPaciente;
        private System.Windows.Forms.Label lblDtCadastro;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblTelefones;
        private System.Windows.Forms.MaskedTextBox txtTelefone1;
        private System.Windows.Forms.DataGridView GEvolucao;
        private System.Windows.Forms.DataGridView GAvaliacao;
        private System.Windows.Forms.ContextMenuStrip ctxMenuEvolucao;
        private System.Windows.Forms.ToolStripMenuItem MenuNovo;
        private System.Windows.Forms.ToolStripMenuItem EditarEvolucao;
        private System.Windows.Forms.ToolStripMenuItem ExcluirEvolucao;
        private System.Windows.Forms.ContextMenuStrip ctxMenuAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem MenuNovaAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem EditarAvaliacao;
        private System.Windows.Forms.ToolStripMenuItem ExcluirAvaliacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}