using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Identity
{
    public class UserIdentityShop : IdentityDbContext<ApplicationUser>
    {
        public UserIdentityShop(DbContextOptions<UserIdentityShop> options):base(options)
        {

        }
    }
}
