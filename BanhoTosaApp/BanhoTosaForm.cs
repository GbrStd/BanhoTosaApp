using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using BanhoTosaApp.util;
using System;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class BanhoTosaForm : Form
    {
        public BanhoTosaForm()
        {
            InitializeComponent();
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new PrincipalForm());
        }

        private void LoadGrid()
        {
            dgvBanhoTosa.DataSource = BanhoTosaRepository.FindAll();
            dgvBanhoTosa.Refresh();
            dgvBanhoTosa.AutoResizeColumns();
        }

        private BanhoTosa GetSelected()
        {
            if (dgvBanhoTosa.CurrentRow == null)
                return null;
            Object selected = dgvBanhoTosa.CurrentRow.DataBoundItem;
            if (selected == null)
                return null;
            return (BanhoTosa)selected;
        }

        private void BanhoTosaForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadGrid();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            BanhoTosaDataForm criarBanhoTosaForm = new BanhoTosaDataForm(null);
            criarBanhoTosaForm.ShowDialog();
            LoadGrid();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                BanhoTosa bt = GetSelected();
                if (bt == null)
                    return;
                BanhoTosaRepository.DeleteById(bt.Id);
                LoadGrid();
            }
        }

        private void dgvBanhoTosa_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BanhoTosa bt = GetSelected();
            if (bt != null)
            {
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            BanhoTosa bt = GetSelected();
            if (bt == null)
                return;
            BanhoTosaDataForm banhoTosaDataForm = new BanhoTosaDataForm(bt);
            banhoTosaDataForm.ShowDialog();
            LoadGrid();
        }
    }
}
