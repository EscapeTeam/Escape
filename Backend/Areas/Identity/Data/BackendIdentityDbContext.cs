using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Escape.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Escape.Backend.Areas.Identity.Data
{
    public class BackendIdentityDbContext : IdentityDbContext<IdentityUser>
    {
        public BackendIdentityDbContext(DbContextOptions<BackendIdentityDbContext> options)
            : base(options)
        {
        }
    }
}
