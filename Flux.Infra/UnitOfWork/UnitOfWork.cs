using System;
using System.Collections.Generic;
using System.Text;

namespace Flux.Infra.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly IUnitOfWork _unitOfWork;

        public UnitOfWork(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
