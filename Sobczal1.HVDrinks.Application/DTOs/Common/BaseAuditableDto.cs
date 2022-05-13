namespace Sobczal1.HVDrinks.Application.DTOs.Common;

public class BaseAuditableDto : BaseDto
{
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; } = null!;
}