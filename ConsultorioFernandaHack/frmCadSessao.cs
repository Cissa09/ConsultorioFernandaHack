using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioFernandaHack
{
    public partial class frmCadSessao : Form
    {
        #region Propriedades   
        
        public int ID;
        public int TipoOperacao;
        public DataGridViewRow Linha;
        public frmLocSessao Chamador;
        public int ChamadorDescr;
        public bool _salvo = false;
        public bool _salvoFilho = false;
        public ConsultorioFernandaHackLib.SessaoDAL xSessao;
        public ConsultorioFernandaHackLib.PacienteDAL xPaciente;
        public ConsultorioFernandaHackLib.ColaboradorDAL xColaborador;
        public ConsultorioFernandaHackLib.HistSessaoPgtoDAL xHistSesPgto;

        public bool Salvo
        {
            get { return _salvo; }
        }

        #endregion

        public frmCadSessao()
        {
            InitializeComponent();
        }

        //LOAD
        private void frmCadSessao_Load(object sender, EventArgs e)
        {

            CArregaComboPaciente();
            CArregaComboColaborador();

            if (TipoOperacao == 1)
            {
                xSessao = new ConsultorioFernandaHackLib.SessaoDAL();
                xHistSesPgto = new ConsultorioFernandaHackLib.HistSessaoPgtoDAL();
                //Coloca data do dia no DateTimePicker
                dtSessao.Value = DateTime.Now;                
            }
            else
            {
                xSessao = new ConsultorioFernandaHackLib.SessaoDAL(ID);
                xHistSesPgto = new ConsultorioFernandaHackLib.HistSessaoPgtoDAL(ID);
                dtSessao.Value = xSessao.Sessao.DataSessao;
                cmbColaborador.SelectedValue = xSessao.Sessao.IDColaborador;
                cmbPaciente.SelectedValue = xSessao.Sessao.IDPaciente;
                cbPago.Checked = xSessao.Sessao.Pago;
                txtValor.Text = xSessao.Sessao.Valor.ToString();     
            }
        }

        //SALVAR      
        private void btnSalvarSessao_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validacoes
               
                if (cmbColaborador.SelectedIndex == 0)
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o colaborador que irá realizar a sessão.");
                    cmbColaborador.Focus();
                    return;
                }

                if (cmbPaciente.SelectedIndex == 0)
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o paciente desta sessão.");
                    cmbColaborador.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtValor.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o valor da sessão.");
                    txtValor.Focus();
                    return;
                }

                #endregion
           
                xSessao.Sessao.DataSessao = dtSessao.Value;
                xSessao.Sessao.IDColaborador = (int)cmbColaborador.SelectedValue;
                xSessao.Sessao.IDPaciente = (int)cmbPaciente.SelectedValue;
                xSessao.Sessao.Valor = decimal.Parse(txtValor.Text.Trim());
                xSessao.Sessao.Pago = cbPago.Checked;

                xSessao.Grava();

                xHistSesPgto.HistSessaoPgto.IDSessao = xSessao.Sessao.IDSessao;
                xHistSesPgto.HistSessaoPgto.PorcComissao = xSessao.Sessao.Colaborador.PorcComissao;
                
                xHistSesPgto.Grava();

                _salvo = true;

                if(Chamador != null)
                    Chamador.btnLoc_Click(sender, e);

                this.Close();
            }
            catch (Exception Ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro(Ex.Message);
            }
        }

        private void CArregaComboPaciente()
        {
            //Crio uma lista de paciente
            List<ConsultorioFernandaHackLib.Paciente> ListPaciente = new List<ConsultorioFernandaHackLib.Paciente>();
            //Passo o resultado do banco para a lista
            ListPaciente = (ConsultorioFernandaHackLib.PacienteDAL.BuscaPaciente());            
            //Cria um pra selecione e insere na lista pra ficar bonito
            xPaciente = new ConsultorioFernandaHackLib.PacienteDAL(0, "Selecione:");
            //Adicionar o seleciona na lista
            ListPaciente.Insert(0, xPaciente.Paciente);
            //Abastece o combo
            cmbPaciente.DataSource = ListPaciente;                 
           
        }

        private void CArregaComboColaborador()
        {
            //Crio uma lista de colaborador
            List<ConsultorioFernandaHackLib.Colaborador> ListColaborador = new List<ConsultorioFernandaHackLib.Colaborador>();
            //Passo o resultado do banco para a lista
            ListColaborador = (ConsultorioFernandaHackLib.ColaboradorDAL.BuscaColaborador());
            //Cria um pra selecione e insere na lista pra ficar bonito
            xColaborador = new ConsultorioFernandaHackLib.ColaboradorDAL(0, "Selecione:");
            //Adicionar o seleciona na lista
            ListColaborador.Insert(0, xColaborador.Colaborador);
            //Abastece o combo
            cmbColaborador.DataSource = ListColaborador;

        }
    }
}
