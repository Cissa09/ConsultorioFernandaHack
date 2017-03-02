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
    public class EvolucaoDAL
    {
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();
      
        #region Propriedades

        private Evolucao _evolucao;

        public Evolucao Evolucao
        {
            get { return _evolucao; }
        }

        #endregion

        #region Construtores

        public EvolucaoDAL(int id)
        {
            Retrive(id);
        }

        public EvolucaoDAL()
        {
            _evolucao = new Evolucao();
        }

        #endregion

        #region Metodos
     
        /// <summary>
        /// Método que carrega a classe evolucao
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar uma evolucao especifica do paciente</param>
        private void Retrive(int id)
        {
            _evolucao = (from a in ctx.Evolucaos where a.IDEvolucao == id select a).FirstOrDefault();

        }

        /// <summary>
        /// Grava a Evolucao
        /// </summary>
        /// <returns>IDEvolucao que foi gravado</returns>
        public int Grava()
        {
            if (this._evolucao.IDEvolucao <= 0)
                ctx.Evolucaos.InsertOnSubmit(_evolucao);
         
            ctx.SubmitChanges();

            return _evolucao.IDEvolucao;
        }

        /// <summary>
        /// Exclui a Evolução
        /// </summary>
        public void Excluir()
        {
            if (_evolucao != null && _evolucao.IDEvolucao > 0)
            {
                ctx.Evolucaos.DeleteOnSubmit(_evolucao);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir a Evolução");
        }

        #endregion

    }
}
