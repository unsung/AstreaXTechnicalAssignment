using System;
using System.ComponentModel.DataAnnotations;

namespace AstreaXTechnicalAssignment.Models
{
    public class CustomerOrder
    {
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}
