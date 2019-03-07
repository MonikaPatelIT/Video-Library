using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModel;
using Vidly.Models;
namespace Vidly.Controllers
{
    [RoutePrefix("Customer")]
    [Route("{action=Index}")]
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }
        //Get: Customer/Details/Id
        [Route("Details/{id}")]
        public ActionResult Details(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if(customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1, Name ="Monika Patel"},
                new Customer {Id=2, Name ="Hiren Patel"}
            };
        }
    }
}