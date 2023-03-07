using AutoMapper;
using ntitsolutions.Application.Common.Mappings;
using ntitsolutions.Domain.Entities;

namespace ntitsolutions.Application.Tarifas.Queries.GetTarifas;

public class TarifaDto : IMapFrom<Tarifa>
{
    public int Id { get; set; }
    public string? Origem { get; set; }
    public string? Destino { get; set; }
    public decimal Valor { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Tarifa, TarifaDto>();
        //.ForMember(d => d.CodigoDdd, opt => opt.MapFrom(s =>s.CodigoDdd));
    }
}
