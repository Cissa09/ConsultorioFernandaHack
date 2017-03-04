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
using CrystalDecisions.Shared;

namespace ConsultorioFernandaHack
{
    public partial class frmFiltroHistSessaoPgto : Form
    {
        #region Propriedades   
        
        public int ID;
        public DataGridViewRow Linha;
        public ConsultorioFernandaHackLib.PacienteDAL xPaciente;
        public ConsultorioFernandaHackLib.ColaboradorDAL xColaborador;              
        private ConsultorioFernandaHackLib.Relatorios.rptComissoes rpt;
        private frmCry Te;

        #endregion

        public frmFiltroHistSessaoPgto()
        {
            InitializeComponent();
        }

        //LOAD
        private void frmCadEvolucao_Load(object sender, EventArgs e)
        {
            CArregaComboPaciente();
            CArregaComboColaborador();
        }

        //SALVAR
        private void btnSalvarEvolucao_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {                
                rpt = new ConsultorioFernandaHackLib.Relatorios.rptComissoes();

                var sql = ConsultorioFernandaHackLib.RelatorioDAL.RelatorioComissoes(dtDe.Value, dtAte.Value, (int)cmbPaciente.SelectedValue, (int)cmbColaborador.SelectedValue);
               
                if (sql.Count() == 0)
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Relatório vazio!");
                    return;
                }

                rpt.SetDataSource(sql);
              
                Te = new frmCry();
                Te.Text = "Relatório de Comissões";
                Te.Cry.ReportSource = rpt;
                Te.Cry.SelectionFormula = "1 = 1";
                Te.Show();                              
            }
            catch (Exception ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro("Erro ao tentar abrir o relatório" + ex.Message);
                return;
            }
        }

        private void CArregaComboPaciente()
        {
            //Crio uma lista de paciente
            List<ConsultorioFernandaHackLib.Paciente> ListPaciente = new List<ConsultorioFernandaHackLib.Paciente>();
            //Passo o resultado do banco para a lista
            ListPaciente = (ConsultorioFernandaHackLib.PacienteDAL.BuscaPaciente());
            //Cria um pra selecione e insere na lista pra ficar bonito
            xPaciente = new ConsultorioFernandaHackLib.PacienteDAL(0, "<Todos>");
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
            xColaborador = new ConsultorioFernandaHackLib.ColaboradorDAL(0, "<Todos>");
            //Adicionar o seleciona na lista
            ListColaborador.Insert(0, xColaborador.Colaborador);
            //Abastece o combo
            cmbColaborador.DataSource = ListColaborador;
        }

        private void lklPaciente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscaPaciente();
        }

        private void lklColaborador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BuscaColaborador();
        }

        private void BuscaColaborador()
        {
            try
            {
                frmLocColaborador T = new frmLocColaborador();
                T.TipoTela = 2;
                T.ShowDialog();

                int IDColaborador = T.ID > 0 ? T.ID : (int)cmbColaborador.SelectedValue;
                CArregaComboColaborador();
                cmbColaborador.SelectedValue = IDColaborador;
            }
            catch
            {
                cmbColaborador.SelectedValue = 0;
            }
        }

        private void BuscaPaciente()
        {
            try
            {
                frmLocPaciente T = new frmLocPaciente();
                T.TipoTela = 2;
                T.ShowDialog();

                int IDPaciente = T.ID > 0 ? T.ID : (int)cmbPaciente.SelectedValue;
                CArregaComboPaciente();
                cmbPaciente.SelectedValue = IDPaciente;
            }
            catch
            {
                cmbPaciente.SelectedValue = 0;
            }
        }
    }
}
