using System;
using System.Collections.Generic;

namespace Projeto_Senai.Model
{
    public partial class Usuario
    {
        public Usuario()
        {
            FollowSeguidos = new HashSet<Follow>();
            FollowSeguindos = new HashSet<Follow>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public virtual ICollection<Follow> FollowSeguidos { get; set; }
        public virtual ICollection<Follow> FollowSeguindos { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
