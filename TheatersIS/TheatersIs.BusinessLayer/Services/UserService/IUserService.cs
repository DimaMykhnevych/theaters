using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TheatersIs.BusinessLayer.DTOs;

namespace TheatersIs.BusinessLayer.Services.UserService
{
    public interface IUserService
    {
        Task<UserDTO> GetUser(int id);
        Task<IEnumerable<UserDTO>> GetUsers();
        Task<UserDTO> AddUser(UserDTO user);

        Task<bool> DeleteUser(int id);
    }
}
