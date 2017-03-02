using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioFernandaHackLib
{
    public class RelatorioDAL
    {
        public static List<vwSessaoHistPgto> RelatorioComissoes(DateTime dataIni, DateTime dataFim, int IDPaciente, int IDColaborador)
        {
         
            using (var ctx = new ConsultorioFernandaHackDataContext())
            {
                List<vwSessaoHistPgto> sql = (from sess in ctx.vwSessaoHistPgtos
                                              where sess.DataSessao.Date >= dataIni.Date && sess.DataSessao.Date <= dataFim.Date
                                              && (sess.IDColaborador == IDColaborador || IDColaborador == 0)
                                              && (sess.IDPaciente == IDPaciente || IDPaciente == 0)                 
                                              orderby sess.IDSessao
                                              select sess).ToList();

                return sql;
            }
        }
    }
}
