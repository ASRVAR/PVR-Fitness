using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Repository
{
    public interface ILogin
    {
        Task<IEnumerable<LoginAuth>> getuser();
        Task<LoginAuth> AuthenticateUser(string username, string passcode);
    }
}
