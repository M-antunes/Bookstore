using System;
using System.Collections.Generic;

namespace Bookstore.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int Parcels { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
