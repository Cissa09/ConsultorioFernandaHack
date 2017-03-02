using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ConsultorioFernandaHackLib
{
    public class CUtil
    {
        public static void Msg(string Mensagem)
        {
            MessageBox.Show(Mensagem, "Consultorio Fernanda Hackenhaar", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
        }

        public static void MsgErro(string Mensagem)
        {
           MessageBox.Show(Mensagem, "Consultorio Fernanda Hackenhaar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
