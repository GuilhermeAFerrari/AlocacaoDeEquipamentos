using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace formUsuario
{
    class Conexao
    {
        public SqlConnection conexao = new SqlConnection();

        public void conectar()
        {
            conexao.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Guilherme Ferrari\Desktop\formUsuario\formUsuario\formUsuario\gjmBanco.mdf;Integrated Security=True";
            conexao.Open();
        }

        public void desconectar()
        {
            conexao.Close();
        }
    }
}
