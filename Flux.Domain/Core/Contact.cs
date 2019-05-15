using Flux.Domain.Core.Types;
using Flux.Model.Core;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Domain.Core
{
    public class Contact : Identity<string>
    {
        public ContactType Type { get; set; }
        public string Value { get; set; }
    }
}
