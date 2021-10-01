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
        bool limite = false;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
        }

        private void btnModificarServiços_Click(object sender, EventArgs e)
        {
            if(limite == false)
            {
                FrmAgendamento frmAgendamento = new FrmAgendamento();
                frmAgendamento.MdiParent = this;
                frmAgendamento.Show();
                limite = true;
            }
        }
    }
}
