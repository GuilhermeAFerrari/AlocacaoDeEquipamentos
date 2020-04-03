using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace formUsuario
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            string query = "SELECT * FROM USUARIO WHERE PRONTUARIO=@PRONTUARIO AND SENHA=@SENHA";

            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            cmd.Parameters.AddWithValue("@PRONTUARIO", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@SENHA", txtSenha.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Autenticacao.login(dr["prontuario"].ToString(), dr["senha"].ToString());
                //MessageBox.Show(Autenticacao.getUsuario());
                frmPrincipal fmp = new frmPrincipal();
                fmp.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("ERRO: Usuário e/ou Senha não encontrado");
            }
            dr.Close();
            conexao.desconectar();
        }
    }
}
