using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpBox.DAL; // Referencia a camada DAL
using HelpBox.Model; // Referencia a camada Model

namespace HelpBox.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL; // Instância da DAL

        public UsuarioBLL()
        {
            _usuarioDAL = new UsuarioDAL(); // Cria a instância no construtor
        }

        /// <summary>
        /// Valida as credenciais de login e verifica se é um técnico.
        /// </summary>
        /// <returns>Objeto Usuario se for um técnico válido, null caso contrário.</returns>
        public Usuario ValidarLoginTecnico(string email, string senha)
        {
            // Regra de negócio simples: campos não podem ser vazios
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                return null;
            }

            // --- Outras regras de negócio poderiam entrar aqui ---
            // Ex: Verificar formato do email, complexidade da senha (embora isso seja mais no cadastro)

            // Delega a verificação no banco de dados para a camada DAL
            try
            {
                return _usuarioDAL.VerificarLoginTecnico(email, senha);
            }
            catch (Exception ex)
            {
                // A BLL pode tratar exceções vindas da DAL ou relançá-las
                Console.WriteLine($"Erro na BLL ao validar login: {ex.Message}");
                // Poderia lançar uma exceção específica da BLL: throw new LoginException("Falha ao validar credenciais.", ex);
                return null; // Ou retornar null em caso de erro na DAL
            }
        }
    }
}
