using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public interface ICS174FinalProjectLitscherUnitOfWork
    {
        IRepository<Appearance> Appearances { get; }
        IRepository<Hardness> Hardnesses { get; }
        IRepository<Product> Products { get; }
        IRepository<Cart> Carts { get; }
        IRepository<CartCustomer> CartCustomers { get; }
        IRepository<CartItem> CartItems { get; }

    }
}
