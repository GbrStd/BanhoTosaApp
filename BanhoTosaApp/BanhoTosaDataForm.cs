using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class BanhoTosaDataForm : Form
    {

        private BanhoTosa BanhoTosa { get; set; }

        public BanhoTosaDataForm(BanhoTosa banhoTosa)
        {
            InitializeComponent();
            BanhoTosa = banhoTosa;
        }

        private BanhoTosa CriarBanhoTosa()
        {
            BanhoTosa bt = new BanhoTosa();
            bt.Pet = (Pet)comboBoxPet.SelectedItem;
            DateTime data = dataAgenda.Value;
            DateTime horario = horarioAgenda.Value;
            bt.Data = new DateTime(data.Year, data.Month, data.Day, horario.Hour, horario.Minute, horario.Second);
            bt.Tosar = comboBoxTosar.SelectedIndex == 0;
            bt.Observacao = txtObservacao.Text;
            bt.Valor = Convert.ToDouble(txtValor.Text);
            return bt;
        }

        private void LoadCombosData()
        {
            List<Pet> pets = PetRepository.FindAll();

            if (pets.Count > 0)
            {
                comboBoxPet.DataSource = pets;
                comboBoxPet.SelectedIndex = 0;
            }
            else
            {
                comboBoxPet.Items.Add("NADA");
                comboBoxPet.SelectedIndex = 0;
                comboBoxPet.Enabled = false;
            }

            btnAcao.Enabled = comboBoxPet.Enabled;
        }

        private void BanhoTosaDataForm_Load(object sender, EventArgs e)
        {
            LoadCombosData();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (BanhoTosa == null)
            {
                this.Text = "Agendar";
                lblModo.Text = "AGENDAMENTO";
                btnAcao.Text = "AGENDAR";
                comboBoxTosar.SelectedIndex = 0;
            }
            else
            {
                comboBoxPet.Text = BanhoTosa.Pet.Nome;
                dataAgenda.Value = BanhoTosa.Data;
                horarioAgenda.Value = BanhoTosa.Data;
                comboBoxTosar.SelectedIndex = BanhoTosa.Tosar ? 0 : 1;
                txtObservacao.Text = BanhoTosa.Observacao;
                txtValor.Text = BanhoTosa.Valor.ToString();
                this.Name = "Atualizar - " + BanhoTosa.Pet.Nome;
                lblModo.Text = "ATUALIZANDO - " + BanhoTosa.Pet.Nome.ToUpper();
                btnAcao.Text = "ATUALIZAR";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (BanhoTosa == null) // criar
            {
                BanhoTosa bt = CriarBanhoTosa();
                BanhoTosaRepository.Insert(bt);
                this.Dispose(true);
            }
            else // atualizar
            {
                BanhoTosa bt = CriarBanhoTosa();
                bt.Id = BanhoTosa.Id;
                BanhoTosaRepository.Update(bt);
                this.Dispose(true);
            }
        }
    }
}
