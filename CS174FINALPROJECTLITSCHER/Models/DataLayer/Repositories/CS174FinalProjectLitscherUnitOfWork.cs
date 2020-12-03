using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class CS174FinalProjectLitscherUnitOfWork : ICS174FinalProjectLitscherUnitOfWork
    {
        private CS174FinalProjectLitscherContext context { get; set; }

        public CS174FinalProjectLitscherUnitOfWork(CS174FinalProjectLitscherContext ctx) => context = ctx;

        private IRepository<Product> productData;
        public IRepository<Product> Products
        {
            get
            {
                if (productData == null)
                    productData = new Repository<Product>(context);
                return productData;
            }
        }

        private IRepository<Hardness> hardnessData;
        public IRepository<Hardness> Hardnesses
        {
            get
            {
                if (hardnessData == null)
                    hardnessData = new Repository<Hardness>(context);
                return hardnessData;
            }
        }

        private IRepository<Appearance> appearanceData;
        public IRepository<Appearance> Appearances
        {
            get
            {
                if (appearanceData == null)
                    appearanceData = new Repository<Appearance>(context);
                return appearanceData;
            }
        }


        private IRepository<Cart> cartData;
        public IRepository<Cart> Carts
        {
            get
            {
                if (cartData == null)
                    cartData = new Repository<Cart>(context);
                return cartData;
            }
        }

        private IRepository<CartItem> cartItemData;
        public IRepository<CartItem> CartItems
        {
            get
            {
                if (cartItemData == null)
                    cartItemData = new Repository<CartItem>(context);
                return cartItemData;
            }
        }

        private IRepository<CartCustomer> cartCustomerData;
        public IRepository<CartCustomer> CartCustomers
        {
            get
            {
                if (cartCustomerData == null)
                    cartCustomerData = new Repository<CartCustomer>(context);
                return cartCustomerData;
            }
        }


    }
}
