using ViNNT.Template.Presentation.Domain.Common;
using ViNNT.Template.Presentation.Domain.Enum;

namespace ViNNT.Template.Presentation.Domain.Entity;

public class User : BaseAuditableEntity
{
    public string? FullName { get; set; }
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    /// <summary>
    /// Admin = 0,
    /// Staff = 1,
    /// Customer = 2
    /// </summary>
    public RoleEnum Role { get; set; } = 0;
    public virtual ICollection<Order>? Orders { get; set; }
}