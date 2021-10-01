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
        FrmInicio bemVindo = new FrmInicio();

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {
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
            }
        }
    }
}
