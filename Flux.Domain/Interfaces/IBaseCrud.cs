using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Flux.Domain.Interfaces
{
    public interface IBaseCrud<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(string id);
        Task<T> Insert(T document);
        Task<T> Update(T document);
    }
}
