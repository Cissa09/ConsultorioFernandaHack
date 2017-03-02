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
    public partial class frmCadEvolucao : Form
    {
        #region Propriedades   

        public int TipoOperacao;
        public int ID;
        public DataGridViewRow Linha;
        public ConsultorioFernandaHackLib.PacienteDAL xPaciente;
        private ConsultorioFernandaHackLib.Evolucao xEvolucao;
        private bool _salvo = false;
        public List<string> listaArqExcluidos;

        public bool Salvo
        {
            get { return _salvo; }
        }

        #endregion

        public frmCadEvolucao()
        {
            InitializeComponent();
        }

        //LOAD
        private void frmCadEvolucao_Load(object sender, EventArgs e)
        {
            if (this.TipoOperacao == 1)
            {
                this.Text = "Nova Evolução";
                xEvolucao = new ConsultorioFernandaHackLib.Evolucao();
                dtCadastro.Value = DateTime.Now.Date;
            }
            else
            {
                xEvolucao = ((from evo in xPaciente.Paciente.Evolucaos
                              where evo.IDEvolucao == this.ID
                              select evo).First());

                this.Text = "Alterando Evolução ";
                dtCadastro.Value = xEvolucao.DataEvolucao;
                txtDescricao.Text = xEvolucao.Descricao;

            }
        }

        //SALVAR
        private void btnSalvarEvolucao_Click(object sender, EventArgs e)
        {
            try
            {
                xEvolucao.DataEvolucao = dtCadastro.Value;
                xEvolucao.Descricao = txtDescricao.Text;

                this.xPaciente.Paciente.Evolucaos.Add(xEvolucao);

                _salvo = true;
                this.Close();
            }
            catch (Exception ex)
            {                
                ConsultorioFernandaHackLib.CUtil.MsgErro("Ocorreu um erro ao carregar os dados, verifique o seu computador está conectado ao servidor!" + ex.Message);          
                return;
            }

        }              
    }
}
