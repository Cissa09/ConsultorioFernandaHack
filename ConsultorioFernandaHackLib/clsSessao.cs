using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace ConsultorioFernandaHackLib
{
    public partial class Sessao
    {
        public string nomefunc
        {
            get
            {
                return SessaoDAL.BuscaNomeColaborador((int)this.IDColaborador);                                    
            }
        }

        public string nomePaciente
        {
            get
            {
                return SessaoDAL.BuscaNomePaciente((int)this.IDPaciente);
            }
        }
    }

    public class SessaoDAL
    {
       
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();

        #region Propriedades

        private Sessao _sessao;

        public Sessao Sessao
        {
            get { return _sessao; }
        }

        #endregion

        #region Construtores

        public SessaoDAL(int id)
        {
            Retrive(id);
        }

        public SessaoDAL()
        {
            _sessao = new Sessao();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Método que carrega a classe com a sessao em questão
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar as propriedades da sessão</param>
        private void Retrive(int id)
        {
            _sessao = (from se in ctx.Sessaos where se.IDSessao == id select se).FirstOrDefault();
            if (_sessao == null)
                _sessao = new Sessao();

        }

        /// <summary>
        /// Grava a Sessão
        /// </summary>
        /// <returns>IDSessao que foi gravado</returns>
        public int Grava()
        {
            if (this._sessao.IDSessao <= 0)
                ctx.Sessaos.InsertOnSubmit(_sessao);

            ctx.SubmitChanges();

            return _sessao.IDSessao;
        }

        /// <summary>
        /// Exclui a Sessão
        /// </summary>
        public void Excluir()
        {
            if (_sessao != null && _sessao.IDSessao > 0)
            {
                ctx.Sessaos.DeleteOnSubmit(_sessao);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir a Sessão");
        }

        /// <summary>
        /// Método que busca uma sessão
        /// </summary>
        /// <param name="Busca">Parâmetro passado pelo btnLoc_Click, tras as informacoes que o usuario utiliza para realizar a busca.</param>
        public static IEnumerable Localizar(string Busca, bool pagar)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                ctxs.Connection.Open();

                List<vwSessaoHistPgto> xListAux = new List<vwSessaoHistPgto>();

                Busca = CFormato.FormataBusca(Busca);

                if (!pagar)
                {
                    var SQL = (from Hsp in ctxs.vwSessaoHistPgtos
                               select Hsp).ToList();

                    foreach (vwSessaoHistPgto Hsp in SQL)
                    {
                        if (CFormato.FormataBusca(Hsp.NomeColaborador).Contains(Busca)
                            || CFormato.LimpaString(CFormato.FormataBusca(Hsp.NomePaciente)).Contains(CFormato.LimpaString(Busca))
                            || CFormato.FormataBusca(Hsp.DataSessao.ToString()).Contains(Busca))
                        {
                            xListAux.Add(Hsp);
                        }
                    }
                }
                else
                {
                    var SQL = (from Hsp in ctxs.vwSessaoHistPgtos
                               where Hsp.Pago == false
                               select Hsp).ToList();

                    foreach (vwSessaoHistPgto Hsp in SQL)
                    {
                        if (CFormato.FormataBusca(Hsp.NomeColaborador).Contains(Busca)
                            || CFormato.LimpaString(CFormato.FormataBusca(Hsp.NomePaciente)).Contains(CFormato.LimpaString(Busca))
                            || CFormato.FormataBusca(Hsp.DataSessao.ToString()).Contains(Busca))
                        {
                            xListAux.Add(Hsp);
                        }
                    }
                }
 
                return xListAux;
            }
        }

        public static string BuscaNomeColaborador(int IDColab)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                return ctxs.Colaboradors.Where(p => p.IDColaborador == IDColab).FirstOrDefault().Nome;
            }
        }

        public static string BuscaNomePaciente(int IDPac)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                return ctxs.Pacientes.Where(p => p.IDPaciente == IDPac).FirstOrDefault().Nome;
            }
        }

        #endregion
    }    
}
