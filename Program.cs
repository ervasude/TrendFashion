using assignment9.Entities;
using assignment9.Persistence;
using Microsoft.EntityFrameworkCore;


#region Adding Customer and Order
using (var context = new BasketDbContext())
{
    var newCustomer = new List<Customer>
    {
        new Customer { Name = "Cemre Harun" }

    };

    context.Customers.AddRange(newCustomer);//dont accept add ?
    context.SaveChanges();
}

using (var context = new BasketDbContext())
{
    var Name = "Cemre Harun";

    var customer = context.Customers.FirstOrDefault(c => c.Name == Name);

    if (customer != null)
    {
        var newOrder = new Order
        {
            OrderDate = DateTime.Now,
            TotalAmount = 100.00M,
            Customer = customer
        };

        context.Orders.Add(newOrder);
        context.SaveChanges();
    }
}

#endregion


#region Updating

using

#endregion

#region Remove

using (var context = new BasketDbContext())
{
    string Name = "Cemre Harun";
    var customerToDelete = context.Customers.FirstOrDefault(c => c.Name == Name);
    if (customerToDelete != null)
    {
        context.Customers.Remove(customerToDelete);
        context.SaveChanges();
    }
}

#endregion

#region Updating

using (var context = new BasketDbContext())
{
    string Name = "Zeynep Sinal";
    var customerToUpdate = context.Customers.FirstOrDefault(c => c.Name == Name);
    context.SaveChanges();
}

#endregion
