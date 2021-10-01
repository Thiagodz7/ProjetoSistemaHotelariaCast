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

namespace ProjetoMédioCastGroup
{
    public partial class FrmCadastrarClientes : Form
    {
        SqlConnection conn = Conexao.obterConexao();
        SqlCommand objComandoSql = new SqlCommand();

        public FrmCadastrarClientes()
        {
            InitializeComponent();
        }
        private void FrmCadastrarClientes_Load(object sender, EventArgs e)
        {
            desabilitaCampos();
            MostrarDadosAtendente();
        }

        private void desabilitaCampos()
        {
            txtNome.Enabled = false;
            mskCpf.Enabled = false;
            txtIdade.Enabled = false;
            txtTelefone.Enabled = false;
            btnAlterar.Enabled = false;
            btnSalvar.Enabled = false;
            btnDeletar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            mskCpf.Enabled = true;
            txtIdade.Enabled = true;
            txtTelefone.Enabled = true;

            txtNome.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnCancelar.Enabled = true;
            txtPesquisar.Enabled = true;
            habilitarCampos();
        }

        private void MostrarDadosAtendente()
        {
            conn = Conexao.obterConexao();
            DataTable tb = new DataTable();
            string Query = " select * from tbClientes;";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            da.Fill(tb);
            dgvCliente.DataSource = tb;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                conn = Conexao.obterConexao();
                txtNome.Enabled = true;
                mskCpf.Enabled = true;
                txtIdade.Enabled = true;
                txtTelefone.Enabled = true;

                string query = $"INSERT INTO tbClientes(nome_Cliente,cpf,idade,telefone) values ('{txtNome.Text}','{mskCpf.Text}',{txtIdade.Text},'{txtTelefone.Text}')";

                objComandoSql = new SqlCommand(query, conn);
                objComandoSql.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show("" + erro);
            }
            finally
            {
                txtNome.Focus();

                MessageBox.Show("Salvo com Sucesso!");
                btnCancelar.Enabled = true;
                btnNovo.Enabled = true;
                MostrarDadosAtendente();
            }
        }
    }
}
