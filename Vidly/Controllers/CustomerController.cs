using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;
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

        public ActionResult CustomerForm()
        {
            var mebershipTypes = _context.MembershipType.ToList();
            var customerView = new CustomerViewModel
            {
                MembershipTypes = mebershipTypes
            };
            return View("CustomerForm", customerView);
        }
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id== 0)
            {
                _context.Customers.Add(customer); //simply create new
            }
            else
            {
                var customerDB = _context.Customers.Single(c => c.Id == customer.Id);
                customerDB.Name = customer.Name;
                customerDB.DOB = customer.DOB;
                customerDB.MembershipTypeId = customer.MembershipTypeId;
                customerDB.IsSubscribeToNewsletter = customer.IsSubscribeToNewsletter;

            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            var editCustomer = new CustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipType.ToList()
            };
            return View("CustomerForm", editCustomer);
        }
              
    }
}