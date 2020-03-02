using EmployeeTest.Core.Entities;
using EmployeeTest.Core.Entities.Enums;
using EmployeeTest.Core.Interfaces;
using EmployeeTest.Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task AddUser(UserRequest currentUser)
        {
            User user = new User();
            user.FirstName = currentUser.FirstName;
            user.Address = currentUser.Address;
            user.DateOfBirth = currentUser.DateOfBirth;
            user.LastName = currentUser.LastName;
            user.Password = currentUser.Password;
            user.Role = (RoleTypeEnum)currentUser.Role;
            user.Salary = currentUser.Salary;
            user.Username = currentUser.Username;
            user.Id = Guid.NewGuid();
            _uow.GetRepository<User>().Insert(user);
         await   _uow.SaveChangesAsync();
        }

        public IEnumerable<User> GetAllUsers()
        {
            var users = _uow.GetRepository<User>().GetAll();
            return users.Result;
        }

        public User GetById(Guid id)
        {
            var user = _uow.GetRepository<User>().GetById(id);
            return user.Result;
        }
        public async Task DeleteUser(Guid id)
        {
            _uow.GetRepository<User>().DeleteById(id);
            await _uow.SaveChangesAsync();
        }

        public async Task UpdateUser(UserRequest currentUser, Guid id)
        {
            User user = new User();
            user.FirstName = currentUser.FirstName;
            user.Address = currentUser.Address;
            user.DateOfBirth = DateTime.Now;
            user.LastName = currentUser.LastName;
            user.Password = currentUser.Password;
            user.Role = (RoleTypeEnum)currentUser.Role;
            user.Salary = currentUser.Salary;
            user.Username = currentUser.Username;
            user.Id = id;
            _uow.GetRepository<User>().Update(user);
            await _uow.SaveChangesAsync();

        }
    }
}
