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
    public partial class frmLocSessao : Form
    {

        #region propriedades

        public Form Chamador;        

        #endregion

        public frmLocSessao()
        {
            InitializeComponent();
            GSessoes.AutoGenerateColumns = false;           
        }

        private void frmLocColaborador_Load(object sender, EventArgs e)
        {
            try
            {
                //Carrega as informacoes do grid de colaboradores
                Atualiza(false);

                lblTotalDevido.Visible = false;

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
            frmCadSessao T = new frmCadSessao();
            T.MdiParent = this.MdiParent;
            T.TipoOperacao = 1;
            T.Chamador = this;
            T.ShowDialog();
        }

        //Metodo de editar colaboradores
        private void Editar()
        {
            int id = (int)GSessoes.SelectedRows[0].Cells[0].Value;

            frmCadSessao T = new frmCadSessao();
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
        private void Atualiza(bool pagar)
        {
            GSessoes.DataSource = ConsultorioFernandaHackLib.SessaoDAL.Localizar(txtBuscaRapida.Text, pagar);
        }
        
        #endregion

        public void btnLoc_Click(object sender, EventArgs e)
        {
            if (cbNaoPagos.Checked == true)
            {
                Atualiza(true);

                lblTotalDevido.Visible = true;

                decimal ValorTotal = 0;

                foreach (DataGridViewRow G in GSessoes.Rows)
                {
                    ValorTotal += decimal.Parse(G.Cells["clValor"].Value.ToString());
                }

                lblTotalDevido.Text = "Saldo devedor: R$ " + ValorTotal.ToString();
            }
            else
            {
                Atualiza(false);
                lblTotalDevido.Visible = false;
            }
                

        }

        private void G_DoubleClick(object sender, EventArgs e)
        {
            Editar();
            Atualiza(false);
        }

        private void GSessoes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow a in GSessoes.Rows)
            {

                if ((bool)a.Cells["clsPago"].Value)
                    a.DefaultCellStyle.ForeColor = Color.Green;
                else
                    a.DefaultCellStyle.ForeColor = Color.Red;

            }
        }

        private void MenuPago_Click(object sender, EventArgs e)
        {
            int id = (int)GSessoes.SelectedRows[0].Cells[0].Value;
            ConsultorioFernandaHackLib.SessaoDAL xSessao = new ConsultorioFernandaHackLib.SessaoDAL(id);

            if (xSessao.Sessao.Pago == true)
            {
                if (MessageBox.Show("Esta sessão já está paga, quer deixá-la como não paga?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    xSessao.Sessao.Pago = false;
                    xSessao.Grava();
                    Atualiza(false);
                }
            }
            else if (MessageBox.Show("Deseja realmente pagar esta sessão?", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                xSessao.Sessao.Pago = true;
                xSessao.Grava();
                Atualiza(false);
            }
        }
    }
}
