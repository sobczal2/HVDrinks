namespace Sobczal1.HVDrinks.Domain.Common;

public class BaseDomainEntity
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; } = null!;
}