using EshopServerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EshopServerApi.Controllers
{
    public class ProductsController : ApiController
    {
        private EShopContext db = new EShopContext();
        // GET api/products
        public IEnumerable<Cart> GetCartProducts()
        {
            return db.Carts;
        }

        // GET api/values/5
        public Cart Get(int id)
        {
            Cart product = db.Carts.Find(id);
            return product;
        }

        [HttpPost]
        public void CreateOrder([FromBody]Order product, Client client)
        {
            db.Orders.Add(product);
            db.Clients.Add(client);
            if (product != null)
                db.Carts.RemoveRange(db.Carts);

            db.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
