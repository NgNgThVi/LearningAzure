using ViNNT.Template.Presentation.Domain.Common;

namespace ViNNT.Template.Presentation.Domain.Entity;

public class OrderDetail : BaseAuditableEntity
{
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public virtual Order Order { get; set; } = null!;
    public virtual Product Product { get; set; } = null!;
}

