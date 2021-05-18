using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    class Utils
    {
        public static HttpClient client = new HttpClient();

        public static string sToken = string.Empty;

        public static string sServidor = "https://localhost:44341/";

        public static void apresentaMensagemTextoNulo(string _sCampo)
        {
            System.Windows.Forms.MessageBox.Show("O campo [" + _sCampo + "] não pode ser nulo!");
        }

        public static string Encriptar(string _sTexto)
        {
            try
            {
                //Deve arranjar um método para gerar uma salt para cada utilizador:
                //string _sSalt = BCrypt.Net.BCrypt.GenerateSalt(8);

                string _sSalt = "$2a$08$GgWFgyiEHEW/LoNRvawsZO";

                string _sHash = BCrypt.Net.BCrypt.HashPassword(_sTexto, _sSalt);

                return _sHash;
            }

            catch
            {
                return string.Empty;
            }
        }
    }
}
