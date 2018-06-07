using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Wealth.Models;

namespace Wealth.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomersController : ApiController
    {
        private readonly WealthContext db = new WealthContext();

        /// <summary>
        /// Fetch all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        public async Task<IHttpActionResult> GetCustomers()
        {
            var customers = await db.Customers.ToListAsync();

            foreach (var customer in customers)
            {
                customer.Transaction = db.Transactions.Where(t => t.CustomerId == customer.CustomerId);
            }

            return Json(customers);
        }

        /// <summary>
        /// Fetch nested customer-transactions
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>List of transactions based on customer ID</returns>
        [Route("{id}/transactions")]
        [ResponseType(typeof(Transaction))]
        public IHttpActionResult GetTransactions(int id)
        {
            var transaction = db.Transactions.Where(m => m.CustomerId == id);

            if (transaction.Count() == 0)
            {
                return NotFound();
            }

            return Json(transaction);
        }

        /// <summary>
        /// Fetch specific customer details and transactions
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>Customer details</returns>
        [ResponseType(typeof(Customer))]
        public IHttpActionResult GetCustomer(int id)
        {
            Customer customer = db.Customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }

            customer.Transaction = db.Transactions.Where(t => t.CustomerId == customer.CustomerId);

            return Json(customer);
        }

        // The rest of the file is the default scaffolding POST/PUT/DELETE methods from VS
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            db.Entry(customer).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> PostCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Customers.Add(customer);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = customer.CustomerId }, customer);
        }

        [ResponseType(typeof(Customer))]
        public async Task<IHttpActionResult> DeleteCustomer(int id)
        {
            Customer customer = await db.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            db.Customers.Remove(customer);
            await db.SaveChangesAsync();

            return Ok(customer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CustomerExists(int id)
        {
            return db.Customers.Count(e => e.CustomerId == id) > 0;
        }
    }
}