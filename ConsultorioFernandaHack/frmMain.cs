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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        
        //Botao para abrir a tela de localizacao dos pacientes.
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            frmLocPaciente T = new frmLocPaciente();
            T.Show();
        }
                  
        private void btnSessao_Click(object sender, EventArgs e)
        {
            frmLocSessao T = new frmLocSessao();
            T.Show();
        }

        private void btnColaborador_Click(object sender, EventArgs e)
        {
            frmLocColaborador T = new frmLocColaborador();
            T.Show();
        }
            
        private void MenuPaciente_Click(object sender, EventArgs e)
        {
            frmCadPaciente T = new frmCadPaciente();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Show();
        }

        private void MenuColaborador_Click(object sender, EventArgs e)
        {
            frmCadColaborador T = new frmCadColaborador();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Show();
        }

        private void MenuSessao_Click(object sender, EventArgs e)
        {
            frmCadSessao T = new frmCadSessao();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Show();
        }

        private void MainMenuRptComissoes_Click(object sender, EventArgs e)
        {
            frmFiltroHistSessaoPgto T = new frmFiltroHistSessaoPgto();
            T.Show();
        }
        private void MenuAgendaSessao_Click(object sender, EventArgs e)
        {
            frmCadSessao T = new frmCadSessao();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;           
            T.Show();
        }

        private void MenuFuncionarios_Click(object sender, EventArgs e)
        {
            frmLocColaborador T = new frmLocColaborador();
            T.Show();
        }
        
        private void MenuLocSessao_Click(object sender, EventArgs e)
        {
            frmLocSessao T = new frmLocSessao();
            T.Show();
        }

        private void MenuLocPacientes_Click(object sender, EventArgs e)
        {
            frmLocPaciente T = new frmLocPaciente();
            T.Show();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
