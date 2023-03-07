namespace ntitsolutions.Domain.Entities;

public class Plano : BaseAuditableEntity
{
    public int Id { get; set; }

    public string? Nome { get; set; }
}
