﻿namespace ConsultorioFernandaHack
{
    partial class frmLocSessao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocSessao));
            this.GSessoes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPago = new System.Windows.Forms.ToolStripMenuItem();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.panelRapida = new System.Windows.Forms.Panel();
            this.cbNaoPagos = new System.Windows.Forms.CheckBox();
            this.lblBusca = new System.Windows.Forms.Label();
            this.txtBuscaRapida = new System.Windows.Forms.TextBox();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.gbPacientes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalDevido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GSessoes)).BeginInit();
            this.ctxMenu.SuspendLayout();
            this.gb.SuspendLayout();
            this.panelRapida.SuspendLayout();
            this.gbPacientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GSessoes
            // 
            this.GSessoes.AllowUserToAddRows = false;
            this.GSessoes.AllowUserToDeleteRows = false;
            this.GSessoes.AllowUserToOrderColumns = true;
            this.GSessoes.AllowUserToResizeRows = false;
            this.GSessoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GSessoes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GSessoes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GSessoes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GSessoes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GSessoes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GSessoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GSessoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Email,
            this.Nome,
            this.Celular,
            this.clValor,
            this.clsPago});
            this.GSessoes.ContextMenuStrip = this.ctxMenu;
            this.GSessoes.Location = new System.Drawing.Point(58, 168);
            this.GSessoes.MultiSelect = false;
            this.GSessoes.Name = "GSessoes";
            this.GSessoes.ReadOnly = true;
            this.GSessoes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.GSessoes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GSessoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GSessoes.ShowCellToolTips = false;
            this.GSessoes.Size = new System.Drawing.Size(841, 294);
            this.GSessoes.TabIndex = 22;
            this.GSessoes.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.GSessoes_DataBindingComplete);
            this.GSessoes.DoubleClick += new System.EventHandler(this.G_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "IDSessao";
            this.Codigo.HeaderText = "Código:";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 60;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "DataSessao";
            this.Email.HeaderText = "Data:";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "NomePaciente";
            this.Nome.HeaderText = "Paciente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 200;
            // 
            // Celular
            // 
            this.Celular.DataPropertyName = "NomeColaborador";
            this.Celular.HeaderText = "Profissional:";
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 130;
            // 
            // clValor
            // 
            this.clValor.DataPropertyName = "Valor";
            this.clValor.HeaderText = "Valor";
            this.clValor.Name = "clValor";
            this.clValor.ReadOnly = true;
            this.clValor.Visible = false;
            // 
            // clsPago
            // 
            this.clsPago.DataPropertyName = "Pago";
            this.clsPago.HeaderText = "Pago";
            this.clsPago.Name = "clsPago";
            this.clsPago.ReadOnly = true;
            this.clsPago.Visible = false;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNovo,
            this.MenuEditar,
            this.MenuExcluir,
            this.MenuPago});
            this.ctxMenu.Name = "ctxEspecie";
            this.ctxMenu.Size = new System.Drawing.Size(109, 92);
            // 
            // MenuNovo
            // 
            this.MenuNovo.Name = "MenuNovo";
            this.MenuNovo.Size = new System.Drawing.Size(108, 22);
            this.MenuNovo.Text = "Novo";
            this.MenuNovo.ToolTipText = "Cadastrar novo cliente (F2)";
            this.MenuNovo.Click += new System.EventHandler(this.MenuNovo_Click);
            // 
            // MenuEditar
            // 
            this.MenuEditar.Name = "MenuEditar";
            this.MenuEditar.Size = new System.Drawing.Size(108, 22);
            this.MenuEditar.Text = "Editar";
            this.MenuEditar.ToolTipText = "Editar cliente selecionado (F3)";
            this.MenuEditar.Click += new System.EventHandler(this.MenuEditar_Click);
            // 
            // MenuExcluir
            // 
            this.MenuExcluir.Name = "MenuExcluir";
            this.MenuExcluir.Size = new System.Drawing.Size(108, 22);
            this.MenuExcluir.Text = "Excluir";
            this.MenuExcluir.ToolTipText = "Excluir cliente selecionado (F4)";
            this.MenuExcluir.Visible = false;
            this.MenuExcluir.Click += new System.EventHandler(this.MenuExcluir_Click);
            // 
            // MenuPago
            // 
            this.MenuPago.Name = "MenuPago";
            this.MenuPago.Size = new System.Drawing.Size(108, 22);
            this.MenuPago.Text = "Pago";
            this.MenuPago.Click += new System.EventHandler(this.MenuPago_Click);
            // 
            // gb
            // 
            this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb.BackColor = System.Drawing.Color.Transparent;
            this.gb.Controls.Add(this.btnLoc);
            this.gb.Controls.Add(this.panelRapida);
            this.gb.Controls.Add(this.btnMais);
            this.gb.Controls.Add(this.btnMenos);
            this.gb.Location = new System.Drawing.Point(18, 22);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(880, 104);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoc.BackgroundImage")));
            this.btnLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLoc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.Location = new System.Drawing.Point(819, 22);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(48, 57);
            this.btnLoc.TabIndex = 18;
            this.btnLoc.TabStop = false;
            this.toolTip1.SetToolTip(this.btnLoc, "Buscar Sessões");
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // panelRapida
            // 
            this.panelRapida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRapida.Controls.Add(this.cbNaoPagos);
            this.panelRapida.Controls.Add(this.lblBusca);
            this.panelRapida.Controls.Add(this.txtBuscaRapida);
            this.panelRapida.Location = new System.Drawing.Point(36, 22);
            this.panelRapida.Name = "panelRapida";
            this.panelRapida.Size = new System.Drawing.Size(763, 62);
            this.panelRapida.TabIndex = 2;
            // 
            // cbNaoPagos
            // 
            this.cbNaoPagos.AutoSize = true;
            this.cbNaoPagos.Location = new System.Drawing.Point(662, 22);
            this.cbNaoPagos.Name = "cbNaoPagos";
            this.cbNaoPagos.Size = new System.Drawing.Size(91, 20);
            this.cbNaoPagos.TabIndex = 18;
            this.cbNaoPagos.Text = "Á receber";
            this.cbNaoPagos.UseVisualStyleBackColor = true;
            // 
            // lblBusca
            // 
            this.lblBusca.AutoSize = true;
            this.lblBusca.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusca.Location = new System.Drawing.Point(4, 22);
            this.lblBusca.Name = "lblBusca";
            this.lblBusca.Size = new System.Drawing.Size(58, 16);
            this.lblBusca.TabIndex = 17;
            this.lblBusca.Text = "BUSCA:";
            // 
            // txtBuscaRapida
            // 
            this.txtBuscaRapida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscaRapida.BackColor = System.Drawing.Color.White;
            this.txtBuscaRapida.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtBuscaRapida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBuscaRapida.Location = new System.Drawing.Point(68, 18);
            this.txtBuscaRapida.MaxLength = 60;
            this.txtBuscaRapida.Name = "txtBuscaRapida";
            this.txtBuscaRapida.Size = new System.Drawing.Size(577, 27);
            this.txtBuscaRapida.TabIndex = 1;
            // 
            // btnMais
            // 
            this.btnMais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMais.FlatAppearance.BorderSize = 0;
            this.btnMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Location = new System.Drawing.Point(25, 42);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(19, 20);
            this.btnMais.TabIndex = 20;
            this.btnMais.TabStop = false;
            this.btnMais.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Location = new System.Drawing.Point(25, 42);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(19, 20);
            this.btnMenos.TabIndex = 20;
            this.btnMenos.TabStop = false;
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // gbPacientes
            // 
            this.gbPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPacientes.BackColor = System.Drawing.Color.White;
            this.gbPacientes.Controls.Add(this.groupBox1);
            this.gbPacientes.Controls.Add(this.gb);
            this.gbPacientes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPacientes.Location = new System.Drawing.Point(21, 12);
            this.gbPacientes.Name = "gbPacientes";
            this.gbPacientes.Size = new System.Drawing.Size(919, 502);
            this.gbPacientes.TabIndex = 23;
            this.gbPacientes.TabStop = false;
            this.gbPacientes.Text = "Sessões";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblTotalDevido);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(18, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 350);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalDevido
            // 
            this.lblTotalDevido.AutoSize = true;
            this.lblTotalDevido.Location = new System.Drawing.Point(685, 327);
            this.lblTotalDevido.Name = "lblTotalDevido";
            this.lblTotalDevido.Size = new System.Drawing.Size(89, 16);
            this.lblTotalDevido.TabIndex = 21;
            this.lblTotalDevido.Text = "ValorTotalR$";
            this.lblTotalDevido.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(25, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(19, 20);
            this.button1.TabIndex = 20;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(25, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 20);
            this.button2.TabIndex = 20;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLocSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 533);
            this.Controls.Add(this.GSessoes);
            this.Controls.Add(this.gbPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLocSessao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOCALIZAR SESSÕES";
            this.Load += new System.EventHandler(this.frmLocColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GSessoes)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.panelRapida.ResumeLayout(false);
            this.panelRapida.PerformLayout();
            this.gbPacientes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GSessoes;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Panel panelRapida;
        private System.Windows.Forms.Label lblBusca;
        private System.Windows.Forms.TextBox txtBuscaRapida;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.GroupBox gbPacientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuEditar;
        private System.Windows.Forms.ToolStripMenuItem MenuExcluir;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ToolStripMenuItem MenuPago;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbNaoPagos;
        private System.Windows.Forms.Label lblTotalDevido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsPago;
    }
}