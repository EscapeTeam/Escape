using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Escape.Backend.Models;
using Microsoft.AspNetCore.Identity;
using Escape.Backend.DbData;
using Microsoft.EntityFrameworkCore;

namespace Escape.Backend.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UserController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public void Create(IdentityUser user)
        {
            // using (var context = new ApplicationDbContext(DbContextOptions.l))
            // {
                
            // }

        }
    }
}