using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using ntitsolutions.Application.Common.Interfaces;
using ntitsolutions.Application.Common.Mappings;
using ntitsolutions.Application.Common.Models;

namespace ntitsolutions.Application.Planos.Queries.GetPlanosWithPagination;

public record GetPlanosWithPaginationQuery : IRequest<PaginatedList<PlanoDto>>
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}

public class GetPlanosWithPaginationQueryHandler : IRequestHandler<GetPlanosWithPaginationQuery, PaginatedList<PlanoDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetPlanosWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<PlanoDto>> Handle(GetPlanosWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await _context.Planos
            .OrderBy(x => x.Nome)
            .ProjectTo<PlanoDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
