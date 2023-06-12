using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using BanhoTosaApp.util;
using System;
using System.Windows.Forms;

namespace BanhoTosaApp.Resources
{
    public partial class TipoPetForm : Form
    {
        public TipoPetForm()
        {
            InitializeComponent();
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new PrincipalForm());
        }

        private void LoadGrid()
        {
            dgvTipoPet.DataSource = TipoPetRepository.FindAll();
            dgvTipoPet.Refresh();
            dgvTipoPet.AutoResizeColumns();
        }

        private TipoPet CriarTipoPet()
        {
            TipoPet tipoPet = new TipoPet();
            tipoPet.Nome = txtNome.Text;
            return tipoPet;
        }

        private TipoPet GetSelected()
        {
            if (dgvTipoPet.CurrentRow == null)
                return null;
            Object selected = dgvTipoPet.CurrentRow.DataBoundItem;
            if (selected == null)
                return null;
            return (TipoPet)selected;
        }

        private void TipoPetForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadGrid();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            TipoPet tipoPet = CriarTipoPet();

            TipoPetRepository.Insert(tipoPet);
            LoadGrid();
        }

        private void dgvTipoPet_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TipoPet t = GetSelected();
            if (t != null)
            {
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

                txtNome.Text = t.Nome;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            TipoPet t = GetSelected();
            if (t == null)
                return;
            TipoPet update = CriarTipoPet();
            update.Id = t.Id;
            TipoPetRepository.Update(update);
            LoadGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TipoPet t = GetSelected();
                if (t == null)
                    return;
                TipoPetRepository.DeleteById(t.Id);
                LoadGrid();
            }
        }
    }
}
