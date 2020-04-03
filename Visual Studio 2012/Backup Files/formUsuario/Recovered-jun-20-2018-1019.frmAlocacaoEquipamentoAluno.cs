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
    public partial class frmAlocacaoEquipamentoAluno : Form
    {
        public frmAlocacaoEquipamentoAluno()
        {
            InitializeComponent();
            telaInicial();
            txtIdAlocacao.Text = autoIncremento().ToString();
            
        }

        int idAluno = 0;
        int idEquip = 0;
        int operacao = 0;

        public void telaInicial()
        {
            txtIdAlocacao.Text = autoIncremento().ToString();
            txtIdAlocacao.ReadOnly = true;
            txtIdAlocacao.Enabled = false;
            dtpLocacao.Text = DateTime.Now.ToString();
            dtpDevolucao.Text = DateTime.Now.AddDays(1).ToString();
            btnAlocar.Enabled = false;
            btnDevolver.Enabled = false;
            cbxAluno.DataSource = null;
            cbxEquipamento.DataSource = null;
            dtpDevolucao.Enabled = false;
            dtpLocacao.Enabled = false;
            cmbEntrega.DataSource = null;
            cmbRecebimento.DataSource = null;
            txtResponsavelDevolucao.Enabled = false;
            cmbEntrega.Enabled = false;
            cmbRecebimento.Enabled = false;
            cbxAluno.Enabled = false;
            cbxEquipamento.Enabled = false; 
        }

        public void limpar()
        {
            txtIdAlocacao.Text = "";
            txtResponsavelDevolucao.Text = "";

            telaInicial();
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_ALOCACAO_ALUNO)+1 AS IDNOVO FROM ALOCACAOEQUIPAMENTOALUNO", conexao.conexao);
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
                return 1;
            }
            finally
            {
                dr.Close();
                conexao.desconectar();
            }
        }

        public void carregarEquipamentos()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT ID_EQUIPAMENTO, NOME_EQUIPAMENTO FROM EQUIPAMENTO WHERE STATUS_EQUIPAMENTO = 'ATIVO' ORDER BY NOME_EQUIPAMENTO", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxEquipamento.DisplayMember = "NOME_EQUIPAMENTO";
            cbxEquipamento.ValueMember = "ID_EQUIPAMENTO";
            cbxEquipamento.DataSource = dt;
            conexao.desconectar();
        }

        public void carregarAlunos()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT ID_ALUNO, NOME_PESSOA FROM ALUNO INNER JOIN PESSOA ON ALUNO.ID_PESSOA = PESSOA.ID_PESSOA WHERE STATUS_PESSOA ='ATIVO'", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxAluno.DisplayMember = "NOME_PESSOA";
            cbxAluno.ValueMember = "ID_ALUNO";
            cbxAluno.DataSource = dt;
            conexao.desconectar();
        }

        public void carregarUsuarios(int i)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT NOME_USUARIO FROM USUARIO WHERE STATUS = 'ATIVO' ORDER BY NOME_USUARIO", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (i == 1)
            {
                cmbEntrega.DisplayMember = "NOME_USUARIO";
                cmbEntrega.ValueMember = "NOME_USUARIO";
                cmbEntrega.DataSource = dt;
            }
            else
            {
                cmbRecebimento.DisplayMember = "NOME_USUARIO";
                cmbRecebimento.ValueMember = "NOME_USUARIO";
                cmbRecebimento.DataSource = dt;
            }
            
            conexao.desconectar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iResposta.ToString() == "Yes")
            {
                this.Close();
            }
        }

        

        private void cbxAluno_Leave(object sender, EventArgs e)
        {
            cbxEquipamento.Enabled = true;
            btnAlocar.Enabled = true;
            dtpDevolucao.Enabled = false;
            dtpLocacao.Enabled = false;
            cbxAluno.Enabled = false;
            carregarEquipamentos();
        }
        private void cbxEquipamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            idEquip = Convert.ToInt32(cbxEquipamento.SelectedValue);
        }

        private void cbxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            idAluno = Convert.ToInt32(cbxAluno.SelectedValue);
        }
        public void mudarStatusEquipamentoDeslocado()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("STATUSEQUIPAMENTODESALOCADO", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", idEquip);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
            carregarEquipamentos();
        }

        public void mudarStatusEquipamento()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("STATUSEQUIPAMENTOLOCADO", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", idEquip);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
            carregarEquipamentos();
        }

        private void btnAlocar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            operacao = operacao + 1;
            SqlCommand cmd = new SqlCommand();
            TimeSpan diferencaDias = Convert.ToDateTime(dtpDevolucao.Text) - Convert.ToDateTime(dtpLocacao.Text);
            int dias = diferencaDias.Days;

            if (operacao == 1)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO ALOCACAOEQUIPAMENTOALUNO (ID_ALOCACAO_ALUNO, ID_EQUIPAMENTO, ID_ALUNO,DATAHORA_ALOCACAO,VISTO_ENTREGA,STATUS_ALOCACAO_ALUNO,DATAHORA_DEVOLUCAO,RESPONSAVEL_DEVOLUCAO,VISTO_RECEBIMENTO) VALUES (@ID_ALOCACAO_ALUNO, @ID_EQUIPAMENTO, @ID_ALUNO,@DATAHORA_ALOCACAO,@VISTO_ENTREGA,@STATUS_ALOCACAO_ALUNO,@DATAHORA_DEVOLUCAO,@RESPONSAVEL_DEVOLUCAO,@VISTO_RECEBIMENTO)", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_ALOCACAO_ALUNO", Convert.ToInt32(txtIdAlocacao.Text));
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", idEquip);
                    cmd.Parameters.AddWithValue("@ID_ALUNO", idAluno);
                    cmd.Parameters.AddWithValue("@DATAHORA_ALOCACAO", Convert.ToDateTime(dtpLocacao.Text));
                    cmd.Parameters.AddWithValue("@VISTO_ENTREGA", cmbEntrega.Text);
                    cmd.Parameters.AddWithValue("@STATUS_ALOCACAO_ALUNO", "LOCADO");
                    cmd.Parameters.AddWithValue("@DATAHORA_DEVOLUCAO", Convert.ToDateTime(dtpDevolucao.Text));
                    cmd.Parameters.AddWithValue("@RESPONSAVEL_DEVOLUCAO", txtResponsavelDevolucao.Text);
                    cmd.Parameters.AddWithValue("@VISTO_RECEBIMENTO", cmbRecebimento.Text);
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                    MessageBox.Show("Alocação efetuada com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                }

                btnAlocar.Enabled = false;
                btnDevolucao.Enabled = false;
                mudarStatusEquipamento();
                carregarEquipamentos();
                telaInicial();
                carregarList(lstAlocacao, " Select  distinct alocacaoequipamentoaluno.id_alocacao_aluno, pessoa.nome_pessoa, equipamento.nome_equipamento, alocacaoequipamentoaluno.datahora_alocacao, alocacaoequipamentoaluno.visto_entrega  from pessoa inner join aluno on aluno.id_pessoa = pessoa.id_pessoa inner join alocacaoEquipamentoAluno on aluno.id_aluno = alocacaoEquipamentoAluno.id_aluno inner join equipamento on equipamento.id_equipamento = alocacaoEquipamentoAluno.id_equipamento where equipamento.status_equipamento = 'LOCADO'");
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            operacao = operacao + 1;
            SqlCommand cmd = new SqlCommand();
            TimeSpan diferencaDias = Convert.ToDateTime(dtpDevolucao.Text) - Convert.ToDateTime(dtpLocacao.Text);
            int dias = diferencaDias.Days;

            if (operacao == 1)
            {
                try
                {
                    cmd = new SqlCommand("UPDATE ALOCACAOEQUIPAMENTOALUNO SET STATUS_ALOCACAO_ALUNO = @STATUS_ALOCACAO_ALUNO,DATAHORA_DEVOLUCAO = @DATAHORA_DEVOLUCAO,RESPONSAVEL_DEVOLUCAO =@RESPONSAVEL_DEVOLUCAO,VISTO_RECEBIMENTO =@VISTO_RECEBIMENTO WHERE  ID_ALOCACAO_ALUNO = @ID_ALOCACAO_ALUNO", conexao.conexao);
                    cmd.Parameters.AddWithValue("@STATUS_ALOCACAO_ALUNO", "ATIVO");
                    cmd.Parameters.AddWithValue("@DATAHORA_DEVOLUCAO", Convert.ToDateTime(dtpDevolucao.Text));
                    cmd.Parameters.AddWithValue("@RESPONSAVEL_DEVOLUCAO", txtResponsavelDevolucao.Text);
                    cmd.Parameters.AddWithValue("@VISTO_RECEBIMENTO", cmbRecebimento.Text);
                    cmd.Parameters.AddWithValue("@ID_ALOCACAO_ALUNO", Convert.ToInt32(txtIdAlocacao.Text));
                    cmd.ExecuteReader(CommandBehavior.SingleRow);
                    MessageBox.Show("Devolução efetuada com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro. " + ex.Message);
                }
                finally
                {
                    conexao.desconectar();
                }

                btnAlocar.Enabled = false;
                btnDevolver.Enabled = false;
                btnDevolucao.Enabled = true;
                btnNova.Enabled = true;
                btnSair.Enabled = true;
                mudarStatusEquipamentoDeslocado();
                carregarEquipamentos();
                telaInicial();
            }
        }
        private void btnNova_Click(object sender, EventArgs e)
        {
            operacao = 0;
            telaInicial();

            cbxAluno.Enabled = true;
            carregarAlunos();
            cmbRecebimento.Enabled = true;
            carregarUsuarios(1);
            cbxAluno.Enabled = true;
            cbxEquipamento.Enabled = true;
            dtpLocacao.Enabled = true;
            cmbEntrega.Enabled = true;
            btnAlocar.Enabled = true;
            btnDevolucao.Enabled = false;
            cmbRecebimento.Enabled = false;
        }

        public void exibirDados(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ALOCACAOEQUIPAMENTOALUNO WHERE ID_ALOCACAO_ALUNO =@ID_ALOCACAO_ALUNO", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID_ALOCACAO_ALUNO", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtIdAlocacao.Text = dr[("ID_ALOCACAO_ALUNO")].ToString();
                cbxAluno.Text = dr[("ID_EQUIPAMENTO")].ToString();
                idEquip = Convert.ToInt32(dr[("ID_EQUIPAMENTO")]);
                cbxEquipamento.Text = dr[("ID_ALUNO")].ToString();
                dtpLocacao.Text = dr[("DATAHORA_ALOCACAO")].ToString();
                cmbEntrega.Text = dr[("VISTO_ENTREGA")].ToString();
                dtpDevolucao.Text = dr[("DATAHORA_DEVOLUCAO")].ToString();
                txtResponsavelDevolucao.Text = dr[("RESPONSAVEL_DEVOLUCAO")].ToString();
                cmbRecebimento.Text = dr[("VISTO_RECEBIMENTO")].ToString();
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
            operacao = 0;
            telaInicial();
            cmbRecebimento.Enabled = true;
            dtpDevolucao.Enabled = true;
            txtResponsavelDevolucao.Enabled = true;

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

        private void lstAlocacao_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] campo = lstAlocacao.Text.Split(Convert.ToChar("\t"));
            if (campo[0] == "")
            {
                MessageBox.Show("Selecione um nome valido");
            }
            else
            {
                exibirDados(campo[0]);
                txtIdAlocacao.Enabled = false;
                cbxAluno.Enabled = false;
                cbxEquipamento.Enabled = false;
                dtpLocacao.Enabled = false;
                cmbEntrega.Enabled = false;
                btnAlocar.Enabled = false;
                lstAlocacao.Enabled = false;
                btnNova.Enabled = false;
                btnDevolucao.Enabled = false;
                carregarUsuarios(0);
            }
            btnDevolver.Enabled = true;
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            carregarList(lstAlocacao, " Select  distinct alocacaoequipamentoaluno.id_alocacao_aluno, pessoa.nome_pessoa, equipamento.nome_equipamento, alocacaoequipamentoaluno.datahora_alocacao, alocacaoequipamentoaluno.visto_entrega  from pessoa inner join aluno on aluno.id_pessoa = pessoa.id_pessoa inner join alocacaoEquipamentoAluno on aluno.id_aluno = alocacaoEquipamentoAluno.id_aluno inner join equipamento on equipamento.id_equipamento = alocacaoEquipamentoAluno.id_equipamento where equipamento.status_equipamento = 'LOCADO'");
        }
   }
}
