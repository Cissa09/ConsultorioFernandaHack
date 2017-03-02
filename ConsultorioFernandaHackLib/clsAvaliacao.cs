using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.Linq;
using System.Net;
using System.Net.Mail;


namespace ConsultorioFernandaHackLib
{
    public class AvaliacaoDAL
    {
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();
      
        #region Propriedades

        private Avaliacao _avaliacao;

        public Avaliacao Avaliacao
        {
            get { return _avaliacao; }
        }

        #endregion

        #region Construtores

        public AvaliacaoDAL(int id)
        {
            Retrive(id);
        }

        public AvaliacaoDAL()
        {
            _avaliacao = new Avaliacao();
        }

        #endregion

        #region Metodos
     
        /// <summary>
        /// Método que carrega a classe avalicao
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar uma avaliação especifica do paciente</param>
        private void Retrive(int id)
        {
            _avaliacao = (from a in ctx.Avaliacaos where a.IDAvaliacao == id select a).FirstOrDefault();
        }

        /// <summary>
        /// Grava a Avaliação
        /// </summary>
        /// <returns>IDEvolucao que foi gravado</returns>
        public int Grava()
        {
            if (this._avaliacao.IDAvaliacao <= 0)
                ctx.Avaliacaos.InsertOnSubmit(_avaliacao);
         
            ctx.SubmitChanges();

            return _avaliacao.IDAvaliacao;
        }

        /// <summary>
        /// Exclui a Avaliação
        /// </summary>
        public void Excluir()
        {
            if (_avaliacao != null && _avaliacao.IDAvaliacao > 0)
            {
                ctx.Avaliacaos.DeleteOnSubmit(_avaliacao);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir a Avaliação");
        }

        #endregion

    }
}
