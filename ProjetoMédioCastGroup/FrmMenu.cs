using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMédioCastGroup
{
    public partial class FrmMenu : Form
    {
        //validação
        bool limite = false;
        bool limiteInicio = false;
        bool limiteCliente = false;
        FrmInicio bemVindo = new FrmInicio();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = hora + ":" + segundos + ":" + mSegundos;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            bemVindo.MdiParent = this;
            bemVindo.Show(); 
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (limiteInicio == false)
            {
                FrmInicio inicio = new FrmInicio();
                inicio.MdiParent = this;
                inicio.Show();
                limiteInicio = true;
                limite = false;
                limiteCliente = false;
            }

        }

        private void btnModificarServiços_Click(object sender, EventArgs e)
        {
            bemVindo.Close();
            if (limite == false)
            {
                FrmAgendamento frmAgendamento = new FrmAgendamento();
                frmAgendamento.MdiParent = this;
                frmAgendamento.Show();
                limite = true;
                limiteInicio = false;
                limiteCliente = false;
            }
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            FrmCadastrarClientes cliente = new FrmCadastrarClientes();
            if (limiteCliente == false)
            {
                cliente.MdiParent = this;
                cliente.Show();
                limiteCliente = true;
                limiteInicio = false;
                limite = false;
            }
        }


    }
}
