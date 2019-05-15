using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.CrossCutting
{
    public class DateTimeTypeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return System.Convert.ToDateTime(source);
        }
    }
}
