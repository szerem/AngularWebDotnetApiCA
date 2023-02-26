using AngularWebDotnetApiCA.Application.Common.Interfaces;

namespace AngularWebDotnetApiCA.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
