using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class PetDataForm : Form
    {

        private Pet Pet { get; set; }

        public PetDataForm(Pet pet)
        {
            InitializeComponent();
            Pet = pet;
        }

        private Pet CriarPet()
        {
            Pet p = new Pet();
            p.Nome = txtNome.Text;
            p.Raca = txtRaca.Text;
            p.Porte = comboBoxPorte.Text;
            p.TipoPet = (TipoPet)comboBoxTipo.SelectedItem;
            p.Dono = (Pessoa)comboBoxDono.SelectedItem;
            p.DataNascimento = dataNasc.Value;
            return p;
        }

        private void LoadCombosData()
        {
            List<TipoPet> tipos = TipoPetRepository.FindAll();
            List<Pessoa> pessoas = PessoaRepository.FindAll();

            if (tipos.Count > 0)
            {
                comboBoxTipo.DataSource = tipos;
                comboBoxTipo.SelectedIndex = 0;
            }
            else
            {
                comboBoxTipo.Items.Add("NADA");
                comboBoxTipo.SelectedIndex = 0;
                comboBoxTipo.Enabled = false;
            }

            if (pessoas.Count > 0)
            {
                comboBoxDono.DataSource = pessoas;
                comboBoxDono.SelectedIndex = 0;
                comboBoxDono.DisplayMember = "Nome";
            }
            else
            {
                comboBoxDono.Items.Add("NADA");
                comboBoxDono.SelectedIndex = 0;
                comboBoxDono.Enabled = false;
            }

            btnAcao.Enabled = comboBoxDono.Enabled && comboBoxTipo.Enabled;
        }

        private void PetDataForm_Load(object sender, EventArgs e)
        {
            LoadCombosData();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            if (Pet == null)
            {
                this.Text = "Criar Pet";
                lblModo.Text = "CADASTRO - PET";
                btnAcao.Text = "CRIAR";
                comboBoxPorte.SelectedIndex = 0;
            }
            else
            {
                txtNome.Text = Pet.Nome;
                txtRaca.Text = Pet.Raca;
                comboBoxPorte.Text = Pet.Porte;
                comboBoxTipo.Text = Pet.TipoPet.Nome;
                comboBoxDono.Text = Pet.Dono.Nome;
                dataNasc.Value = Pet.DataNascimento;
                this.Name = "Atualizar - " + Pet.Nome;
                lblModo.Text = "ATUALIZANDO - " + Pet.Nome.ToUpper();
                btnAcao.Text = "ATUALIZAR";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            if (Pet == null) // criar
            {
                Pet p = CriarPet();
                PetRepository.Insert(p);
                this.Dispose(true);
            }
            else // atualizar
            {
                Pet p = CriarPet();
                p.Id = Pet.Id;
                PetRepository.Update(p);
                this.Dispose(true);
            }
        }
    }
}
