using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SaleService.Models;

namespace SaleService.Controllers
{
    [Produces("application/json")]
    [Route("api/Column")]
    public class ColumnController : Controller
    {
        private readonly SalesContext _context;

        public ColumnController(SalesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Column> GetAllUsers()
        {
            List<Column> columns = _context.Columns
                .Include(column => column.Articles)
                .ThenInclude(article=> article.Author)
                .ToList<Column>();

            return columns;
        }
    }
}