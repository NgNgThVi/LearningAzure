using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity
{
    public class Supplier : BaseAuditableEntity
    {
        public string Name { get; set; } = null!;
        public string ContactInfo { get; set; } = null!;
        public virtual ICollection<Product>? Products { get; set; }
    }
}
