using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;
using TheatersIS.DataLayer.Entities;
using TheatersIS.DataLayer.Repositories.UserRepositoryN;

namespace TheatersIs.BusinessLayer.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _usersRepository;


        private readonly IMapper _mapper;


        public UserService(IUserRepository usersRepository,
            IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDTO>> GetUsers()
        {
            return _mapper.Map<IEnumerable<UserDTO>>(_usersRepository.GetAll());
        }

        public async Task<UserDTO> GetUser(int id)
        {
            User user = _usersRepository.Get(id);
            return _mapper.Map<UserDTO>(user);
        }
        public async Task<UserDTO> AddUser(UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            _usersRepository.Insert(user);
            _usersRepository.Save();

            return _mapper.Map<UserDTO>(user);
        }

        public async Task<bool> DeleteUser(int id)
        {
            User userToDelete = _usersRepository.Get(id);
            if (userToDelete == null)
                return false;
            _usersRepository.Delete(userToDelete);
            _usersRepository.Save();
            return true;
        }

 
    }
}
