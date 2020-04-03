using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formUsuario
{
    class Autenticacao
    {
        static string usuario;
        static string senha;

        public static void login(string usuario1, string senha1)
        {
            usuario = usuario1;
            senha = senha1;
        }

        public static void logout()
        {
            usuario = null;
            senha = null;
        }

        public static String getUsuario()
        {
            return "Nome: " + usuario + "\nSenha: " + senha;
        }
    }
}
