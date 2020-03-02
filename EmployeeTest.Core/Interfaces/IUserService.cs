using EmployeeTest.Core.Entities;
using EmployeeTest.Core.Models.Requests;
using EmployeeTest.Core.Models.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Core.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetById(Guid id);
        Task UpdateUser(UserRequest user, Guid id);
        Task AddUser(UserRequest user);
        Task DeleteUser(Guid id);

    }
}
