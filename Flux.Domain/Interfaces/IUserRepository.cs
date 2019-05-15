using Flux.Domain.Core;
using Flux.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Domain.Interfaces
{
    public interface IUserRepository : IBaseCrud<User>
    {
    }
}
