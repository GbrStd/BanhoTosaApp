using BanhoTosaApp.model;
using BanhoTosaApp.repository;
using BanhoTosaApp.util;
using System;
using System.Windows.Forms;

namespace BanhoTosaApp
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            FormUtil.ShowForm(this, new PrincipalForm());
        }

        private void LoadGrid()
        {
            dgvClientes.DataSource = PessoaRepository.FindAll();
            dgvClientes.Refresh();
            dgvClientes.AutoResizeColumns();
        }

        private Pessoa GetSelected()
        {
            if (dgvClientes.CurrentRow == null)
                return null;
            Object selected = dgvClientes.CurrentRow.DataBoundItem;
            if (selected == null)
                return null;
            return (Pessoa)selected;
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            LoadGrid();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = CriarPessoa();

            PessoaRepository.Insert(pessoa);
            LoadGrid();
        }

        private Pessoa CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.CPF = txtCPF.Text;
            pessoa.Telefone = txtTelefone.Text;

            Endereco endereco = new Endereco();

            endereco.Rua = txtRua.Text;
            endereco.Numero = int.Parse(txtNumero.Text);
            endereco.Bairro = txtBairro.Text;
            endereco.Cidade = txtCidade.Text;

            pessoa.Endereco = endereco;
            return pessoa;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Pessoa p = GetSelected();
                if (p == null)
                    return;
                PessoaRepository.DeleteById(p.Id);
                LoadGrid();
            }
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pessoa p = GetSelected();
            if (p != null)
            {
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

                txtNome.Text = p.Nome;
                txtCPF.Text = p.CPF;
                txtTelefone.Text = p.Telefone;

                txtCidade.Text = p.Endereco.Cidade;
                txtRua.Text = p.Endereco.Rua;
                txtNumero.Text = p.Endereco.Numero.ToString();
                txtBairro.Text = p.Endereco.Bairro;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Pessoa p = GetSelected();
            if (p == null)
                return;
            Pessoa update = CriarPessoa();
            update.Id = p.Id;
            update.Endereco.Id = p.Id;
            PessoaRepository.Update(update);
            LoadGrid();
        }
    }
}
