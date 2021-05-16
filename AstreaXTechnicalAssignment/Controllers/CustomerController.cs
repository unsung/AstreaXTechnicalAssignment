using AstreaXTechnicalAssignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AstreaXTechnicalAssignment.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Redirect Index to Orders
            var redirectResult = new RedirectToActionResult("Orders", "Customer", new { });
            return redirectResult;
        }

        public IActionResult Orders()
        {
            // Generate some prefilled order data to display
            var orderList = new List<CustomerOrder>(new[]
            {
                new CustomerOrder
                {
                    OrderId = 1,
                    OrderDate = DateTime.Now - new TimeSpan(2, 0, 0, 0),
                    Description = "Part 1",
                    Total = 10m
                },
                new CustomerOrder
                {
                    OrderId = 2,
                    OrderDate = DateTime.Now - new TimeSpan(1, 0, 0, 0),
                    Description = "Part 2",
                    Total = 20m
                },
                new CustomerOrder
                {
                    OrderId = 1,
                    OrderDate = DateTime.Now,
                    Description = "Part 3",
                    Total = 30m
                }
            });

            // Instantiate a customer for displaying order history
            var customerViewModel = new CustomerViewModel
            {
                CustomerNumber = 111111,
                FirstName = "John",
                LastName = "Smith",
                Orders = orderList
            };

            return View(customerViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Redirect Error to Orders
            var redirectResult = new RedirectToActionResult("Orders", "Customer", new { });
            return redirectResult;
        }
    }
}
