using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Model.Product
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.OwnsOne(p => p.productId);
            builder.OwnsOne(p => p.name);
            builder.OwnsOne(p => p.description);
            builder.OwnsOne(p => p.price.ToString());
        }
    }
}
