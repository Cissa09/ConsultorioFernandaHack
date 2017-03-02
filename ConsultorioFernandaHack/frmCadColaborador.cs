using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsultorioFernandaHack
{
    public partial class frmCadColaborador : Form
    {
        #region Propriedades

        public int ID;
        public int TipoOperacao;
        public frmLocColaborador Chamador;        
        public bool _salvo = false;
        public ConsultorioFernandaHackLib.ColaboradorDAL xColaborador;   
            
        #endregion

        public frmCadColaborador()
        {
            InitializeComponent();
        }

        private void frmCadColaborador_Load(object sender, EventArgs e)
        {
            try
            {
                //Cadastra novo Paciente
                if (TipoOperacao == 1)
                {
                    xColaborador = new ConsultorioFernandaHackLib.ColaboradorDAL();                                        
                }
                //Carrega campos de um paciente existente
                else
                {
                    xColaborador = new ConsultorioFernandaHackLib.ColaboradorDAL(this.ID);
                    this.Text = "Alterando Paciente " + xColaborador.Colaborador.Nome;
                    txtCodPaciente.Text = xColaborador.Colaborador.IDColaborador.ToString();
                    txtNome.Text = xColaborador.Colaborador.Nome;
                    if (xColaborador.Colaborador.DtNascimento.HasValue)
                        txtDtNascimento.Value = (DateTime)xColaborador.Colaborador.DtNascimento;
                    else txtDtNascimento.Checked = false;                                        
                    txtEmail.Text = xColaborador.Colaborador.Email;
                    txtCelular.Text = xColaborador.Colaborador.Telefone1;
                    txtTelefone1.Text = xColaborador.Colaborador.Telefone2;
                    txtRG.Text = xColaborador.Colaborador.RG;
                    txtCPF.Text = xColaborador.Colaborador.CPF;
                    txtComissao.Text = xColaborador.Colaborador.PorcComissao.ToString();
                }
            }
            catch (Exception Ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro(Ex.Message);
            }
        }

        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validacoes

                if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Nome do colaborador.");                    
                    txtNome.Focus();
                    return;
                }             

                if (string.IsNullOrEmpty(txtCelular.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Celular do colaborador.");
                    txtCelular.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Email do colaborador.");
                    txtEmail.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtComissao.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe a comissao do colaborador.");
                    txtComissao.Focus();
                    return;
                }

                #endregion

                xColaborador.Colaborador.Nome = txtNome.Text;                              
                if (txtDtNascimento.Checked) xColaborador.Colaborador.DtNascimento = txtDtNascimento.Value;
                else xColaborador.Colaborador.DtNascimento = null;
                xColaborador.Colaborador.Telefone1 = txtCelular.Text;
                xColaborador.Colaborador.Telefone2 = txtTelefone1.Text;
                xColaborador.Colaborador.RG = txtRG.Text;
                xColaborador.Colaborador.CPF = txtCPF.Text;
                xColaborador.Colaborador.Email = txtEmail.Text;
                xColaborador.Colaborador.PorcComissao = Decimal.Parse(txtComissao.Text);

                xColaborador.Grava();

                _salvo = true;

                if (Chamador != null)
                    Chamador.btnLoc_Click(sender, e);

                this.Close();
            }
            catch(Exception Ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro(Ex.Message);
            }
        }

      
    }
}
