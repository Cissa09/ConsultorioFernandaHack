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
    public class PacienteDAL
    {
        /// <summary>
        /// Contexto 
        /// </summary>
        ConsultorioFernandaHackDataContext ctx = new ConsultorioFernandaHackDataContext();
      
        #region Propriedades

        private Paciente _paciente;

        public Paciente Paciente
        {
            get { return _paciente; }
        }

        #endregion

        #region Construtores

        public PacienteDAL(int id)
        {
            Retrive(id);
        }

        public PacienteDAL()
        {
            _paciente = new Paciente();
        }

        public PacienteDAL(int id, string nome)
        {
            _paciente = new Paciente();
            _paciente.IDPaciente = id;
            _paciente.Nome = nome;
        }

        #endregion

        #region Metodos Paciente

        /// <summary>
        /// Método que carrega a classe com o paciente em questão
        /// </summary>
        /// <param name="id">Parâmetro passado pelo construtor para carregar as propriedades do paciente</param>
        private void Retrive(int id)
        {
            _paciente = (from pac in ctx.Pacientes where pac.IDPaciente == id select pac).FirstOrDefault();
            if (_paciente == null)
                _paciente = new Paciente();

        }
           
        /// <summary>
        /// Grava o Paciente
        /// </summary>
        /// <returns>IDPaciente que foi gravado</returns>
        public int Grava()
        {
            if (this._paciente.IDPaciente <= 0)
                ctx.Pacientes.InsertOnSubmit(_paciente);
         
            ctx.SubmitChanges();

            return _paciente.IDPaciente;
        }

        /// <summary>
        /// Exclui o Paciente
        /// </summary>
        public void Excluir()
        {
            if (_paciente != null && _paciente.IDPaciente > 0)
            {
                ctx.Pacientes.DeleteOnSubmit(_paciente);
                ctx.SubmitChanges();
            }
            else
                throw new Exception("Não foi possível Excluir o Paciente");
        }

        /// <summary>
        /// Método que busca um paciente
        /// </summary>
        /// <param name="Busca">Parâmetro passado pelo btnLoc_Click, tras as informacoes que o usuario utiliza para realizar a busca </param>
        public static IEnumerable Localizar(string Busca)
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                ctxs.Connection.Open();

                var SQL = (from pac in ctxs.Pacientes
                           orderby pac.Nome
                           select pac).ToList();

                List<Paciente> xListAux = new List<Paciente>();
                Busca = CFormato.FormataBusca(Busca);

                foreach (Paciente pac in SQL)
                {
                    if (CFormato.FormataBusca(pac.Nome).Contains(Busca) 
                        || CFormato.LimpaString(CFormato.FormataBusca(pac.Email)).Contains(CFormato.LimpaString(Busca))
                        || CFormato.FormataBusca(pac.Telefone).Contains(Busca)) {
                            xListAux.Add(pac);                      
                    }
                }
             
                return xListAux;
            }                       
        }

        public static List<Paciente> BuscaPaciente()
        {
            using (var ctxs = new ConsultorioFernandaHackDataContext())
            {
                var SQL = (from pac in ctxs.Pacientes 
                           orderby pac.Nome                        
                           select pac).ToList();
                return SQL;
            }
        }

        #endregion

        #region Metodos Paciente Evolucao

        /// <summary>
        /// Exclui a Evolução do Paciente
        /// </summary>
        public void ExcluiEvolucao(Evolucao evo)
        {
            ctx.Evolucaos.DeleteOnSubmit(evo);
        }

        public void InsereEvolucao(Evolucao evo)
        {
            ctx.Evolucaos.InsertOnSubmit(evo);
        }

        #endregion

        #region Metodos Paciente Avaliacao

        /// <summary>
        /// Exclui a Avaliação do Paciente
        /// </summary>
        public void ExcluiAvaliacao(Avaliacao ave)
        {
            ctx.Avaliacaos.DeleteOnSubmit(ave);
        }

        public void InsereAvaliacao(Avaliacao ave)
        {
            ctx.Avaliacaos.InsertOnSubmit(ave);
        }

        #endregion

    }
}
