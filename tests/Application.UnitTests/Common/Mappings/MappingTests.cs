using System.Runtime.Serialization;
using AutoMapper;
using ntitsolutions.Application.Common.Mappings;
using ntitsolutions.Application.Planos.Queries.GetPlanosWithPagination;
using ntitsolutions.Application.Tarifas.Queries.GetTarifas;
using ntitsolutions.Domain.Entities;
using NUnit.Framework;

namespace ntitsolutions.Application.UnitTests.Common.Mappings;

public class MappingTests
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingTests()
    {
        _configuration = new MapperConfiguration(config => 
            config.AddProfile<MappingProfile>());

        _mapper = _configuration.CreateMapper();
    }

    [Test]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Test]
    [TestCase(typeof(Tarifa), typeof(TarifaDto))]
    [TestCase(typeof(Plano), typeof(PlanoDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        return FormatterServices.GetUninitializedObject(type);
    }
}
