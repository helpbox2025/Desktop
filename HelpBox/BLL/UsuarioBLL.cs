using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpBox.DAL;
using HelpBox.Model;

namespace HelpBox.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL _usuarioDAL;

        public UsuarioBLL() // Inicializa a classe e a instância de acesso a dados (DAL).
        {
            _usuarioDAL = new UsuarioDAL();
        }

        // Valida as credenciais (email e senha) e verifica se o usuário é um técnico.
        public Usuario ValidarLoginTecnico(string email, string senha) 
        {
           
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                return null; // Retorna nulo p/ frm Login
            }

            try
            {
                return _usuarioDAL.VerificarLoginTecnico(email, senha);
            }
            catch (Exception ex)
            {
             
                Console.WriteLine($"Erro na BLL ao validar login: {ex.Message}");
                
                return null; 
            }
        }
    }
}
