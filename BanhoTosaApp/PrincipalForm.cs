using BanhoTosaApp.Resources;
using BanhoTosaApp.util;
using System;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new ClienteForm());
        }

        private void btnTelaTipoPets_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new TipoPetForm());
        }

        private void btnTelaPets_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new PetForm());
        }

        private void btnTelaBanhoTosa_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new BanhoTosaForm());
        }
    }
}
