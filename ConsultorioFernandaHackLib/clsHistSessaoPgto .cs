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
    public class HistSessaoPgtoDAL
    {
       
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();

        #region Propriedades

        private HistSessaoPgto _histsessaopgto;

        public HistSessaoPgto HistSessaoPgto
        {
            get { return _histsessaopgto; }
        }

        #endregion

        #region Construtores

        public HistSessaoPgtoDAL(int id)
        {
            Retrive(id);
        }

        public HistSessaoPgtoDAL()
        {
            _histsessaopgto = new HistSessaoPgto();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Método que carrega a classe com o histórico da sessao em questão
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar as propriedades do histórico da sessão</param>
        private void Retrive(int id)
        {
            _histsessaopgto = (from hse in ctx.HistSessaoPgtos where hse.IDHistSessaoPgto == id select hse).FirstOrDefault();
            if (_histsessaopgto == null)
                _histsessaopgto = new HistSessaoPgto();

        }

        /// <summary>
        /// Grava o histórico da sessão
        /// </summary>
        /// <returns>IDSessao que foi gravado</returns>
        public int Grava()
        {
            if (this._histsessaopgto.IDHistSessaoPgto <= 0)
                ctx.HistSessaoPgtos.InsertOnSubmit(_histsessaopgto);

            ctx.SubmitChanges();

            return _histsessaopgto.IDHistSessaoPgto;
        }

        /// <summary>
        /// Exclui o histórico da Sessão
        /// </summary>
        public void Excluir()
        {
            if (_histsessaopgto != null && _histsessaopgto.IDHistSessaoPgto > 0)
            {
                ctx.HistSessaoPgtos.DeleteOnSubmit(_histsessaopgto);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir o histórico de pagamento da Sessão");
        }

        /// <summary>
        /// Método que busca uma histórico de sessão pagamento
        /// </summary>
        /// <param name="Busca">Parâmetro passado pelo btnLoc_Click, tras as informacoes que o usuario utiliza para realizar a busca.</param>
        public static IEnumerable Localizar(string Busca)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                ctxs.Connection.Open();

                var SQL = (from se in ctxs.Sessaos
                           select se).ToList();

                List<Sessao> xListAux = new List<Sessao>();
                Busca = CFormato.FormataBusca(Busca);

                foreach (Sessao se in SQL)
                {
                    if (CFormato.FormataBusca(se.nomefunc).Contains(Busca)
                        || CFormato.LimpaString(CFormato.FormataBusca(se.nomePaciente)).Contains(CFormato.LimpaString(Busca))
                        || CFormato.FormataBusca(se.DataSessao.ToString()).Contains(Busca))
                    {
                        xListAux.Add(se);
                    }
                }

                return xListAux;
            }
        }       

        #endregion
    }
    
}
