using EcommerceEE.Interfaces;
using EcommerceEE.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceEE.ViewModel
{
    public class JWTManagerRepository : IJWTMangerRepository
    {
        Dictionary<string, string> UserRecords;
        private readonly IConfiguration configuration;
        private readonly EcommerceDb1Context db;

        public JWTManagerRepository(IConfiguration _configuration, EcommerceDb1Context _db)
        {
            db = _db;
            configuration = _configuration;
        }



       
        public Tokens Authenicate(LoginViewModel registerViewModel, bool IsRegister)
        {
            var _isAdmin = false;
            var _isUserExists = false;
            if (IsRegister)
            {
                if (db.Tb1logins.Any(x => x.UserName == registerViewModel.UserName && x.Password == registerViewModel.Password))
                {
                    _isUserExists = true;
                    return new Tokens { IsUserExits = _isUserExists };
                }
                
                Tb1login tb1Login = new Tb1login();
                tb1Login.UserName = registerViewModel.UserName;
                tb1Login.Password = registerViewModel.Password;
                db.Tb1logins.Add(tb1Login);
                db.SaveChanges();
            }
            else
            {
                _isAdmin = db.Tb1logins.Any(x => x.UserName == registerViewModel.UserName && x.Password == registerViewModel.Password && x.IsAdmin == 1);
            }
            UserRecords = db.Tb1logins.ToList().ToDictionary(x => x.UserName, x => x.Password);
            if (!UserRecords.Any(x => x.Key == registerViewModel.UserName && x.Value == registerViewModel.Password))
            {
                return null;
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.UTF8.GetBytes(configuration["JWT:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {

                    new Claim(ClaimTypes.Name,registerViewModel.UserName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenkey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new Tokens { Token = tokenHandler.WriteToken(token), IsAdmin = _isAdmin, IsUserExits = _isUserExists };


        }
    }
}
