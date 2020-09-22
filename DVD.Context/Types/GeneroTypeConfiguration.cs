using Microsoft.EntityFrameworkCore;
using DVD.Context.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVD.Context.Types
{
    public class GeneroTypeConfiguration : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.HasKey(q => q.Id);

            builder.Property(q => q.Nome).HasMaxLength(100);
        }
    }
}