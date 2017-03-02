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
    public partial class frmLocColaborador : Form
    {

        #region propriedades

        public Form Chamador;        

        #endregion

        public frmLocColaborador()
        {
            InitializeComponent();
            GColaboradores.AutoGenerateColumns = false;           
        }

        private void frmLocColaborador_Load(object sender, EventArgs e)
        {
            try
            {
                //Carrega as informacoes do grid de colaboradores
                Atualiza();
            }
            catch
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro("Ocorreu um erro ao carregar os dados, verifique o seu servidor e sua conexão de rede!");
            }
        }

        #region Eventos de botoes

        //Botao direito do no Grid Novo colaboradores
        private void MenuNovo_Click(object sender, EventArgs e)
        {
            Inserir();
        }

        //Botao direito do no Grid Editar colaboradores
        private void MenuEditar_Click(object sender, EventArgs e)
        {
            Editar();

        }

        //Botao direito do no Grid Excluir colaboradores
        private void MenuExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        #endregion

        #region Metodos

        //Metodo de inserir novo colaboradores
        private void Inserir()
        {
            frmCadColaborador T = new frmCadColaborador();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Chamador = this;
            T.ShowDialog();
        }

        //Metodo de editar colaboradores
        private void Editar()
        {
            int id = (int)GColaboradores.SelectedRows[0].Cells[0].Value;

            frmCadColaborador T = new frmCadColaborador();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 2;
            T.Chamador = this;
            T.ID = id;
            T.ShowDialog();
        }

        //Metodo de excluir colaboradores
        private void Excluir()
        {
            
        }

        //Metodo para atualizar o Grid
        private void Atualiza()
        {
            GColaboradores.DataSource = ConsultorioFernandaHackLib.ColaboradorDAL.Localizar(txtBuscaRapida.Text);
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
