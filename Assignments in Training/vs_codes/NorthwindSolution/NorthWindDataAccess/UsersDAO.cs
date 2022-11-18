using NorthWindDataAccess;
using NorthwindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess
{
    public class UsersDAO
    {
        CapgUserDBContent _context;
        public UsersDAO(CapgUserDBContent context) => _context = context;

        public User Authenticate(User model)
        {
            var user = _context.Users
                       .FirstOrDefault(c => c.Username == model.Username && c.Password == model.Password);

            return user;
        }
    }
}