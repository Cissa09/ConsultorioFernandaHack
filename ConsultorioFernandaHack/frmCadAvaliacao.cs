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
    public partial class frmCadAvaliacao : Form
    {
        #region Propriedades   

        public int TipoOperacao;
        public int ID;
        public DataGridViewRow Linha;
        public ConsultorioFernandaHackLib.PacienteDAL xPaciente;
        private ConsultorioFernandaHackLib.Avaliacao xAvaliacao;
        private bool _salvo = false;
        public List<string> listaArqExcluidos;

        public bool Salvo
        {
            get { return _salvo; }
        }

        #endregion

        public frmCadAvaliacao()
        {
            InitializeComponent();
        }
 
        //LOAD
        private void frmCadAvaliacao_Load(object sender, EventArgs e)
        {
            if (this.TipoOperacao == 1)
            {
                this.Text = "Nova Avaliação";
                xAvaliacao = new ConsultorioFernandaHackLib.Avaliacao();
                dtCadastro.Value = DateTime.Now.Date;
            }
            else
            {
                xAvaliacao = ((from ava in xPaciente.Paciente.Avaliacaos
                               where ava.IDAvaliacao == this.ID
                               select ava).First());

                this.Text = "Alterando Avaliação ";
                dtCadastro.Value = xAvaliacao.DataAvaliacao;
                txtDescricao.Text = xAvaliacao.Descricao;

            }
        }

        //SALVAR
        private void btnSalvarAvaliacao_Click(object sender, EventArgs e)
        {                                   
            try
            {
                xAvaliacao.DataAvaliacao = dtCadastro.Value;
                xAvaliacao.Descricao = txtDescricao.Text;

                this.xPaciente.Paciente.Avaliacaos.Add(xAvaliacao);

                _salvo = true;
                this.Close();
            }
            catch (Exception ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro("Ocorreu um erro ao salvar sua avaliação, verifique o seu computador está conectado ao servidor!" + ex.Message);
                return;
            }
        }
    }
}