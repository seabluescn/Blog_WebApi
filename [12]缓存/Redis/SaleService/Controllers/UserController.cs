using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaleService.Models;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        private readonly SalesContext _context;

        public UserController(SalesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
            List<User> users = _context.Users.ToList<User>();

            return users;
        }
    }
}