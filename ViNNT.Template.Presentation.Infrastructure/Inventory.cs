using ViNNT.Template.Presentation.Domain.Common;
using ViNNT.Template.Presentation.Domain.Entity;

namespace ViNNT.Template.Presentation.Infrastructure;

public class Inventory : BaseAuditableEntity
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public virtual Product Product { get; set; } = null!;
}
