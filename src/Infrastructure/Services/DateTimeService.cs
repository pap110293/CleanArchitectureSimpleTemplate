using DotNetCore.Application.Common.Interfaces;
using System;

namespace DotNetCore.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
