using HelpBox.BLL;
using HelpBox.DAL;
using HelpBox.Model;
using Xunit; // A biblioteca de testes

namespace HelpBox.Test
{
    public class UsuarioBLLTests
    {
        // --- TESTE 1: REGRA DE NEGÓCIO (EMAIL VAZIO) ---

        [Fact] // Marca como um teste
        public void ValidarLogin_ComEmailVazio()
        //Deve retornar nulo

        {
            // 1. ARRANGE (Organizar)
            // Cria uma BLL (usando o construtor padrão,
            
            var bll = new UsuarioBLL();
            string emailVazio = "";
            string senhaQualquer = "123456";

            // 2. ACT (Agir)
            var resultado = bll.ValidarLoginTecnico(emailVazio, senhaQualquer);

            // 3. ASSERT (Verificar)
            // Afirmamos que o resultado DEVE ser nulo
            Assert.Null(resultado);
        }

        // --- TESTE 2: REGRA DE NEGÓCIO (SENHA VAZIA) ---

        [Fact]
        public void ValidarLogin_ComSenhaVazia()
            //Deve retornar nulo

        {
            // Arrange
            var bll = new UsuarioBLL();
            string emailQualquer = "teste@teste.com";
            string senhaVazia = "";

            // Act
            var resultado = bll.ValidarLoginTecnico(emailQualquer, senhaVazia);

            // Assert
            Assert.Null(resultado);
        }
    }
}