namespace ConsultorioFernandaHack
{
    partial class frmCadEvolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadEvolucao));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvarEvolucao = new System.Windows.Forms.Button();
            this.toolTipEvolucao = new System.Windows.Forms.ToolTip(this.components);
            this.gbDadosPaciente = new System.Windows.Forms.GroupBox();
            this.btnBandeiraAzul = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblObsEvolucao = new System.Windows.Forms.Label();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblDtCadastro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gbDadosPaciente.SuspendLayout();
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
            // btnSalvarEvolucao
            // 
            this.btnSalvarEvolucao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvarEvolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(165)))), ((int)(((byte)(114)))));
            this.btnSalvarEvolucao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvarEvolucao.BackgroundImage")));
            this.btnSalvarEvolucao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvarEvolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarEvolucao.FlatAppearance.BorderSize = 0;
            this.btnSalvarEvolucao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSalvarEvolucao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvarEvolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarEvolucao.Location = new System.Drawing.Point(525, 315);
            this.btnSalvarEvolucao.Name = "btnSalvarEvolucao";
            this.btnSalvarEvolucao.Size = new System.Drawing.Size(39, 42);
            this.btnSalvarEvolucao.TabIndex = 5;
            this.toolTipEvolucao.SetToolTip(this.btnSalvarEvolucao, "Salvar Evolução");
            this.btnSalvarEvolucao.UseVisualStyleBackColor = false;
            this.btnSalvarEvolucao.Click += new System.EventHandler(this.btnSalvarEvolucao_Click);
            // 
            // gbDadosPaciente
            // 
            this.gbDadosPaciente.Controls.Add(this.btnBandeiraAzul);
            this.gbDadosPaciente.Controls.Add(this.txtDescricao);
            this.gbDadosPaciente.Controls.Add(this.lblObsEvolucao);
            this.gbDadosPaciente.Controls.Add(this.dtCadastro);
            this.gbDadosPaciente.Controls.Add(this.lblDtCadastro);
            this.gbDadosPaciente.Font = new System.Drawing.Font("Verdana", 9F);
            this.gbDadosPaciente.Location = new System.Drawing.Point(12, 7);
            this.gbDadosPaciente.Name = "gbDadosPaciente";
            this.gbDadosPaciente.Size = new System.Drawing.Size(568, 294);
            this.gbDadosPaciente.TabIndex = 6;
            this.gbDadosPaciente.TabStop = false;
            this.gbDadosPaciente.Text = "Evolução";
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
            // txtDescricao
            // 
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(92, 49);
            this.txtDescricao.MaxLength = 0;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(460, 231);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblObsEvolucao
            // 
            this.lblObsEvolucao.AutoSize = true;
            this.lblObsEvolucao.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblObsEvolucao.ForeColor = System.Drawing.Color.Black;
            this.lblObsEvolucao.Location = new System.Drawing.Point(16, 46);
            this.lblObsEvolucao.Name = "lblObsEvolucao";
            this.lblObsEvolucao.Size = new System.Drawing.Size(72, 14);
            this.lblObsEvolucao.TabIndex = 3;
            this.lblObsEvolucao.Text = "Descrição:";
            // 
            // dtCadastro
            // 
            this.dtCadastro.CustomFormat = "dd/MM/yyyy";
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCadastro.Location = new System.Drawing.Point(92, 18);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(121, 22);
            this.dtCadastro.TabIndex = 2;
            this.dtCadastro.Value = new System.DateTime(2010, 1, 12, 0, 0, 0, 0);
            // 
            // lblDtCadastro
            // 
            this.lblDtCadastro.AutoSize = true;
            this.lblDtCadastro.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblDtCadastro.ForeColor = System.Drawing.Color.Black;
            this.lblDtCadastro.Location = new System.Drawing.Point(15, 21);
            this.lblDtCadastro.Name = "lblDtCadastro";
            this.lblDtCadastro.Size = new System.Drawing.Size(42, 14);
            this.lblDtCadastro.TabIndex = 1;
            this.lblDtCadastro.Text = "Data:";
            // 
            // frmCadEvolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 375);
            this.Controls.Add(this.gbDadosPaciente);
            this.Controls.Add(this.btnSalvarEvolucao);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadEvolucao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE EVOLUÇÃO";
            this.Load += new System.EventHandler(this.frmCadEvolucao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDadosPaciente.ResumeLayout(false);
            this.gbDadosPaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvarEvolucao;
        private System.Windows.Forms.ToolTip toolTipEvolucao;
        private System.Windows.Forms.GroupBox gbDadosPaciente;
        private System.Windows.Forms.Button btnBandeiraAzul;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblObsEvolucao;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.Label lblDtCadastro;
    }
}