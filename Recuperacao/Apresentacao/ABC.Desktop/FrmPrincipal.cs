using ABC.Core.Entidades;
using ABC.Core.Repository;
using ABC.Data.SqlServer.Repositorio;

namespace ABC.Desktop
{
    public partial class FrmPrincipal : Form
    {
        ContatoRepository _contatoRepository;


        public FrmPrincipal()
        {
            InitializeComponent();
            _contatoRepository = new ContatoRepository();
            CarregarContato();
        }

        private void CarregarContato()
        {
            dtgListaContatos.AutoGenerateColumns = false;
            _contatoRepository = new ContatoRepository();
            dtgListaContatos.DataSource = _contatoRepository.ObterTodos();

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("O nome deve ser preenchido.");
                return;
            }

            var nome = txtNome.Text;
            var telefone = txtTelefone.Text;
            var email = txtEmail.Text;
            var cep = txtCep.Text;
            var cidade = txtCidade.Text;
            var bairro = txtBairro.Text;
            var dataNascimento = txtDataNascimento.Text;
            var cargo = txtCargo.Text;
            var empresa = txtEmpresa.Text;
            var observacoes = txtObservacoes.Text;
            var dataContato = txtDataContato.Text;


            var novoUsuario = new Contato
            {
                Nome = nome,
                Telefone = telefone,
                Email = email,
                Cidade = cidade,
                Cargo = cargo,
                Bairro = bairro,
                Cep = cep,
                Empresa = empresa,
                Observacoes = observacoes


            };
            if (_contatoRepository != null)
            {
                var resultado = _contatoRepository.Incluir(novoUsuario);
                dtgListaContatos.DataSource = _contatoRepository.ObterTodos();

                if (resultado)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o Usuário");
                }
            }
            else
            {
                MessageBox.Show("Erro: _contatoRepository não foi inicializado corretamente.");
            }
        }

        private void txtPesquisaContatos_TextChanged(object sender, EventArgs e)
        {

            var nome = txtPesquisaContatos.Text;
            var resultado = _contatoRepository.ObterPorNome(nome);
            dtgListaContatos.DataSource = resultado;
        }



        private void dtgListaContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtgListaContatos.Rows[e.RowIndex];
            if (dtgListaContatos.Columns[e.ColumnIndex].Name == "Excluir")
            {
                if (MessageBox.Show("Deseja realmente deletar o registro?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int id))
                    {
                        var resultado = _contatoRepository.Deletar(id);
                        CarregarContato();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o registro. Valor inválido.");
                    }
                }
            }
        }
    }
}