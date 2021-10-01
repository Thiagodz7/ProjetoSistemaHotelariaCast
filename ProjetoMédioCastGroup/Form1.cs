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
    public partial class FrmPrincipal : Form
    {
        public SqlDataReader dtReader;
        SqlCommand objComandoSql = new SqlCommand();
        SqlConnection conn;

        string query;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool VerificaTextBox()
        {
            bool confirma = true;

            if (txtIdFuncionario.Text == "")
            {
                MessageBox.Show("Obrigatório campo " + '"' + "Login" + '"');
                txtIdFuncionario.Focus();
                confirma = false;
                return confirma;
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório campo  " + '"' + "Nome" + '"');
                txtSenha.Focus();
                confirma = false;
                return confirma;
            }
            return confirma;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            if (VerificaTextBox() == true)
            {
                Conexao.idFuncionario = Convert.ToInt32(txtIdFuncionario.Text);
                conn = Conexao.obterConexao();
                objComandoSql.Connection = conn;
                query = $"Select * from tbLogin where id_Funcionário=({txtIdFuncionario.Text}) and senha=('{txtSenha.Text}');";

                try
                {
                    objComandoSql.CommandText = query;
                    objComandoSql.Connection = conn;

                    dtReader = objComandoSql.ExecuteReader();
 
                    if (dtReader.HasRows)
                    {
                        FrmMenu Menu = new FrmMenu();
                        Menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou Senha Incorretos");
                    }

                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
