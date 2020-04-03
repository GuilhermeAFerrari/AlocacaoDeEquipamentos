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
    public partial class frmAlocacaoEquipamentoServidor : Form
    {
        public frmAlocacaoEquipamentoServidor()
        {
            InitializeComponent();
            limpar();
            txtIdAlocacao.Text = autoIncremento().ToString();
        }
        int idServidor = 0;
        int idEquip = 0;
        int idAloc = 0;
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
            cbxServidor.DataSource = null;
            cbxEquipamento.DataSource = null;
            dtpDevolucao.Enabled = false;
            dtpLocacao.Enabled = false;
            cmbEntrega.DataSource = null;
            cmbRecebimento.DataSource = null;
            txtResponsavelDevolucao.Enabled = false;
            cmbEntrega.Enabled = false;
            cmbRecebimento.Enabled = false;
            cbxServidor.Enabled = false;
            cbxEquipamento.Enabled = false; 
        }

        public void limpar()
        {
            txtIdAlocacao.Text = "";
            cmbEntrega.Text = "";
            cmbRecebimento.Text = "";
            cbxEquipamento.Text = "";
            cbxServidor.Text = "";
            txtResponsavelDevolucao.Text = "";
            lstAlocacao.Text = "";
            lstAlocacao.Visible = false;
            telaInicial();
        }

        public int autoIncremento()
        {
            int codigo = 0;
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT MAX(ID_ALOCACAO_SERVIDOR)+1 AS IDNOVO FROM ALOCACAOEQUIPAMENTOSERVIDOR", conexao.conexao);
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

        public void carregarServidor()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();

            SqlCommand cmd = new SqlCommand("SELECT ID_SERVIDOR, NOME_PESSOA FROM SERVIDOR INNER JOIN PESSOA ON SERVIDOR.ID_PESSOA = PESSOA.ID_PESSOA WHERE STATUS_PESSOA ='ATIVO'", conexao.conexao);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbxServidor.DisplayMember = "NOME_PESSOA";
            cbxServidor.ValueMember = "ID_SERVIDOR";
            cbxServidor.DataSource = dt;
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

        public void mudarStatusAlocacaoServidorDeslocado()
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("STATUSALOCACAOSERVIDORDESALOCADO", conexao.conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_ALOCACAO_SERVIDOR", idAloc);
            cmd.ExecuteReader(CommandBehavior.SingleRow);
            conexao.desconectar();
            carregarEquipamentos();
        }

        public void exibirDados(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.conectar();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ALOCACAOEQUIPAMENTOSERVIDOR WHERE ID_ALOCACAO_SERVIDOR =@ID_ALOCACAO_SERVIDOR", conexao.conexao);
            cmd.Parameters.AddWithValue("@ID_ALOCACAO_SERVIDOR", nome);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleRow);

            if (dr.Read())
            {
                txtIdAlocacao.Text = dr[("ID_ALOCACAO_SERVIDOR")].ToString();
                idAloc = Convert.ToInt32(dr[("ID_ALOCACAO_SERVIDOR")]);
                cbxEquipamento.Text = dr[("ID_EQUIPAMENTO")].ToString();
                idEquip = Convert.ToInt32(dr[("ID_EQUIPAMENTO")]);
                cbxServidor.Text = dr[("ID_SERVIDOR")].ToString();
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

        private void btnDevolver_Click_1(object sender, EventArgs e)
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
                    cmd = new SqlCommand("UPDATE ALOCACAOEQUIPAMENTOSERVIDOR SET STATUS_ALOCACAO_SERVIDOR = @STATUS_ALOCACAO_SERVIDOR,DATAHORA_DEVOLUCAO = @DATAHORA_DEVOLUCAO,RESPONSAVEL_DEVOLUCAO =@RESPONSAVEL_DEVOLUCAO,VISTO_RECEBIMENTO =@VISTO_RECEBIMENTO WHERE  ID_ALOCACAO_SERVIDOR = @ID_ALOCACAO_SERVIDOR", conexao.conexao);
                    cmd.Parameters.AddWithValue("@STATUS_ALOCACAO_SERVIDOR", "ATIVO");
                    cmd.Parameters.AddWithValue("@DATAHORA_DEVOLUCAO", Convert.ToDateTime(dtpDevolucao.Text));
                    cmd.Parameters.AddWithValue("@RESPONSAVEL_DEVOLUCAO", txtResponsavelDevolucao.Text);
                    cmd.Parameters.AddWithValue("@VISTO_RECEBIMENTO", cmbRecebimento.Text);
                    cmd.Parameters.AddWithValue("@ID_ALOCACAO_SERVIDOR", Convert.ToInt32(txtIdAlocacao.Text));
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
                mudarStatusAlocacaoServidorDeslocado();
                carregarEquipamentos();
                telaInicial();
                limpar();
            }
        }

        private void btnAlocar_Click_1(object sender, EventArgs e)
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
                    cmd = new SqlCommand("INSERT INTO ALOCACAOEQUIPAMENTOSERVIDOR (ID_ALOCACAO_SERVIDOR, ID_EQUIPAMENTO, ID_SERVIDOR,DATAHORA_ALOCACAO,VISTO_ENTREGA,STATUS_ALOCACAO_SERVIDOR,DATAHORA_DEVOLUCAO,RESPONSAVEL_DEVOLUCAO,VISTO_RECEBIMENTO) VALUES (@ID_ALOCACAO_SERVIDOR, @ID_EQUIPAMENTO, @ID_SERVIDOR,@DATAHORA_ALOCACAO,@VISTO_ENTREGA,@STATUS_ALOCACAO_SERVIDOR,@DATAHORA_DEVOLUCAO,@RESPONSAVEL_DEVOLUCAO,@VISTO_RECEBIMENTO)", conexao.conexao);
                    cmd.Parameters.AddWithValue("@ID_ALOCACAO_SERVIDOR", Convert.ToInt32(txtIdAlocacao.Text));
                    cmd.Parameters.AddWithValue("@ID_EQUIPAMENTO", idEquip);
                    cmd.Parameters.AddWithValue("@ID_SERVIDOR", idServidor);
                    cmd.Parameters.AddWithValue("@DATAHORA_ALOCACAO", Convert.ToDateTime(dtpLocacao.Text));
                    cmd.Parameters.AddWithValue("@VISTO_ENTREGA", cmbEntrega.Text);
                    cmd.Parameters.AddWithValue("@STATUS_ALOCACAO_SERVIDOR", "LOCADO");
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
                btnDevolucao.Enabled = true;
                limpar();
            }
        }

        private void btnNova_Click_1(object sender, EventArgs e)
        {
            operacao = 0;
            telaInicial();

            cbxServidor.Enabled = true;
            carregarServidor();
            cmbRecebimento.Enabled = true;
            carregarUsuarios(1);
            cbxServidor.Enabled = true;
            cbxEquipamento.Enabled = true;
            dtpLocacao.Enabled = true;
            cmbEntrega.Enabled = true;
            btnAlocar.Enabled = true;
            btnDevolucao.Enabled = false;
            cmbRecebimento.Enabled = false;
        }

        private void btnDevolucao_Click_1(object sender, EventArgs e)
        {
            limpar();
            lstAlocacao.Visible = true;
            carregarList(lstAlocacao, " Select  distinct alocacaoequipamentoservidor.id_alocacao_servidor, pessoa.nome_pessoa, equipamento.nome_equipamento, alocacaoequipamentoservidor.datahora_alocacao, alocacaoequipamentoservidor.visto_entrega  from pessoa inner join servidor on servidor.id_pessoa = pessoa.id_pessoa inner join alocacaoEquipamentoServidor on servidor.id_servidor = alocacaoEquipamentoServidor.id_servidor inner join equipamento on equipamento.id_equipamento = alocacaoEquipamentoServidor.id_equipamento where equipamento.status_equipamento = 'LOCADO' and alocacaoEquipamentoServidor.status_alocacao_servidor = 'LOCADO'");
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            DialogResult iResposta;
            iResposta = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iResposta.ToString() == "Yes")
            {
                frmPrincipal frmP = new frmPrincipal();
                frmP.Show();
            }
        }

        private void lstAlocacao_SelectedIndexChanged(object sender, EventArgs e)
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
                cbxServidor.Enabled = false;
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

        private void cbxEquipamento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idEquip = Convert.ToInt32(cbxEquipamento.SelectedValue);
        }

        private void cbxServidor_SelectedIndexChanged(object sender, EventArgs e)
        {
            idServidor = Convert.ToInt32(cbxServidor.SelectedValue);
        }

        private void cbxServidor_Leave(object sender, EventArgs e)
        {
            cbxEquipamento.Enabled = true;
            btnAlocar.Enabled = true;
            dtpDevolucao.Enabled = false;
            dtpLocacao.Enabled = false;
            cbxServidor.Enabled = false;
            carregarEquipamentos();
        }

        private void gbxLocacao_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
