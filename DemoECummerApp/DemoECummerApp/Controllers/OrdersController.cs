using DemoECummerApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoECummerApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Orders")]
    public class OrdersController : Controller
    {
        private readonly DemoDatabaseContext _context;

        public OrdersController(DemoDatabaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrders([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.Include(o => o.OrdersProducts).SingleOrDefaultAsync(m => m.Id == id);

            if (orders == null)
            {
                return NotFound();
            }

            return Ok(orders);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrders([FromRoute] Guid id, [FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostOrders([FromBody] Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Copy customer address to delivery address.
            order.Deliverycity = order.Customercity;
            order.Deliverycountry = order.Customercountry;
            order.Deliverystreetaddress = order.CustomerStreetaddress;
            order.Deliverypostalcode = order.Customerpostalcode;
            order.Deliverystate = order.Customerstate;

            // Retrieve customer details and add to order.
            if (order.Customerid != null)
            {
                var customer = _context.Customers.SingleOrDefault(x => x.Id == order.Customerid);
                if (customer != null)
                {
                    order.Deliveryname = order.Customername = customer.Firstname;
                    order.Customeremail = customer.Email;
                    order.Customertelephone = customer.Telephone;
                }
                _context.Orders.Add(order);
            }


            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                if (OrdersExists(order.Id))
                {
                    return new StatusCodeResult(StatusCodes.Status409Conflict);
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOders", new { id = order.Id }, order);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrders([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _context.Orders.SingleOrDefaultAsync(m => m.Id == id);
            if (orders == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(orders);
            await _context.SaveChangesAsync();

            return Ok(orders);
        }

        private bool OrdersExists(Guid id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}
