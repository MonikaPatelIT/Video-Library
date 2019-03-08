using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
namespace Vidly.Controllers
{
    [RoutePrefix("Customer")]
    [Route("{action=Index}")]
    public class CustomerController : Controller
    {
        private BlogDbContext _context;

        public CustomerController()
        {
            _context = new BlogDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType);

            return View(customers);
        }
        //Get: Customer/Details/Id
        [Route("Details/{id}")]
        public ActionResult Details(int Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if(customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        
    }
}