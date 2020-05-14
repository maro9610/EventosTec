using EventoTec.web.Models.entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventoTec.web.Data.Helpers
{
    interface IUserHelper
    {
        Task<User> GetUserByEMailAsync(string email);
        Task<IdentityResult> AddUserAssync(User User, string Password);
        Task CheckRoleAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);

    }
}
