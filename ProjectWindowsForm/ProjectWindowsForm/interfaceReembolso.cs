using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWindowsForm
{
    public partial class interfaceReembolso : Form
    {
        public interfaceReembolso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelHome.Visible = true;
            panelCoparticipacao.Visible = false;
            panelRepasseNovo.Visible = false;
            panelRepasseVelho.Visible = false;
            panelSiga.Visible = false;
        }

        private void btnRepasseNovo_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelCoparticipacao.Visible = false;
            panelRepasseNovo.Visible = true;
            panelRepasseVelho.Visible = false;
            panelSiga.Visible = false;
            panelHome.Visible = false;
        }

        private void btnRepasseVelho_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelCoparticipacao.Visible = false;
            panelRepasseNovo.Visible = false;
            panelRepasseVelho.Visible = true;
            panelSiga.Visible = false;
            panelHome.Visible = false;
        }

        private void btnCoparticipacao_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelCoparticipacao.Visible = true;
            panelRepasseNovo.Visible = false;
            panelRepasseVelho.Visible = false;
            panelSiga.Visible = false;
            panelHome.Visible = false;
        }

        private void btnSiga_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = true;
            panelCoparticipacao.Visible = false;
            panelRepasseNovo.Visible = false;
            panelRepasseVelho.Visible = false;
            panelSiga.Visible = true;
            panelHome.Visible = false;
        }
    }
}
