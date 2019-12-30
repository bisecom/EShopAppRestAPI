using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EshopServerApi.Models
{
    public class CartDbInitializer : DropCreateDatabaseAlways<EShopContext>
    {
        protected override void Seed(EShopContext db)
        {
            db.Carts.Add(new Cart {
                productSku = "DFR8F",
                title = "Lorem ipsum dolor sit amet 1",
                description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                imagePath = "https://images2.imgbox.com/2e/63/XBvPVPT6_o.png",
                price = 85.25f,
                quantity = 1,
                currency = "Euro" });

            db.Carts.Add(new Cart
            {
                productSku = "DFR8F",
                title = "Lorem ipsum dolor sit amet 2",
                description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                imagePath = "https://images2.imgbox.com/2e/63/XBvPVPT6_o.png",
                price = 25.50f,
                quantity = 1,
                currency = "Euro"
            });

            db.Carts.Add(new Cart
            {
                productSku = "DFR8F",
                title = "Lorem ipsum dolor sit amet 3",
                description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                imagePath = "https://images2.imgbox.com/2e/63/XBvPVPT6_o.png",
                price = 45.75f,
                quantity = 1,
                currency = "Euro"
            });

            db.Carts.Add(new Cart
            {
                productSku = "DFR8F",
                title = "Lorem ipsum dolor sit amet 4",
                description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                imagePath = "https://images2.imgbox.com/2e/63/XBvPVPT6_o.png",
                price = 27.45f,
                quantity = 1,
                currency = "Euro"
            });

            db.Carts.Add(new Cart
            {
                productSku = "DFR8F",
                title = "Lorem ipsum dolor sit amet 5",
                description = "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                imagePath = "https://images2.imgbox.com/2e/63/XBvPVPT6_o.png",
                price = 75.25f,
                quantity = 1,
                currency = "Euro"
            });

            base.Seed(db);
        }
    }
}