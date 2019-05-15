using Flux.Model.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Domain.Core
{
    public class User : Identity<string>
    {
        public string Name { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Surname { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
