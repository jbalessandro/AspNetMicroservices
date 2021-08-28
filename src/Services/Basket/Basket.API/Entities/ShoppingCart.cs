using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public decimal TotalPrice { get
            {
                decimal totalPrice = 0;

                Items.ForEach(i =>
                {
                    totalPrice += i.Price * i.Quantity;
                });

                return totalPrice;
            }
        }
    }
}
