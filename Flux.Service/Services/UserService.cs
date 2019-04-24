using Flux.Domain.Domain;
using Flux.Domain.Interfaces;
using Flux.Infra.Repositories;
using Flux.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Flux.Service.Services
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task<User> GetById(string id)
        {
            return await _userRepository.GetById(id);
        }

        public async Task<User> Insert(User document)
        {
            return await _userRepository.Insert(document);
        }

        public async Task<User> Update(User document)
        {
            return await _userRepository.Update(document);
        }
    }
}
