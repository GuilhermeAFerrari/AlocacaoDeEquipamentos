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
    public partial class frmUsuario : Form
    {
        int operacao = 0;
        public frmUsuario()
        {
            InitializeComponent();
            formatacao();
            telaInicial();
            txtStatus.ReadOnly = true;
        }
       
        public void telaInicial()
        {
            carregarList(lstNomes, "SELECT PRONTUARIO FROM USUARIO WHERE STATUS = 'ATIVO'");
            gbxList.Enabled = true;
            gbxDados.Enabled = false;
            btnIncluir.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            txtStatus.Text = "";
            txtStatus.ReadOnly = true;
            txtSenha.Enabled = false;
        }

        public void formatacao()
        {
            txtProntuario.MaxLength = 7;          
            txtSenha.MaxLength = 50;
            txtProcurar.MaxLength = 50;
            txtProcurar.CharacterCasing = CharacterCasing.Upper;
        }
         public void limpar()
        {
            txtProntuario.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtStatus.Text = "";
            txtSenha.Text = "";
            txtNome.Focus();
        }

        private void validarTexto(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void somenteNumero(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void exibirDados(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIO WHERE PRONTUARIO = @PRONTUARIO", conexao.conexao);
            cmd.Parameters.AddWithValue("@PRONTUARIO", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtId.Text = dr[("ID_USUARIO")].ToString();
                txtNome.Text = dr[("NOME_USUARIO")].ToString();
                txtProntuario.Text = dr[("PRONTUARIO")].ToString();
                txtRg.Text = dr[("RG_USUARIO")].ToString();
                txtCpf.Text = dr[("CPF_USUARIO")].ToString();
                cmbStatus.Text  = dr[("STATUS")].ToString();
                txtSenha.Text = dr[("SENHA")].ToString();
                txtNascimento.Text = dr[("DT_NASCIMENTO")].ToString();

                if (dr[("SENHA")].ToString() == "0000")
                {
                    txtSenha.PasswordChar = '0';
                }
                else
                {
                    txtSenha.PasswordChar = '*';
                }
            }
            else
            {
                foreach (Control ctl in this.Controls)
                {
                    if (ctl is TextBox)
                    {
                        ctl.Text = "";
                    }
                }
            }

            dr.Close();
            conexao.desconectar();
        }

        public static void carregarList(ListBox lst, string query)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            lst.Items.Clear();
            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
            String texto;

            while (dr.Read())
            {
                texto = dr[0].ToString();
                for (int i = 1; i < dr.FieldCount; i++)
                {
                    texto = texto + "\t" + dr[i].ToString();
                }
                lst.Items.Add(texto);
            }
            dr.Close();
            conexao.desconectar();
        }

        private void lstNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] campo = lstNomes.Text.Split(Convert.ToChar("\t"));
            if (campo[0] == "")
            {
                MessageBox.Show("Selecione um nome valido");
            }
            else
            {
                exibirDados(campo[0]);
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                txtStatus.Text = "Visualizando";
                txtStatus.ReadOnly = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            telaInicial();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            operacao = 1;
            gbxDados.Enabled = true;
            gbxList.Enabled = false;
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtId.Enabled = false;
            txtSenha.Enabled = true;
            limpar();
            txtId.Text = autoIncremento().ToString();
            txtStatus.Text = "Incluindo";
            txtStatus.ReadOnly = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja excluir esse usuario?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SqlCommand cmd;
            if (iResposta.ToString() == "Yes")
            {
                Conexao conexao = new Conexao();
                conexao.conectar();

                cmd = new SqlCommand("UPDATE USUARIO SET STATUS = 'INATIVO' WHERE ID_USUARIO = @ID_USUARIO", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_USUARIO", txtId.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);

                conexao.desconectar();
                limpar();
                telaInicial();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd;
            if (operacao == 1)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO USUARIO (ID_USUARIO, NOME_USUARIO, RG_USUARIO, CPF_USUARIO, DT_NASCIMENTO, STATUS, PRONTUARIO, SENHA) VALUES (@ID_USUARIO, @NOME_USUARIO, @RG_USUARIO, @CPF_USUARIO, @DT_NASCIMENTO, @STATUS, @PRONTUARIO, @SENHA)", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_USUARIO", Convert.ToInt32(txtId.Text));
                    cmd.Parameters.AddWithValue("@NOME_USUARIO", txtNome.Text);
                    cmd.Parameters.AddWithValue("@RG_USUARIO", txtRg.Text);
                    cmd.Parameters.AddWithValue("@CPF_USUARIO", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@DT_NASCIMENTO", Convert.ToDateTime(txtNascimento.Text));
                    cmd.Parameters.AddWithValue("@STATUS", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@PRONTUARIO", txtProntuario.Text);
                    cmd.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                    limpar();
                    telaInicial();
                }
            }
            else
            {
                try
                {
                    cmd = new SqlCommand("UPDATE USUARIO SET NOME_USUARIO = @NOME_USUARIO, RG_USUARIO = @RG_USUARIO, CPF_USUARIO = @CPF_USUARIO, DT_NASCIMENTO =  @DT_NASCIMENTO, STATUS = @STATUS, PRONTUARIO = @PRONTUARIO, SENHA = @SENHA WHERE ID = @ID", conexao.conexao);
                    cmd.Parameters.AddWithValue("@NOME_USUARIO", txtNome.Text);
                    cmd.Parameters.AddWithValue("@RG_USUARIO", txtRg.Text);
                    cmd.Parameters.AddWithValue("@CPF_USUARIO", txtCpf.Text);
                    cmd.Parameters.AddWithValue("@DT_NASCIMENTO", Convert.ToDateTime(txtNascimento.Text));
                    cmd.Parameters.AddWithValue("@STATUS", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@PRONTUARIO", txtProntuario.Text);
                    cmd.Parameters.AddWithValue("@SENHA", txtSenha.Text);
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(txtId.Text));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                    limpar();
                    telaInicial();
                }
            }
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_USUARIO)+1 AS IDNOVO FROM USUARIO", conexao.conexao);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            try
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    codigo = Convert.ToInt32(dr["IDNOVO"].ToString());
                    return codigo;
                }
                else
                {
                    codigo = 1;
                    return codigo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                return 0;
            }
            finally
            {
                dr.Close();
                conexao.desconectar();
            }
        }

        private void gbxDados_Enter(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProntuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }  
    }
}
