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
    partial class Colaborador
    {
        
    }

    public class ColaboradorDAL
    {
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();
      
        #region Propriedades

        private Colaborador _colaborador;

        public Colaborador Colaborador
        {
            get { return _colaborador; }
        }

        #endregion

        #region Construtores

        public ColaboradorDAL(int id)
        {
            Retrive(id);
        }

        public ColaboradorDAL()
        {
            _colaborador = new Colaborador();
        }

        public ColaboradorDAL(int id, string nome)
        {
            _colaborador = new Colaborador();
            _colaborador.IDColaborador = id;
            _colaborador.Nome = nome;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Método que carrega a classe com o paciente em questão
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar as propriedades do colaborador</param>
        private void Retrive(int id)
        {
            _colaborador = (from col in ctx.Colaboradors where col.IDColaborador == id select col).FirstOrDefault();
            if (_colaborador == null)
                _colaborador = new Colaborador();

        }

        /// <summary>
        /// Grava o Paciente
        /// </summary>
        /// <returns>IDPaciente que foi gravado</returns>
        public int Grava()
        {
            if (this._colaborador.IDColaborador <= 0)
                ctx.Colaboradors.InsertOnSubmit(_colaborador);
         
            ctx.SubmitChanges();

            return _colaborador.IDColaborador;
        }

        /// <summary>
        /// Exclui o Paciente
        /// </summary>
        public void Excluir()
        {
            if (_colaborador != null && _colaborador.IDColaborador > 0)
            {
                ctx.Colaboradors.DeleteOnSubmit(_colaborador);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir o Colbaborador");
        }

        /// <summary>
        /// Método que busca um colaborador
        /// </summary>
        /// <param name="Busca">Parâmetro passado pelo btnLoc_Click, tras as informacoes que o usuario utiliza para realizar a busca.</param>
        public static IEnumerable Localizar(string Busca)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                ctxs.Connection.Open();

                var SQL = (from col in ctxs.Colaboradors
                           orderby col.Nome
                           select col).ToList();

                List<Colaborador> xListAux = new List<Colaborador>();
                Busca = CFormato.FormataBusca(Busca);

                foreach (Colaborador col in SQL)
                {
                    if (CFormato.FormataBusca(col.Nome).Contains(Busca) 
                        || CFormato.LimpaString(CFormato.FormataBusca(col.Email)).Contains(CFormato.LimpaString(Busca))
                        || CFormato.FormataBusca(col.Telefone1).Contains(Busca)) {
                            xListAux.Add(col);                      
                    }
                }
             
                return xListAux;
            }                       
        }

        
        public static List<Colaborador> BuscaColaborador()
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                var SQL = (from col in ctxs.Colaboradors
                           orderby col.Nome
                           select col).ToList();
                return SQL;
            }
        }

        #endregion

    }
}
