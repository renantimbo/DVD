using System;
using System.Collections.Generic;
using System.Text;

namespace DVD.Context.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public int IdGenero { get; set; }
        public int IdDiretor { get; set; }
        public string Nome { get; set; }
        public string NomeDiretor { get; set; }

        public ICollection<FilmeGenero> FilmeGenero { get; set; } = new HashSet<FilmeGenero>();

    }
}

