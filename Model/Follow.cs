using System;
using System.Collections.Generic;

namespace Projeto_Senai.Model
{
    public partial class Follow
    {
        public int Idsegue { get; set; }
        public int? SeguindoId { get; set; }
        public int? SeguidoId { get; set; }

        public virtual Usuario Seguido { get; set; }
        public virtual Usuario Seguindo { get; set; }
    }
}
