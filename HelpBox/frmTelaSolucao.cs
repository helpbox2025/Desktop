using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpBox
{
    public partial class frmTelaSolucao : Form
    {
        public frmTelaSolucao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fazerLogOffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            CarregarDadosFicticios();
        }

        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.ColumnIndex nos diz qual coluna foi clicada.
            // e.RowIndex nos diz qual linha foi clicada.

            // Primeiro, verificamos se o clique foi em uma linha válida (não no cabeçalho)
            if (e.RowIndex < 0)
            {
                return;
            }

            // Agora, verificamos se a coluna clicada é a nossa coluna de botões ("Acao")
            if (dgvChamados.Columns[e.ColumnIndex].Name == "Acao")
            {
                // Pega o valor do ID do chamado da primeira célula daquela linha
                string idDoChamado = dgvChamados.Rows[e.RowIndex].Cells["IdChamado"].Value.ToString();

                // Mostra uma mensagem de teste para confirmar que funcionou!
                MessageBox.Show($"Você clicou em 'Solucionar' para o chamado de ID: {idDoChamado}", "Clique Detectado!");

                // Futuramente, aqui você chamaria a tela frmDetalhesChamado:
                // frmDetalhesChamado telaDetalhes = new frmDetalhesChamado(idDoChamado);
                // telaDetalhes.ShowDialog();
            }
            }
        private void CarregarDadosFicticios()
        {
            // Limpa quaisquer dados que já estejam na grade
            dgvChamados.Rows.Clear();
            dgvChamados.Columns.Clear(); // Limpa as colunas também para garantir

            // Adiciona as colunas programaticamente (isso nos dá mais controle)
            // Se você já adicionou as colunas pelo editor, pode pular esta parte ou deletá-las de lá.
            dgvChamados.Columns.Add("IdChamado", "ID Chamado");
            dgvChamados.Columns.Add("Categoria", "Categoria");

            // Adicionando a coluna de imagem para a Prioridade
            DataGridViewImageColumn colPrioridade = new DataGridViewImageColumn();
            colPrioridade.Name = "Prioridade";
            colPrioridade.HeaderText = "Prioridade";
            dgvChamados.Columns.Add(colPrioridade);

            dgvChamados.Columns.Add("DataAbertura", "Data de Abertura");
            dgvChamados.Columns.Add("Status", "Status");

            // Adicionando a coluna de botão para a Ação
            DataGridViewButtonColumn colAcao = new DataGridViewButtonColumn();
            colAcao.Name = "Acao";
            colAcao.HeaderText = ""; // Cabeçalho vazio
            colAcao.Text = "Solucionar";
            colAcao.UseColumnTextForButtonValue = true;
            dgvChamados.Columns.Add(colAcao);

            // Agora, vamos adicionar as linhas com os dados fictícios
            // Para os ícones, você precisa ter as imagens nos Recursos do seu projeto.
            // Ex: Properties.Resources.seta_alta, Properties.Resources.seta_media
            // Se não tiver, vou colocar null por enquanto. As linhas serão criadas mesmo assim.

            // Linha 1
            dgvChamados.Rows.Add("020310", "Software", null /* Ícone Média aqui */, "06/05", "Aberto");

            // Linha 2
            dgvChamados.Rows.Add("232665", "Software", null /* Ícone Alta aqui */, "08/05", "Andamento");

            // Linha 3
            dgvChamados.Rows.Add("023694", "Hardware", null /* Ícone Baixa aqui */, "07/05", "Aberto");
        }
    }

}
