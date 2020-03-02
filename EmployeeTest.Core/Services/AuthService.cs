using EmployeeTest.Core.Entities;
using EmployeeTest.Core.Interfaces;
using EmployeeTest.Core.Models.Responses;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace EmployeeTest.Core.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUnitOfWork _uow;
        public AuthService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public LoginResponseModel LoginUser(string Username, string Password)
        {
            //Get user details for the user who is trying to login
            var user = _uow.GetRepository<User>().FirstOrDefault(x => x.Username == Username);

            //Authenticate User, Check if it’s a registered user in Database
            if (user.Result == null)
                return null;

            //If it's registered user, check user password stored in Database 
            //For demo, password is not hashed. Simple string comparison 
            //In real, password would be hashed and stored in DB. Before comparing, hash the password
            if (Password == user.Result.Password)
            {
                //Authentication successful, Issue Token with user credentials
                //Provide the security key which was given in the JWToken configuration in Startup.cs
                //Generate Token for user 
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes("ouNtF8Xds1jE55/d+iVZ99u0f2U6lQ+AHdiPFwjVW3o=");
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
               var userToken = tokenHandler.WriteToken(token);
                return new LoginResponseModel()
                {
                    Username = user.Result.Username,
                    Token = userToken,
                    Expires = token.ValidTo
                };
            }
            else
            {
                return null;
            }
        }
        private IEnumerable<Claim> GetUserClaims(User user)
        {

            List<Claim> claims = new List<Claim>
            {
        new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
        new Claim("Username", user.Username)
            };
            switch (user.Role)
            {
                case Entities.Enums.RoleTypeEnum.Admin:
                    claims.Add(new Claim("Role", "Admin"));
                    break;

                case Entities.Enums.RoleTypeEnum.Manager:
                    claims.Add(new Claim("Role", "Manager"));
                    break;

                case Entities.Enums.RoleTypeEnum.SuperAdmin:
                    claims.Add(new Claim("Role", "SuperAdmin"));
                    break;
                case Entities.Enums.RoleTypeEnum.User:
                    claims.Add(new Claim("Role", "User"));
                    break;
            }
            return claims.AsEnumerable();
        }
    }
}