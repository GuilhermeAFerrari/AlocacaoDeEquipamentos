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
    public partial class frmServidor : Form
    {
        int operacao = 0;
        public frmServidor()
        {
            InitializeComponent();
            formatacao();
            telaInicial();
            txtStatus.ReadOnly = true;
        }
        public void telaInicial()
        {
            carregarList(lstNomes, "SELECT ID_SERVIDOR, PRONTUARIO_SERVIDOR FROM SERVIDOR INNER JOIN PESSOA ON SERVIDOR.ID_PESSOA = PESSOA.ID_PESSOA WHERE STATUS_PESSOA ='ATIVO'");
            gbxList.Enabled = true;
            rdtAtivo.Checked = true;
            gbxDados.Enabled = false;
            btnIncluir.Enabled = true;
            btnEditar.Enabled = false;
            btnInativar.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            txtStatus.Text = "";
            txtStatus.ReadOnly = true;
        }

        public void formatacao()
        {
            txtProntuario.MaxLength = 7;
            txtNome.MaxLength = 100;
            txtRg.MaxLength = 12;
            txtCpf.MaxLength = 14;
            txtEmail.MaxLength = 50;
            txtTelefone.MaxLength = 17;
            txtCargo.MaxLength = 100;
            txtProcurar.MaxLength = 50;
            txtProcurar.CharacterCasing = CharacterCasing.Upper;
        }
        public void limpar()
        {
            txtProntuario.Text = "";
            txtProntuario.Text = "";
            txtNome.Text = "";
            txtRg.Text = "";
            txtCpf.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
            txtCargo.Text = "";
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

        public void exibirDados(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            //Falta arrumar aqui
            SqlCommand cmd = new SqlCommand("SELECT * FROM SERVIDOR INNER JOIN PESSOA ON SERVIDOR.ID_PESSOA = PESSOA.ID_PESSOA WHERE ID_SERVIDOR =@ID_SERVIDOR", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID_SERVIDOR", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtIdPessoa.Text = dr[("ID_PESSOA")].ToString();
                txtNome.Text = dr[("NOME_PESSOA")].ToString();
                txtProntuario.Text = dr[("PRONTUARIO_SERVIDOR")].ToString();
                txtRg.Text = dr[("RG_PESSOA")].ToString();
                txtCpf.Text = dr[("CPF_PESSOA")].ToString();
                cmbStatus.Text = dr[("STATUS_PESSOA")].ToString();
                txtTelefone.Text = dr[("TELEFONE1")].ToString();
                txtEmail.Text = dr[("EMAIL1")].ToString();
                txtCargo.Text = dr[("CURSO")].ToString();
                txtNascimento.Text = dr[("DT_NASCIMENTO")].ToString();
                txtIdServidor.Text = dr[("ID_SERVIDOR")].ToString();
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

        public int autoIncremento(String query)
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand(query, conexao.conexao);
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
            catch 
            {
                // MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message, "ERRO");
                return 1;
            }
            finally
            {
                dr.Close();
                conexao.desconectar();
            }
        }

        private void mestre()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd;

            try
            {
                cmd = new SqlCommand("INSERT INTO PESSOA (ID_PESSOA, NOME_PESSOA, RG_PESSOA, CPF_PESSOA, EMAIL1, DT_NASCIMENTO, TELEFONE1, STATUS_PESSOA) VALUES (@ID_PESSOA, @NOME_PESSOA, @RG_PESSOA, @CPF_PESSOA, @EMAIL1, @DT_NASCIMENTO, @TELEFONE1, @STATUS_PESSOA)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_PESSOA", Convert.ToInt32(txtIdPessoa.Text));
                cmd.Parameters.AddWithValue("@NOME_PESSOA", txtNome.Text);
                cmd.Parameters.AddWithValue("@RG_PESSOA", txtRg.Text);
                cmd.Parameters.AddWithValue("@CPF_PESSOA", txtCpf.Text);
                cmd.Parameters.AddWithValue("@EMAIL1", txtEmail.Text);
                cmd.Parameters.AddWithValue("@DT_NASCIMENTO", Convert.ToDateTime(txtNascimento.Text));
                cmd.Parameters.AddWithValue("@TELEFONE1", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@STATUS_PESSOA", cmbStatus.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void detalhe()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("INSERT INTO SERVIDOR (ID_SERVIDOR, ID_PESSOA, PRONTUARIO_SERVIDOR, CARGO) VALUES (@ID_SERVIDOR, @ID_PESSOA, @PRONTUARIO_SERVIDOR, @CARGO)", conexao.conexao);
                cmd.Parameters.AddWithValue("@ID_SERVIDOR", Convert.ToInt32(txtIdServidor.Text));
                cmd.Parameters.AddWithValue("@ID_PESSOA", Convert.ToInt32(txtIdPessoa.Text));
                cmd.Parameters.AddWithValue("@PRONTUARIO_SERVIDOR", txtProntuario.Text);
                cmd.Parameters.AddWithValue("@CARGO", txtCargo.Text);
                cmd.ExecuteReader(CommandBehavior.SingleRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro. " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }

        private void atualiza()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("UPDATE PESSOA SET NOME_PESSOA = @NOME_PESSOA, RG_PESSOA = @RG_PESSOA, CPF_PESSOA = @CPF_PESSOA, DT_NASCIMENTO =  @DT_NASCIMENTO, STATUS_PESSOA = @STATUS_PESSOA, TELEFONE1 = @TELEFONE1, EMAIL1 = @EMAIL1 WHERE ID_PESSOA = @ID_PESSOA", conexao.conexao);
                cmd.Parameters.AddWithValue("@NOME_PESSOA", txtNome.Text);
                cmd.Parameters.AddWithValue("@RG_PESSOA", txtRg.Text);
                cmd.Parameters.AddWithValue("@CPF_PESSOA", txtCpf.Text);
                cmd.Parameters.AddWithValue("@DT_NASCIMENTO", Convert.ToDateTime(txtNascimento.Text));
                cmd.Parameters.AddWithValue("@STATUS_PESSOA", cmbStatus.Text);
                cmd.Parameters.AddWithValue("@TELEFONE1", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@EMAIL1", txtEmail.Text);
                cmd.Parameters.AddWithValue("@ID_PESSOA", txtIdPessoa.Text);
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
                btnInativar.Enabled = true;
                txtStatus.Text = "Visualizando";
                txtStatus.ReadOnly = true;
            }
        }

        private void atualizarListBox()
        {
            if (rdtAtivo.Checked == true)
            {
                carregarList(lstNomes, "SELECT ID_SERVIDOR, PRONTUARIO_SERVIDOR FROM SERVIDOR INNER JOIN PESSOA ON SERVIDOR.ID_PESSOA = PESSOA.ID_PESSOA WHERE STATUS_PESSOA ='ATIVO'");
            }
            else
            {
                carregarList(lstNomes, "SELECT ID_SERVIDOR, PRONTUARIO_SERVIDOR FROM SERVIDOR INNER JOIN PESSOA ON SERVIDOR.ID_PESSOA = PESSOA.ID_PESSOA WHERE STATUS_PESSOA ='INATIVO'");
            }
        }

        private void btnIncluir_Click_1(object sender, EventArgs e)
        {
            operacao = 1;
            gbxDados.Enabled = true;
            gbxList.Enabled = false;
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnInativar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtIdPessoa.Enabled = false;
            txtIdServidor.Enabled = false;
            txtCargo.Enabled = false;
            txtProntuario.Enabled = false;
            txtCargo.Enabled = true;
            txtProntuario.Enabled = true;
            limpar();
            txtIdServidor.Text = "1";
            txtIdPessoa.Text = "1";
            txtIdServidor.Text = autoIncremento("SELECT MAX(ID_SERVIDOR)+1 AS IDNOVO FROM SERVIDOR").ToString();
            txtIdPessoa.Text = autoIncremento("SELECT MAX(ID_PESSOA)+1 AS IDNOVO FROM PESSOA").ToString();
            txtStatus.Text = "Incluindo";
            txtStatus.ReadOnly = true;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            txtStatus.Text = "Editando";
            operacao = 2;
            gbxDados.Enabled = true;
            gbxList.Enabled = false;
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnInativar.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtIdServidor.Enabled = false;
            txtIdPessoa.Enabled = false;
            txtCargo.Enabled = false;
            txtProntuario.Enabled = false;
            txtNome.Focus();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd;
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja INATIVAR este Equipamento?", "Confirma a INATIVAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iResposta.ToString() == "Yes")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE PESSOA SET STATUS_PESSOA = 'INATIVO' WHERE ID_PESSOA = @ID_PESSOA", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_PESSOA", txtIdPessoa.Text);
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

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            if (operacao == 1)
            {
                mestre();
                detalhe();
                limpar();
                telaInicial();
            }

            else
            {
                atualiza();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            limpar();
            telaInicial();
        }

        private void rdtAtivo_CheckedChanged_1(object sender, EventArgs e)
        {
            atualizarListBox();
        }

        private void rdtInativo_CheckedChanged_1(object sender, EventArgs e)
        {
            atualizarListBox();
        }

        private void txtProcurar_TextChanged_1(object sender, EventArgs e)
        {
            string sqlString = "";
            sqlString = "SELECT ID_SERVIDOR, PRONTUARIO_SERVIDOR FROM SERVIDOR WHERE PRONTUARIO_SERVIDOR LIKE '%" + txtProcurar.Text + "%'";
            carregarList(lstNomes, sqlString);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gbxOpcoes_Enter(object sender, EventArgs e)
        {

        }
    }
}
