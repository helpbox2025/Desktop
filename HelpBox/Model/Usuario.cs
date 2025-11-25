using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Model
{
    // Classe modelo que representa a estrutura de dados de um
    // Usuário no sistema.
    public class Usuario 
    {
        // Propriedades que mapeiam as colunas da tabela de
        // usuários no banco de dados.
        public int id_User { get; set; }
        public string? email_User { get; set; }
        public string? senha_User { get; set; }
        public string? cargo_User { get; set; }
        public string? departamento_User { get; set; }
        public int? nivelAcesso_User { get; set; }
        public string? nome_User { get; set; }
        public string? sobrenome_User { get; set; }

        // Propriedade calculada que retorna o nome e
        // sobrenome concatenados para exibição.
        public string NomeCompleto => $"{nome_User} {sobrenome_User}"; 
    }
}

