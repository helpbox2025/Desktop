using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Model
{
    public class Usuario
    {
        
        public int id_User { get; set; }
        public string? email_User { get; set; }
        public string? senha_User { get; set; } // Idealmente, guardaria o HASH da senha
        public string? cargo_User { get; set; }
        public string? departamento_User { get; set; }
        public int? nivelAcesso_User { get; set; }
        public string? nome_User { get; set; }
        public string? sobrenome_User { get; set; }

        public string NomeCompleto => $"{nome_User} {sobrenome_User}";


    }
}

