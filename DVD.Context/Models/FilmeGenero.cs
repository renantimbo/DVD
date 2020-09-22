using System;
using System.Collections.Generic;
using System.Text;

namespace DVD.Context.Models
{
    public class FilmeGenero
    {
        public int IdFilme { get; set; }
        public int IdGenero { get; set; }

        public virtual Filme Filme { get; set; }
        public virtual Genero Genero { get; set; }

    }
}
