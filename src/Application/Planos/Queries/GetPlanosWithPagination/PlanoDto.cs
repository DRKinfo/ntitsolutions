using AutoMapper;
using ntitsolutions.Application.Common.Mappings;
using ntitsolutions.Application.Tarifas.Queries.GetTarifas;
using ntitsolutions.Domain.Entities;

namespace ntitsolutions.Application.Planos.Queries.GetPlanosWithPagination;

public class PlanoDto : IMapFrom<Plano>
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Plano, PlanoDto>();
    }

}
