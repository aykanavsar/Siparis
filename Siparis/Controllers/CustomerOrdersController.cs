using Microsoft.AspNetCore.Mvc;
using Siparis.Models;
using System.Collections.Generic;

using Siparis.Models;

namespace YourProjectName.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public ActionResult Index()
        {
            // Örnek müşteri
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Avşar",
                Email = "ali.avsar@example.com"
            };

            // Örnek siparişler
            var orders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Laptop", Price = 30000, Quantity = 2 },
                new Order { Id = 2, ProductName = "Saat", Price = 5000, Quantity = 10 },
                new Order { Id = 3, ProductName = "Kulaklık", Price = 1500, Quantity = 50 }
            };

            // ViewModel oluşturma
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };

            // View'a gönder
            return View(viewModel);
        }
    }
}
