using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ntitsolutions.Application.Common.Interfaces;
using ntitsolutions.Application.Common.Security;

namespace ntitsolutions.Application.Tarifas.Queries.GetTarifas;

[Authorize]
public record GetTarifasQuery : IRequest<List<TarifaDto>>;

public class GetTarifasQueryHandler : IRequestHandler<GetTarifasQuery, List<TarifaDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetTarifasQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<TarifaDto>> Handle(GetTarifasQuery request, CancellationToken cancellationToken)
    {
            return await _context.Tarifas
                    .ProjectTo<TarifaDto>(_mapper.ConfigurationProvider)
                    .OrderBy(t => t.Id)
                    .ToListAsync(cancellationToken);
    }
}
