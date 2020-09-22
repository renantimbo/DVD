using Microsoft.EntityFrameworkCore;
using DVD.Context.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVD.Context.Types
{
    public class FilmeGeneroTypeConfiguration : IEntityTypeConfiguration<FilmeGenero>
    {
        public void Configure(EntityTypeBuilder<FilmeGenero> builder)
        {

            builder.HasKey(q => q.IdFilme);

            builder.HasKey(q => q.IdGenero);

        }
    }
}
