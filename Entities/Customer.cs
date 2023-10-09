using System;
namespace assignment9.Entities
{
	public class Customer
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public Customer()
		{
		}

        public Customer(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

