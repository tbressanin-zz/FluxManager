using Flux.Domain.Domain;
using Flux.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Service.Interfaces
{
    public interface IUserService : IBaseCrud<User>
    {
    }
}
