using Xunit;
using HelpBox.BLL; // Importa a BLL
using System; // Necessário para a Exception

namespace HelpBox.Tests
{
    public class ChamadoBLLTests
    {
        // --- TESTE 1: TESTANDO O MÉTODO GetChamadoPorId ---

        [Fact]
        public void GetChamadoPorId_ComIdZero_DeveLancarExcecao()
        {
            // 1. ARRANGE (Organizar)
            // Cria a BLL que vamos testar
            var bll = new ChamadoBLL();
            int idInvalido = 0; // O ID inválido que queremos testar

            // 2. ACT (Agir) & 3. ASSERT (Verificar)
            // Nós verificamos se a ação (Act) de chamar o método com o ID inválido
            // realmente lança (Throws) uma exceção do tipo 'Exception'.
            // O Assert.Throws() executa o código e captura a exceção para nós.
            var excecao = Assert.Throws<Exception>(() => bll.GetChamadoPorId(idInvalido));

            // (Opcional) Podemos verificar se a mensagem de erro é a que esperamos
            Assert.Equal("ID do chamado é inválido.", excecao.Message);
        }

        // --- TESTE 2: TESTANDO O MÉTODO SalvarSolucaoTecnico ---

        [Fact]
        public void SalvarSolucaoTecnico_ComSolucaoVazia_DeveLancarExcecao()
        {
            // 1. ARRANGE
            var bll = new ChamadoBLL();
            int idQualquer = 1;
            string solucaoVazia = "   "; // Testa com espaços em branco

            // 2. ACT & 3. ASSERT
            // Verifica se a BLL barra a tentativa de salvar uma solução vazia
            var excecao = Assert.Throws<Exception>(() => bll.SalvarSolucaoTecnico(idQualquer, solucaoVazia));

            // (Opcional) Verifica a mensagem de erro
            Assert.Equal("A solução do técnico não pode estar vazia.", excecao.Message);
        }

        // --- TESTE 3: TESTANDO O MÉTODO FinalizarChamado ---

        [Fact]
        public void FinalizarChamado_ComIdInvalido_DeveLancarExcecao()
        {
            // 1. ARRANGE
            var bll = new ChamadoBLL();
            int idInvalido = -5; // Testa com um número negativo

            // 2. ACT & 3. ASSERT
            var excecao = Assert.Throws<Exception>(() => bll.FinalizarChamado(idInvalido));

            // (Opcional) Verifica a mensagem de erro
            Assert.Equal("ID do chamado é inválido.", excecao.Message);
        }

        // --- TESTE 4: TESTANDO O MÉTODO AtribuirChamado ---

        [Fact]
        public void AtribuirChamado_ComIdTecnicoInvalido_DeveLancarExcecao()
        {
            // 1. ARRANGE
            var bll = new ChamadoBLL();
            int idChamadoQualquer = 1;
            int idTecnicoInvalido = 0; // ID do técnico não pode ser 0

            // 2. ACT & 3. ASSERT
            var excecao = Assert.Throws<Exception>(() => bll.AtribuirChamado(idChamadoQualquer, idTecnicoInvalido));

            // (Opcional) Verifica a mensagem de erro
            Assert.Equal("ID do técnico é inválido.", excecao.Message);
        }
    }
}