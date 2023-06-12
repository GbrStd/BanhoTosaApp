using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using BanhoTosaApp.util;
using System;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class PetForm : Form
    {
        public PetForm()
        {
            InitializeComponent();
        }
        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new PrincipalForm());
        }

        private void LoadGrid()
        {
            dgvPets.DataSource = PetRepository.FindAll();
            dgvPets.Refresh();
            dgvPets.AutoResizeColumns();
        }

        private Pet GetSelected()
        {
            if (dgvPets.CurrentRow == null)
                return null;
            Object selected = dgvPets.CurrentRow.DataBoundItem;
            if (selected == null)
                return null;
            return (Pet)selected;
        }

        private void PetForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadGrid();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            PetDataForm criarPetForm = new PetDataForm(null);
            criarPetForm.ShowDialog();
            LoadGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Pet p = GetSelected();
                if (p == null)
                    return;
                PetRepository.DeleteById(p.Id);
                LoadGrid();
            }
        }

        private void dgvPets_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pet p = GetSelected();
            if (p != null)
            {
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pet p = GetSelected();
            if (p == null)
                return;
            PetDataForm petDataForm = new PetDataForm(p);
            petDataForm.ShowDialog();
            LoadGrid();
        }
    }
}
