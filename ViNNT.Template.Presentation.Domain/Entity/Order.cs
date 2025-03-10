using ViNNT.Template.Presentation.Domain.Common;
using ViNNT.Template.Presentation.Domain.Enum;

namespace ViNNT.Template.Presentation.Domain.Entity;

public class Order : BaseAuditableEntity
{
    public Guid UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderStatusEnum Status { get; set; }
    public virtual User User { get; set; } = null!;
    public virtual ICollection<OrderDetail>? OrderDetails { get; set; }
}
