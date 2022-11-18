using Microsoft.EntityFrameworkCore;
using NorthwindEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDataAccess
{
    public class ApplictionUserDAO
    {
        CapgUserDBContent _context;
        public ApplictionUserDAO(CapgUserDBContent context)=>_context=context;
        public async Task<ApplicationUser> GetAppDtails(string appName)
        {
            return await _context.ApplicationUsers.FirstOrDefaultAsync(c => c.ApplicationName == appName);
        }
    }
}
