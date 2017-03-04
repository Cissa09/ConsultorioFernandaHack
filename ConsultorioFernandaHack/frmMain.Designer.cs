namespace ConsultorioFernandaHack
{
    partial class frmMain
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
            System.Windows.Forms.MenuStrip MenuAdministrativo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.MenuPetShop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgendaSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.administrativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLocColaboradores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLocPacientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuLocSessao = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuRptComissoes = new System.Windows.Forms.ToolStripMenuItem();
            this.evoluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnSessao = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnColaborador = new System.Windows.Forms.Button();
            this.MainMenuRptRecibo = new System.Windows.Forms.ToolStripMenuItem();
            MenuAdministrativo = new System.Windows.Forms.MenuStrip();
            MenuAdministrativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAdministrativo
            // 
            MenuAdministrativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            MenuAdministrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            MenuAdministrativo.GripMargin = new System.Windows.Forms.Padding(2, 2, 10, 2);
            MenuAdministrativo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPetShop,
            this.administrativoToolStripMenuItem1,
            this.MenuRelatorio});
            MenuAdministrativo.Location = new System.Drawing.Point(0, 0);
            MenuAdministrativo.Name = "MenuAdministrativo";
            MenuAdministrativo.Size = new System.Drawing.Size(1016, 24);
            MenuAdministrativo.TabIndex = 11;
            MenuAdministrativo.Text = "menuStrip1";
            // 
            // MenuPetShop
            // 
            this.MenuPetShop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.MenuPetShop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrar,
            this.MenuAgendaSessao,
            this.toolStripSeparator3,
            this.MenuSair});
            this.MenuPetShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPetShop.ForeColor = System.Drawing.Color.White;
            this.MenuPetShop.Name = "MenuPetShop";
            this.MenuPetShop.Size = new System.Drawing.Size(98, 20);
            this.MenuPetShop.Text = "PRINCIPAL";
            // 
            // MenuCadastrar
            // 
            this.MenuCadastrar.BackColor = System.Drawing.Color.White;
            this.MenuCadastrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPaciente,
            this.MenuColaborador,
            this.MenuSessao});
            this.MenuCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuCadastrar.Name = "MenuCadastrar";
            this.MenuCadastrar.Size = new System.Drawing.Size(178, 22);
            this.MenuCadastrar.Text = "Cadastrar";
            // 
            // MenuPaciente
            // 
            this.MenuPaciente.BackColor = System.Drawing.Color.White;
            this.MenuPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPaciente.Name = "MenuPaciente";
            this.MenuPaciente.Size = new System.Drawing.Size(167, 22);
            this.MenuPaciente.Text = "Paciente";
            this.MenuPaciente.Click += new System.EventHandler(this.MenuPaciente_Click);
            // 
            // MenuColaborador
            // 
            this.MenuColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuColaborador.Name = "MenuColaborador";
            this.MenuColaborador.Size = new System.Drawing.Size(167, 22);
            this.MenuColaborador.Text = "Colaboradores";
            this.MenuColaborador.Click += new System.EventHandler(this.MenuColaborador_Click);
            // 
            // MenuSessao
            // 
            this.MenuSessao.Name = "MenuSessao";
            this.MenuSessao.Size = new System.Drawing.Size(167, 22);
            this.MenuSessao.Text = "Sessão";
            this.MenuSessao.Click += new System.EventHandler(this.MenuSessao_Click);
            // 
            // MenuAgendaSessao
            // 
            this.MenuAgendaSessao.BackColor = System.Drawing.Color.White;
            this.MenuAgendaSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuAgendaSessao.Name = "MenuAgendaSessao";
            this.MenuAgendaSessao.Size = new System.Drawing.Size(178, 22);
            this.MenuAgendaSessao.Text = "Agendar Sessão";
            this.MenuAgendaSessao.Visible = false;
            this.MenuAgendaSessao.Click += new System.EventHandler(this.MenuAgendaSessao_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // MenuSair
            // 
            this.MenuSair.BackColor = System.Drawing.Color.White;
            this.MenuSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(178, 22);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // administrativoToolStripMenuItem1
            // 
            this.administrativoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.administrativoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuLocColaboradores,
            this.MenuLocPacientes,
            this.MenuLocSessao});
            this.administrativoToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrativoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.administrativoToolStripMenuItem1.Name = "administrativoToolStripMenuItem1";
            this.administrativoToolStripMenuItem1.Size = new System.Drawing.Size(148, 20);
            this.administrativoToolStripMenuItem1.Text = "ADMINISTRATIVO";
            // 
            // MenuLocColaboradores
            // 
            this.MenuLocColaboradores.BackColor = System.Drawing.Color.White;
            this.MenuLocColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLocColaboradores.Name = "MenuLocColaboradores";
            this.MenuLocColaboradores.Size = new System.Drawing.Size(167, 22);
            this.MenuLocColaboradores.Text = "Colaboradores";
            this.MenuLocColaboradores.Click += new System.EventHandler(this.MenuFuncionarios_Click);
            // 
            // MenuLocPacientes
            // 
            this.MenuLocPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLocPacientes.Name = "MenuLocPacientes";
            this.MenuLocPacientes.Size = new System.Drawing.Size(167, 22);
            this.MenuLocPacientes.Text = "Pacientes";
            this.MenuLocPacientes.Click += new System.EventHandler(this.MenuLocPacientes_Click);
            // 
            // MenuLocSessao
            // 
            this.MenuLocSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuLocSessao.Name = "MenuLocSessao";
            this.MenuLocSessao.Size = new System.Drawing.Size(167, 22);
            this.MenuLocSessao.Text = "Sessão";
            this.MenuLocSessao.Click += new System.EventHandler(this.MenuLocSessao_Click);
            // 
            // MenuRelatorio
            // 
            this.MenuRelatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuRptComissoes,
            this.evoluToolStripMenuItem,
            this.MainMenuRptRecibo});
            this.MenuRelatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuRelatorio.ForeColor = System.Drawing.Color.White;
            this.MenuRelatorio.Name = "MenuRelatorio";
            this.MenuRelatorio.Size = new System.Drawing.Size(116, 20);
            this.MenuRelatorio.Text = "RELATÓRIOS";
            // 
            // MainMenuRptComissoes
            // 
            this.MainMenuRptComissoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuRptComissoes.Name = "MainMenuRptComissoes";
            this.MainMenuRptComissoes.Size = new System.Drawing.Size(152, 22);
            this.MainMenuRptComissoes.Text = "Comissões ";
            this.MainMenuRptComissoes.Click += new System.EventHandler(this.MainMenuRptComissoes_Click);
            // 
            // evoluToolStripMenuItem
            // 
            this.evoluToolStripMenuItem.Name = "evoluToolStripMenuItem";
            this.evoluToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.evoluToolStripMenuItem.Text = "Evolução";
            this.evoluToolStripMenuItem.Visible = false;
            // 
            // btnPacientes
            // 
            this.btnPacientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPacientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPacientes.BackgroundImage")));
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnPacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Location = new System.Drawing.Point(337, 438);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(63, 72);
            this.btnPacientes.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnPacientes, "Clique para adicionar um paciente\r\n");
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnSessao
            // 
            this.btnSessao.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSessao.BackColor = System.Drawing.Color.Transparent;
            this.btnSessao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSessao.BackgroundImage")));
            this.btnSessao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSessao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSessao.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSessao.FlatAppearance.BorderSize = 0;
            this.btnSessao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSessao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessao.Location = new System.Drawing.Point(481, 438);
            this.btnSessao.Name = "btnSessao";
            this.btnSessao.Size = new System.Drawing.Size(63, 72);
            this.btnSessao.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnSessao, "Clique para criar uma sessão");
            this.btnSessao.UseVisualStyleBackColor = false;
            this.btnSessao.Click += new System.EventHandler(this.btnSessao_Click);
            // 
            // btnColaborador
            // 
            this.btnColaborador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnColaborador.BackColor = System.Drawing.Color.Transparent;
            this.btnColaborador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColaborador.BackgroundImage")));
            this.btnColaborador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColaborador.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnColaborador.FlatAppearance.BorderSize = 0;
            this.btnColaborador.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnColaborador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColaborador.Location = new System.Drawing.Point(619, 438);
            this.btnColaborador.Name = "btnColaborador";
            this.btnColaborador.Size = new System.Drawing.Size(63, 72);
            this.btnColaborador.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnColaborador, "Clique para adicionar um colaborador");
            this.btnColaborador.UseVisualStyleBackColor = false;
            this.btnColaborador.Click += new System.EventHandler(this.btnColaborador_Click);
            // 
            // MainMenuRptRecibo
            // 
            this.MainMenuRptRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuRptRecibo.Name = "MainMenuRptRecibo";
            this.MainMenuRptRecibo.Size = new System.Drawing.Size(152, 22);
            this.MainMenuRptRecibo.Text = "Recibo";
            this.MainMenuRptRecibo.Click += new System.EventHandler(this.MainMenuRptRecibo_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1016, 600);
            this.Controls.Add(this.btnColaborador);
            this.Controls.Add(this.btnSessao);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(MenuAdministrativo);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = MenuAdministrativo;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Fernanda Hackeenhar ";
            this.TransparencyKey = System.Drawing.Color.Lime;
            MenuAdministrativo.ResumeLayout(false);
            MenuAdministrativo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem MenuPetShop;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem MenuPaciente;
        private System.Windows.Forms.ToolStripMenuItem MenuAgendaSessao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem administrativoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuLocColaboradores;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorio;
        public System.Windows.Forms.Button btnPacientes;
        public System.Windows.Forms.Button btnSessao;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem MainMenuRptComissoes;
        private System.Windows.Forms.ToolStripMenuItem evoluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuColaborador;
        public System.Windows.Forms.Button btnColaborador;
        private System.Windows.Forms.ToolStripMenuItem MenuSessao;
        private System.Windows.Forms.ToolStripMenuItem MenuLocPacientes;
        private System.Windows.Forms.ToolStripMenuItem MenuLocSessao;
        private System.Windows.Forms.ToolStripMenuItem MainMenuRptRecibo;
    }
}

