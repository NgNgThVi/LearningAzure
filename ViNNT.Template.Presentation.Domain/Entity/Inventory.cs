using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity;

public class Inventory : BaseAuditableEntity
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public virtual Product Product { get; set; } = null!;
}
