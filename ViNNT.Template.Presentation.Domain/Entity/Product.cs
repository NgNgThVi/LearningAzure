using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity
{
    public class Product : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ProductImage>? Images { get; set; }
        //public virtual ICollection<Review> Reviews { get; set; }
    }
}
