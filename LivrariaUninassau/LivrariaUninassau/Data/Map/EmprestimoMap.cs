using LivrariaUninassau.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LivrariaUninassau.Data.Map
{
    public class EmprestimoMap : IEntityTypeConfiguration<EmprestimoModel>
    {
        public void Configure(EntityTypeBuilder<EmprestimoModel> builder)
        {
            builder.HasKey(x  => x.Id); 
            builder.Property(x => x.Titulo).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Autor).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Editora).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Idioma).IsRequired().HasMaxLength(64);
            builder.Property(x => x.Genero).IsRequired().HasMaxLength(64);
            builder.Property(x => x.NumeroDePaginas).IsRequired().HasMaxLength(64);
            builder.Property(x => x.ISBN).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Quantidade).IsRequired().HasMaxLength(64);
            builder.Property(x => x.dataPublicação).IsRequired().HasMaxLength(64);
            builder.Property(x => x.dataUltimaAtualizacao).IsRequired().HasMaxLength(64);
        }
    }
}
