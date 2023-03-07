using FluentValidation;

namespace ntitsolutions.Application.Planos.Queries.GetPlanosWithPagination;

public class GetPlanosWithPaginationQueryValidator : AbstractValidator<GetPlanosWithPaginationQuery>
{
    public GetPlanosWithPaginationQueryValidator()
    {

        RuleFor(x => x.PageNumber)
            .GreaterThanOrEqualTo(1).WithMessage("PageNumber pelo menos maior ou igual a 1.");

        RuleFor(x => x.PageSize)
            .GreaterThanOrEqualTo(1).WithMessage("PageSize pelo menos maior ou igual a 1.");
    }
}
