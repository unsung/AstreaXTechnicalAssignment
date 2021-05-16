using System;
using System.Collections.Generic;

namespace AstreaXTechnicalAssignment.Models
{
    public class CustomerViewModel
    {
        public int CustomerNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return this.FirstName + " " + this.LastName; } }
        public List<CustomerOrder> Orders { get; set; }
    }
}
