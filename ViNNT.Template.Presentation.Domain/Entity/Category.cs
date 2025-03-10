using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity;

public class Category : BaseAuditableEntity
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; } 
    public virtual ICollection<Product>? Products { get; set; }
}