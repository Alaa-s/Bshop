using bakaryshop.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakaryshop.Configerations
{
    public class ProductConfigration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.imagename).HasColumnName("ImageFileName");
        }

        internal IEntityTypeConfiguration<object> seed()
        {
            throw new NotImplementedException();
        }
    }
}
