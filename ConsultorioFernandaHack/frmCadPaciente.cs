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
    public partial class frmCadPaciente : Form
    {
        #region Propriedades

        public int ID;
        public int TipoOperacao;
        public frmLocPaciente Chamador;
        public int ChamadorDescr;
        public bool _salvo = false;
        public bool _salvoFilho = false;
        public ConsultorioFernandaHackLib.PacienteDAL xPaciente;
        public bool primeiraVezTabPacientes = false;
        public bool primeiraVezTabEvolucao = false;
        public bool primeiraVezTabAvaliacao = false;

        #endregion

        public frmCadPaciente()
        {
            InitializeComponent();
            GEvolucao.AutoGenerateColumns = false;
            GAvaliacao.AutoGenerateColumns = false;
        }

        //LOAD
        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            try
            {
                //Cadastra novo Paciente
                if (TipoOperacao == 1)
                {
                    xPaciente = new ConsultorioFernandaHackLib.PacienteDAL();
                    dtDesde.Value = DateTime.Now;
                    cmbSexo.SelectedIndex = 0;                    
                }
                //Chama o evento de Aba selecionada
                else
                    tbPaciente_SelectedIndexChanged(sender, e);                                                  
            }
            catch (Exception Ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro(Ex.Message);
            }

        }

        //EVENTO QUE CARREGA AS ABAS
        public void tbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbPaciente.TabPages[tbPaciente.SelectedIndex].Name == "tbDados")
            {
                if (!primeiraVezTabPacientes)
                {
                    primeiraVezTabPacientes = true;
                    if (this.TipoOperacao != 1)
                    {

                        xPaciente = new ConsultorioFernandaHackLib.PacienteDAL(this.ID);
                        this.Text = "Alterando Paciente " + xPaciente.Paciente.Nome;
                        txtCodPaciente.Text = xPaciente.Paciente.IDPaciente.ToString();
                        txtNome.Text = xPaciente.Paciente.Nome;
                        if (xPaciente.Paciente.ClienteDesde != null)
                            dtDesde.Value = (DateTime)xPaciente.Paciente.ClienteDesde;
                        if (xPaciente.Paciente.DtNascimento.HasValue)
                            txtDtNascimento.Value = (DateTime)xPaciente.Paciente.DtNascimento;
                        else txtDtNascimento.Checked = false;
                        if (xPaciente.Paciente.Sexo == '1') cmbSexo.SelectedIndex = 1;
                        else if (xPaciente.Paciente.Sexo == '2') cmbSexo.SelectedIndex = 2;
                        else cmbSexo.SelectedIndex = 0;
                        txtEmail.Text = xPaciente.Paciente.Email;
                        txtCelular.Text = xPaciente.Paciente.Telefone;
                        txtTelefone1.Text = xPaciente.Paciente.Telefone2;
                        txtRG.Text = xPaciente.Paciente.RG;
                        txtCPF.Text = xPaciente.Paciente.CPF;
                        txtObservacao.Text = xPaciente.Paciente.Obs;
                    }
                }
            }
            else if (tbPaciente.TabPages[tbPaciente.SelectedIndex].Name == "tbEvolucao")
            {
                if (!primeiraVezTabEvolucao)
                {
                    primeiraVezTabEvolucao = true;
                    GEvolucao.DataSource = xPaciente.Paciente.Evolucaos.ToList();
                }
            }
            else if (tbPaciente.TabPages[tbPaciente.SelectedIndex].Name == "tbAvaliacao")
            {
                if (!primeiraVezTabAvaliacao)
                {
                    primeiraVezTabAvaliacao = true;
                    GAvaliacao.DataSource = xPaciente.Paciente.Avaliacaos.ToList();
                }
            }
        }

        //SALVAR 
        private void btnSalvarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validacoes

                if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Nome do paciente.");                    
                    txtNome.Focus();
                    return;
                }

                if (cmbSexo.SelectedIndex == 0)
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Sexo do paciente.");
                    cmbSexo.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtCelular.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Celular do paciente.");
                    txtCelular.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
                {
                    ConsultorioFernandaHackLib.CUtil.MsgErro("Informe o Email do paciente.");
                    txtEmail.Focus();
                    return;
                }

                #endregion

                xPaciente.Paciente.Nome = txtNome.Text;
                xPaciente.Paciente.ClienteDesde = dtDesde.Value;
                if (cmbSexo.SelectedIndex == 1) xPaciente.Paciente.Sexo = '1'; else xPaciente.Paciente.Sexo = '2';
                if (txtDtNascimento.Checked) xPaciente.Paciente.DtNascimento = txtDtNascimento.Value;
                else xPaciente.Paciente.DtNascimento = null;
                xPaciente.Paciente.Telefone = txtCelular.Text;
                xPaciente.Paciente.Telefone2 = txtTelefone1.Text;
                xPaciente.Paciente.RG = txtRG.Text;
                xPaciente.Paciente.CPF = txtCPF.Text;
                xPaciente.Paciente.Email = txtEmail.Text;
                xPaciente.Paciente.Obs = txtObservacao.Text;

                xPaciente.Grava();

                _salvo = true;
                
                if(Chamador != null)
                    Chamador.btnLoc_Click(sender, e);

                this.Close();
            }
            catch(Exception Ex)
            {
                ConsultorioFernandaHackLib.CUtil.MsgErro(Ex.Message);
            }
        }

        #region EVOLUÇÃO

        //ADICIONA EVOLUÇÃO
        private void MenuNovo_Click(object sender, EventArgs e)
        {
            AdicionaEvolucao();
        }

       
        //EDITA EVOLUÇÃO
        private void EditarEvolucao_Click(object sender, EventArgs e)
        {
            EditaEvolucao();
        }

        //EXCLUÍ EVOLUÇÃO
        private void ExcluirEvolucao_Click(object sender, EventArgs e)
        {
            ExcluiEvolucao();
        }

        //ADICIONA UMA NOVA EVOLUÇÃO
        private void AdicionaEvolucao()
        {
            frmCadEvolucao T = new frmCadEvolucao();
            T.xPaciente = this.xPaciente;
            T.TipoOperacao = 1;
            T.ShowDialog();
            if (T.Salvo)
            {
                _salvoFilho = true;
            }
            GEvolucao.DataSource = null;
            GEvolucao.DataSource = xPaciente.Paciente.Evolucaos.ToList();
        }

        //EDITA UMA EVOLUÇÃO
        private void EditaEvolucao()
        {
            if (GEvolucao.SelectedRows.Count > 0)
            {
                frmCadEvolucao T = new frmCadEvolucao();
                T.xPaciente = this.xPaciente;
                T.ID = int.Parse(GEvolucao.SelectedRows[0].Cells[0].Value.ToString());
                T.TipoOperacao = 2;
                T.ShowDialog();
                if (T.Salvo)
                {
                    _salvoFilho = true;
                }
                GEvolucao.DataSource = null;
                GEvolucao.DataSource = xPaciente.Paciente.Evolucaos.ToList();
            }
        }

        //EXCLUI UMA EVOLUÇÃO
        private void ExcluiEvolucao()
        {
            if (GEvolucao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir " + GEvolucao.SelectedRows[0].Cells[2].Value + "? ", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ConsultorioFernandaHackLib.Evolucao xEvo = (from evo in xPaciente.Paciente.Evolucaos
                                                                where evo.IDEvolucao == int.Parse(GEvolucao.SelectedRows[0].Cells[0].Value.ToString())
                                                                select evo).First();

                    xPaciente.ExcluiEvolucao(xEvo);
                    xPaciente.Paciente.Evolucaos.Remove(xEvo);
                    _salvoFilho = true;
                    GEvolucao.DataSource = null;
                    GEvolucao.DataSource = xPaciente.Paciente.Evolucaos.ToList();

                }
            }
        }

        //DOUBLE CLICK EVOLUÇÃO
        private void GEvolucao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditaEvolucao();
        }

        #endregion

        #region AVALIÇÃO

        private void MenuNovaAvaliacao_Click(object sender, EventArgs e)
        {
            AdicionaAvaliacao();
        }

        private void EditarAvaliacao_Click(object sender, EventArgs e)
        {
            EditaAvaliacao();
        }

        private void ExcluirAvaliacao_Click(object sender, EventArgs e)
        {
            ExcluiAvalacao();
        }

        //ADICIONA UMA NOVA AVALIAÇÃO
        private void AdicionaAvaliacao()
        {
            frmCadAvaliacao T = new frmCadAvaliacao();
            T.xPaciente = this.xPaciente;
            T.TipoOperacao = 1;
            T.ShowDialog();
            if (T.Salvo)
            {
                _salvoFilho = true;
            }
            GAvaliacao.DataSource = null;
            GAvaliacao.DataSource = xPaciente.Paciente.Avaliacaos.ToList();
        }

        //EDITA UMA AVALIAÇÃO
        private void EditaAvaliacao()
        {
            if (GEvolucao.SelectedRows.Count > 0)
            {
                frmCadAvaliacao T = new frmCadAvaliacao();
                T.xPaciente = this.xPaciente;
                T.ID = int.Parse(GAvaliacao.SelectedRows[0].Cells[0].Value.ToString());
                T.TipoOperacao = 2;
                T.ShowDialog();
                if (T.Salvo)
                {
                    _salvoFilho = true;
                }
                GAvaliacao.DataSource = null;
                GAvaliacao.DataSource = xPaciente.Paciente.Avaliacaos.ToList();
            }
        }

        //EXCLUI UMA AVALIAÇÃO
        private void ExcluiAvalacao()
        {
            if (GEvolucao.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente excluir " + GEvolucao.SelectedRows[0].Cells[2].Value + "? ", "ATENÇÃO!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    ConsultorioFernandaHackLib.Avaliacao xAva = (from ava in xPaciente.Paciente.Avaliacaos
                                                                 where ava.IDAvaliacao == int.Parse(GAvaliacao.SelectedRows[0].Cells[0].Value.ToString())
                                                                 select ava).First();

                    xPaciente.ExcluiAvaliacao(xAva);
                    xPaciente.Paciente.Avaliacaos.Remove(xAva);
                    _salvoFilho = true;
                    GAvaliacao.DataSource = null;
                    GAvaliacao.DataSource = xPaciente.Paciente.Avaliacaos.ToList();

                }
            }
        }

        //DOUBLE CLICK AVALIAÇÃO
        private void GAvaliacao_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditaAvaliacao();
        }

        #endregion
        
    }
}
