using GYM.DataModel;
using GYM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GYM.Repository
{
    public class AuthenticateLogin : ILogin
    {
        public readonly dataContext _context;

        public AuthenticateLogin(dataContext context)
        {
            _context = context;
        }
        public async Task<LoginAuth> AuthenticateUser(string username, string passcode)
        {
            var succeeded = await _context.LoginAuth.FirstOrDefaultAsync(authUser => authUser.UserName == username && authUser.passcode == passcode);
            return succeeded;
        }

        public async Task<IEnumerable<LoginAuth>> getuser()
        {
            return await _context.LoginAuth.ToListAsync();
        }
    }
}
