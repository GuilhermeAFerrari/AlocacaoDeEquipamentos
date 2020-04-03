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
    public partial class frmEquipamento : Form
    {
        int operacao = 0;
        public frmEquipamento()
        {
            InitializeComponent();
            formatacao();
            telaInicial();
            txtStatus.ReadOnly = true;
        }

        public void telaInicial()
        {
            carregarList(lstEquipamento, "SELECT ID_EQUIPAMENTO, NOME_EQUIPAMENTO FROM EQUIPAMENTO WHERE STATUS_EQUIPAMENTO = 'ATIVO'");
            gbxList.Enabled = true;
            rdtAtivo.Checked = true;
            gbxList.Enabled = true;
            gbxDados.Enabled = false;
            btnIncluir.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            txtStatus.Text = "";
            txtStatus.ReadOnly = true;
        }

        public void formatacao()
        {
            txtNomeEquipamento.MaxLength = 50;
            txtDescricao.MaxLength = 200;
            txtPatrimonio.MaxLength = 5;
            txtProcurar.MaxLength = 50;
            txtNomeEquipamento.CharacterCasing = CharacterCasing.Upper;
            txtProcurar.CharacterCasing = CharacterCasing.Upper;
            txtDescricao.CharacterCasing = CharacterCasing.Upper;
        }

        public void limpar()
        {
            txtNomeEquipamento.Text = "";
            txtDescricao.Text = "";
            txtProcurar.Text = "";
            txtPatrimonio.Text = "";
            txtStatus.Text = "";
            txtIdEquipamento.Text = "";
            txtNomeEquipamento.Focus();
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
            txtIdEquipamento.Enabled = false;
            limpar();
            txtIdEquipamento.Text = autoIncremento().ToString();
            txtStatus.Text = "Incluindo";
            txtStatus.ReadOnly = true;
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_EQUIPAMENTO)+1 AS IDNOVO FROM EQUIPAMENTO", conexao.conexao);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpar();
            telaInicial();
        }

        public void exibirDados(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            //Falta arrumar aqui
            SqlCommand cmd = new SqlCommand("SELECT * FROM EQUIPAMENTO WHERE ID_EQUIPAMENTO =@ID_EQUIPAMENTO", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtIdEquipamento.Text = dr[("ID_EQUIPAMENTO")].ToString();
                txtNomeEquipamento.Text = dr[("NOME_EQUIPAMENTO")].ToString();
                txtDescricao.Text = dr[("DESCRICAO_EQUIPAMENTO")].ToString();
                txtPatrimonio.Text = dr[("NUM_PATRIMONIO")].ToString();
                cmbStatus.Text = dr[("STATUS_EQUIPAMENTO")].ToString();
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

        private void lstEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] campo = lstEquipamento.Text.Split(Convert.ToChar("\t"));
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtStatus.Text = "Editando";
            operacao = 2;
            gbxDados.Enabled = true;
            gbxList.Enabled = false;
            btnIncluir.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            txtIdEquipamento.Enabled = false;
            txtNomeEquipamento.Focus();
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
                    cmd = new SqlCommand("INSERT INTO EQUIPAMENTO (ID_EQUIPAMENTO, NOME_EQUIPAMENTO, NUM_PATRIMONIO, DESCRICAO_EQUIPAMENTO, STATUS_EQUIPAMENTO) VALUES (@ID_EQUIPAMENTO, @NOME_EQUIPAMENTO, @NUM_PATRIMONIO, @DESCRICAO_EQUIPAMENTO, @STATUS_EQUIPAMENTO)", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", Convert.ToInt32(txtIdEquipamento.Text));
                    cmd.Parameters.AddWithValue("@NOME_EQUIPAMENTO", txtNomeEquipamento.Text);
                    cmd.Parameters.AddWithValue("@NUM_PATRIMONIO", txtPatrimonio.Text);
                    cmd.Parameters.AddWithValue("@DESCRICAO_EQUIPAMENTO", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@STATUS_EQUIPAMENTO", cmbStatus.Text);

                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
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
                    cmd = new SqlCommand("UPDATE EQUIPAMENTO SET  NOME_EQUIPAMENTO = @NOME_EQUIPAMENTO, NUM_PATRIMONIO = @NUM_PATRIMONIO, DESCRICAO_EQUIPAMENTO = @DESCRICAO_EQUIPAMENTO, STATUS_EQUIPAMENTO = @STATUS_EQUIPAMENTO WHERE ID_EQUIPAMENTO = @ID_EQUIPAMENTO", conexao.conexao);
                    cmd.Parameters.AddWithValue("@NOME_EQUIPAMENTO", txtNomeEquipamento.Text);
                    cmd.Parameters.AddWithValue("@NUM_PATRIMONIO", txtPatrimonio.Text);
                    cmd.Parameters.AddWithValue("@DESCRICAO_EQUIPAMENTO", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@STATUS_EQUIPAMENTO", cmbStatus.Text);
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", Convert.ToInt32(txtIdEquipamento.Text));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                    limpar();
                    telaInicial();
                }
            }
        }

        private void txtProcurar_TextChanged(object sender, EventArgs e)
        {
            string sqlString = "";
            sqlString = "SELECT ID_EQUIPAMENTO, NOME_EQUIPAMENTO FROM EQUIPAMENTO WHERE NOME_EQUIPAMENTO LIKE '%" + txtProcurar.Text + "%'";
            carregarList(lstEquipamento, sqlString);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja INATIVAR este Equipamento?", "Confirma a INATIVAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iResposta.ToString() == "Yes")
            {
                Conexao conexao = new Conexao();
                conexao.conectar();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("UPDATE EQUIPAMENTO SET  STATUS_EQUIPAMENTO = 'INATIVO' WHERE ID_EQUIPAMENTO = @ID_EQUIPAMENTO", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", Convert.ToInt32(txtIdEquipamento.Text));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                    limpar();
                    telaInicial();
                }
            }
        }

        private void atualizarListBox()
        {
            if (rdtAtivo.Checked == true)
            {
                carregarList(lstEquipamento, "SELECT ID_EQUIPAMENTO, NOME_EQUIPAMENTO FROM EQUIPAMENTO WHERE STATUS_EQUIPAMENTO = 'ATIVO'");
            }
            else
            {
                carregarList(lstEquipamento, "SELECT ID_EQUIPAMENTO, NOME_EQUIPAMENTO FROM EQUIPAMENTO WHERE STATUS_EQUIPAMENTO = 'INATIVO'");
            }
        }

        private void rdtAtivo_CheckedChanged(object sender, EventArgs e)
        {
            atualizarListBox();
        }

        private void rdtInativo_CheckedChanged(object sender, EventArgs e)
        {
            atualizarListBox();
        }

        private void gbxList_Enter(object sender, EventArgs e)
        {

        }
    }
}

