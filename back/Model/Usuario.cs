using System;
using System.Collections.Generic;

namespace back.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            Formularios = new HashSet<Formulario>();
            Tokens = new HashSet<Token>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Userpass { get; set; } = null!;

        public virtual ICollection<Formulario> Formularios { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}
