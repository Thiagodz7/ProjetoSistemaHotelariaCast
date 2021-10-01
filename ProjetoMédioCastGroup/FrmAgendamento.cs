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
    
    public partial class FrmAgendamento : Form
    {
        //variaveis locais
        int idServiço=1, totalDias, totalHospedes;
        float valorEstadia = 20, taxa = 13, valorFinal = 0;
        SqlCommand objComandoSql = new SqlCommand();
        SqlConnection conn;
        string query;
        DateTime checkIn, checkOut;
        bool confirmaAgenda = false;
        public SqlDataReader dtReader;

        public FrmAgendamento()
        {
            InitializeComponent();
        }

        private bool VerificaTextBox()
        {
            bool confirma = true;

            if (txtNumeroQuarto.Text == "")
            {
                MessageBox.Show("Obrigatório campo " + '"' + "Número do Quarto" + '"');
                txtNumeroQuarto.Focus();
                confirma = false;
                return confirma;
            }
            else if (mskCheckIn.Text == "")
            {
                MessageBox.Show("Obrigatório campo  " + '"' + "Check In" + '"');
                mskCheckIn.Focus();
                confirma = false;
                return confirma;
            }
            else if (mskCheckOut.Text == "")
            {
                MessageBox.Show("Obrigatório campo  " + '"' + "Check Out" + '"');
                mskCheckOut.Focus();
                confirma = false;
                return confirma;
            }
            else if (txtNumeroHospedes.Text == "")
            {
                MessageBox.Show("Obrigatório campo  " + '"' + "Número de Hóspedes" + '"');
                txtNumeroHospedes.Focus();
                confirma = false;
                return confirma;
            }
            else if (txtIdCliente.Text == "")
            {
                MessageBox.Show("Obrigatório campo  " + '"' + "Id Cliente" + '"');
                txtIdCliente.Focus();
                confirma = false;
                return confirma;
            }

            return confirma;
        }

        private void LimpaCampos(Control.ControlCollection controles)
        {
            //Faz um laço para todos os controles passados no parâmetro
            foreach (Control ctrl in controles)
            {
                //Se o contorle for um TextBox...
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
            mskCheckIn.Clear();
            mskCheckOut.Clear();
        }

        private void MostrarDadosAtendente()
        {
            conn = Conexao.obterConexao();
            DataTable tb = new DataTable();
            string Query = " select * from Agendamentos;";
            SqlDataAdapter da = new SqlDataAdapter(Query, conn);
            da.Fill(tb);
            dgvAgendamentos.DataSource = tb; 
        }

        private void txtNumeroQuarto_Validated(object sender, EventArgs e)
        {
            conn = Conexao.obterConexao();
            objComandoSql.Connection = conn;
            if(txtNumeroQuarto.Text == "")
            {
            }
            else
            {
                query = $"Select * from tbQuartos where id_Quarto=({txtNumeroQuarto.Text}) and ocupação=('0');";

                try
                {
                    objComandoSql.CommandText = query;
                    objComandoSql.Connection = conn;

                    dtReader = objComandoSql.ExecuteReader();

                    if (!dtReader.HasRows)
                    {
                        MessageBox.Show("Não é possível reservar esse quarto: Quarto Ocupado!");
                        LimpaCampos(this.Controls);
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

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            MostrarDadosAtendente();
            txtValorEstadia.Enabled = false;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            if (VerificaTextBox() == true)
            {
                try
                {
                    conn = Conexao.obterConexao();

                    checkIn = Convert.ToDateTime(mskCheckIn.Text);
                    checkOut = Convert.ToDateTime(mskCheckOut.Text);
                    TimeSpan date = checkOut - checkIn;
                    totalDias = date.Days;
                    valorEstadia = valorEstadia * totalDias;
                    totalHospedes = Convert.ToInt32(txtNumeroHospedes.Text);
                    valorFinal = valorEstadia * totalHospedes;

                    float valorTotal = valorFinal;

                    if (rdBasico.Checked && !rdPremium.Checked)
                    {
                        idServiço = 1;
                    }
                    else if (rdPremium.Checked && !rdBasico.Checked)
                    {
                        idServiço = 2;
                        valorTotal = taxa + valorFinal;
                    }

                    txtValorEstadia.Text = valorTotal.ToString("C");

                    query = $"INSERT INTO Agendamentos(id_Quarto,check_In,check_Out,id_Serviço,numero_Pessoas,Valor_Estadia,id_Cliente,id_Funcionario) VALUES({txtNumeroQuarto.Text},'{mskCheckIn.Text}','{mskCheckOut.Text}','{idServiço}','{txtNumeroHospedes.Text}','{valorTotal}','{txtIdCliente.Text}','{Conexao.idFuncionario}')";

                    objComandoSql = new SqlCommand(query, conn);
                    objComandoSql.ExecuteNonQuery();

                    MessageBox.Show("Salvo com Sucesso!");
                    MostrarDadosAtendente();

                    confirmaAgenda = true;
                    if (confirmaAgenda == true)
                    {
                        try
                        {
                            string query2;
                            SqlConnection conn = Conexao.obterConexao();
                            objComandoSql.Connection = conn;

                            query2 = $"UPDATE tbQuartos SET ocupação = '1' WHERE id_Quarto = {txtNumeroQuarto.Text}";
                            objComandoSql.CommandText = query2;

                            objComandoSql.ExecuteNonQuery();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    txtNumeroQuarto.Focus();
                    conn.Close();
                    LimpaCampos(this.Controls);

                    valorEstadia = 20;
                    taxa = 13;
                    valorFinal = 0;
                }
            }
        }


    }
}
