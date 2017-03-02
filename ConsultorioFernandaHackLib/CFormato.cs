using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioFernandaHackLib
{
    public class CFormato
    {
        public static string FormataBuscaSql(string busca)
        {
            return "%" + busca + "%";
        }

        public static string FormataBusca(string Campo)
        {
            if (String.IsNullOrEmpty(Campo))
                return "";
            else
            {
                //Remove espaços e dexa tudo minúsculo
                Campo = Campo.Trim().ToLower();
                //remove cedilha e acentos agudos
                Campo = Campo.Replace("ç", "c").Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u");
                //remove tios e circunflexos
                Campo = Campo.Replace("ã", "a").Replace("õ", "o").Replace("â", "a").Replace("ê", "e").Replace("ô", "o");

                return Campo;
            }
        }

        public static string LimpaString(string Valor)
        {
            return Valor.Replace(".", "").Replace("/", "").Replace("-", "").Replace(",", "").Replace("(", "").Replace(")", "").Trim();
        }
    }
}
