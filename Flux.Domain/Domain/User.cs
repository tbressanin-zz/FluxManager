using Flux.Model.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Domain.Domain
{
    public class User : Identity<string>
    {
        public string Nome { get; set; }
        public string Valor { get; set; }
    }
}
