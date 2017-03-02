namespace ConsultorioFernandaHack
{
    partial class frmFiltroHistSessaoPgto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroHistSessaoPgto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGerar = new System.Windows.Forms.Button();
            this.toolTipAvaliacao = new System.Windows.Forms.ToolTip(this.components);
            this.gbGeral = new System.Windows.Forms.GroupBox();
            this.cmbColaborador = new System.Windows.Forms.ComboBox();
            this.cmbPaciente = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtAte = new System.Windows.Forms.DateTimePicker();
            this.dtDe = new System.Windows.Forms.DateTimePicker();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblColaborador = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnGerar);
            this.panel1.Location = new System.Drawing.Point(2, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 62);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(290, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "RELATÓRIO";
            // 
            // btnGerar
            // 
            this.btnGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnGerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerar.BackgroundImage")));
            this.btnGerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Location = new System.Drawing.Point(313, 1);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(39, 42);
            this.btnGerar.TabIndex = 10;
            this.toolTipAvaliacao.SetToolTip(this.btnGerar, "Gerar relatório de comissão");
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // gbGeral
            // 
            this.gbGeral.Controls.Add(this.cmbColaborador);
            this.gbGeral.Controls.Add(this.cmbPaciente);
            this.gbGeral.Controls.Add(this.label8);
            this.gbGeral.Controls.Add(this.label9);
            this.gbGeral.Controls.Add(this.dtAte);
            this.gbGeral.Controls.Add(this.dtDe);
            this.gbGeral.Controls.Add(this.lblPaciente);
            this.gbGeral.Controls.Add(this.lblColaborador);
            this.gbGeral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGeral.Location = new System.Drawing.Point(12, 9);
            this.gbGeral.Name = "gbGeral";
            this.gbGeral.Size = new System.Drawing.Size(354, 111);
            this.gbGeral.TabIndex = 1;
            this.gbGeral.TabStop = false;
            this.gbGeral.Text = "Filtros";
            // 
            // cmbColaborador
            // 
            this.cmbColaborador.DisplayMember = "Nome";
            this.cmbColaborador.FormattingEnabled = true;
            this.cmbColaborador.Location = new System.Drawing.Point(97, 75);
            this.cmbColaborador.Name = "cmbColaborador";
            this.cmbColaborador.Size = new System.Drawing.Size(240, 21);
            this.cmbColaborador.TabIndex = 9;
            this.cmbColaborador.ValueMember = "IDColaborador";
            // 
            // cmbPaciente
            // 
            this.cmbPaciente.DisplayMember = "Nome";
            this.cmbPaciente.FormattingEnabled = true;
            this.cmbPaciente.Location = new System.Drawing.Point(97, 47);
            this.cmbPaciente.Name = "cmbPaciente";
            this.cmbPaciente.Size = new System.Drawing.Size(240, 21);
            this.cmbPaciente.TabIndex = 7;
            this.cmbPaciente.ValueMember = "IDPaciente";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(203, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Até:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "De:";
            // 
            // dtAte
            // 
            this.dtAte.Checked = false;
            this.dtAte.CustomFormat = "dd/MM/yyyy";
            this.dtAte.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAte.Location = new System.Drawing.Point(234, 20);
            this.dtAte.Name = "dtAte";
            this.dtAte.Size = new System.Drawing.Size(103, 21);
            this.dtAte.TabIndex = 5;
            // 
            // dtDe
            // 
            this.dtDe.Checked = false;
            this.dtDe.CustomFormat = "dd/MM/yyyy";
            this.dtDe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDe.Location = new System.Drawing.Point(97, 20);
            this.dtDe.Name = "dtDe";
            this.dtDe.Size = new System.Drawing.Size(103, 21);
            this.dtDe.TabIndex = 3;
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaciente.ForeColor = System.Drawing.Color.Black;
            this.lblPaciente.Location = new System.Drawing.Point(8, 50);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(60, 13);
            this.lblPaciente.TabIndex = 6;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblColaborador
            // 
            this.lblColaborador.AutoSize = true;
            this.lblColaborador.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaborador.ForeColor = System.Drawing.Color.Black;
            this.lblColaborador.Location = new System.Drawing.Point(7, 77);
            this.lblColaborador.Name = "lblColaborador";
            this.lblColaborador.Size = new System.Drawing.Size(83, 13);
            this.lblColaborador.TabIndex = 8;
            this.lblColaborador.Text = "Colaborador:";
            // 
            // frmFiltroHistSessaoPgto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 203);
            this.Controls.Add(this.gbGeral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFiltroHistSessaoPgto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO COMISSÃO";
            this.Load += new System.EventHandler(this.frmCadEvolucao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbGeral.ResumeLayout(false);
            this.gbGeral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.ToolTip toolTipAvaliacao;
        private System.Windows.Forms.GroupBox gbGeral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtAte;
        private System.Windows.Forms.DateTimePicker dtDe;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblColaborador;
        private System.Windows.Forms.ComboBox cmbColaborador;
        private System.Windows.Forms.ComboBox cmbPaciente;
    }
}