using ntitsolutions.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ntitsolutions.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Plano> Planos { get; }
    DbSet<Tarifa> Tarifas { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
