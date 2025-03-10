using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity
{
    public class ProductImage : BaseAuditableEntity
    {
        public Guid ProductId { get; set; }
        public string ImageUrl { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
