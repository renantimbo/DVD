using System;
using System.Collections.Generic;
using System.Text;

namespace DVD.Context.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<FilmeGenero> FilmeGenero { get; set; } = new HashSet<FilmeGenero>();
    }
}
