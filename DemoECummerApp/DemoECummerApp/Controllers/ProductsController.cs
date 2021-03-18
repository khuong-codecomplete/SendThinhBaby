using DemoECummerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DemoECummerApp.Controllers
{
    [Produces("application/json")]
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly DemoDatabaseContext _context;

        public ProductsController(DemoDatabaseContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Products> GetProducts(string searchText)
        {
            ///return  _context.Products.Include(x => x.Productsdetail).ToList();

            var products = _context.Products.Include(x => x.Productsdetail).ToList();

            if (!string.IsNullOrEmpty(searchText))
            {
                products = products.Where(p => p.Productsdetail
                                                .Any(pd => pd.Name.ToLower().Contains(searchText.ToLower())))
                                                .ToList();
            }
            return products;
        }
    }
}
