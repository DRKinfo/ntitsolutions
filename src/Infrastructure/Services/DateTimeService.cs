using ntitsolutions.Application.Common.Interfaces;

namespace ntitsolutions.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
