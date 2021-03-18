using DemoECummerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoECummerApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Productsdetails")]
    public class ProductsdetailsController : Controller
    {
        private readonly DemoDatabaseContext _context;

        public ProductsdetailsController(DemoDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Productsdetail> GetProductsdetail() 
        {
            return _context.Productsdetail;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductsdetail([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productsdetail = await _context.Productsdetail.SingleOrDefaultAsync(m => m.Id == id);

            if (productsdetail == null)
            {
                return NotFound();
            }

            return Ok(productsdetail);
        }

    }
}
