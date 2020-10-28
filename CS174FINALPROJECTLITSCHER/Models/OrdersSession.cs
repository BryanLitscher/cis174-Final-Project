using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CS174FINALPROJECTLITSCHER.Models
{
    public class OrdersSession
    {
        private const string ProductsKey = "products";

        private ISession session { get; set; }
        public OrdersSession(ISession sess)
        {
            session = sess;
        }
        public List<Product> GetProducts() =>
            session.GetObject<List<Product>>(ProductsKey) ?? new List<Product>();

        public void SetProducts(List<Product> prods) =>
            session.SetObject(ProductsKey, prods);
    }
}
