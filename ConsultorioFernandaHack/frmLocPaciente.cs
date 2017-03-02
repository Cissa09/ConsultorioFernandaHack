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
    public partial class frmLocPaciente : Form
    {

        #region propriedades

        public Form Chamador;       

        #endregion

        public frmLocPaciente()
        {
            InitializeComponent();
            GPacientes.AutoGenerateColumns = false;           
        }


        private void frmLocCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //Carrega as informacoes do grid de pacientes
                Atualiza();
            }
            catch
            {                
                ConsultorioFernandaHackLib.CUtil.MsgErro("Ocorreu um erro ao carregar os dados, verifique o seu servidor e sua conexão de rede!");
            }
        }

        #region Eventos de botoes

        //Botao direito do no Grid Novo paciente
        private void MenuNovo_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        //Botao direito do no Grid Editar paciente
        private void MenuEditar_Click(object sender, EventArgs e)
        {
            Editar();

        }

        //Botao direito do no Grid Excluir paciente
        private void MenuExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        #endregion

        #region Metodos

        //Metodo de inserir novo paciente
        private void Inserir()
        {
            frmCadPaciente T = new frmCadPaciente();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Chamador = this;
            T.ShowDialog();
        }

        //Metodo de editar paciente
        private void Editar()
        {
            int id = (int)GPacientes.SelectedRows[0].Cells[0].Value;

            frmCadPaciente T = new frmCadPaciente();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 2;
            T.Chamador = this;
            T.ID = id;
            T.ShowDialog();
        }

        //Metodo de excluir paciente
        private void Excluir()
        {

        }

        //Metodo para atualizar o Grid
        private void Atualiza()
        {
            GPacientes.DataSource = ConsultorioFernandaHackLib.PacienteDAL.Localizar(txtBuscaRapida.Text);
        }
        
        #endregion

        public void btnLoc_Click(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void G_DoubleClick(object sender, EventArgs e)
        {
            Editar();
            Atualiza();
        }
    }
}
