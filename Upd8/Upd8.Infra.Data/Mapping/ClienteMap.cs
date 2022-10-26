using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Upd8.Core.Domain.Entities;

namespace Upd8.Infra.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnType("varchar");

            builder.HasIndex(x => x.CPF)
                .IsUnique();

            builder.Property(x => x.UF)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnType("varchar");

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnType("varchar");

            builder.Property(x => x.Logradouro)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnType("varchar");
        }
    }
}
