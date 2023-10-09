using System;
namespace assignment9.Entities
{
	public class Order
	{
        public Guid Id { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }

		public Customer Customer { get; set; }

		public Order()
		{
		}

        public Order(DateTime orderDate, decimal totalAmount, Customer customer)
        {
            Id = Guid.NewGuid();
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Customer = customer;
        }
    }
}

