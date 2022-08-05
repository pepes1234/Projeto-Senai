using System;
using System.Collections.Generic;

namespace Projeto_Senai.Model
{
    public partial class Follow
    {
        public int Id { get; set; }
        public int? Seguindo { get; set; }
        public int? Seguido { get; set; }

        public virtual Usuario SeguidoNavigation { get; set; }
        public virtual Usuario SeguindoNavigation { get; set; }
    }
}
