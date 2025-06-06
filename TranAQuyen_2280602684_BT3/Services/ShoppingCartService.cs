using TranAQuyen_2280602684_BT3.Extensions;
using TranAQuyen_2280602684_BT3.Models;

namespace TranAQuyen_2280602684_BT3.Services
{
    public class ShoppingCartService
    {
        public ShoppingCart GetCart(ISession session, string key = "Cart")
        {
            return session.GetObjectFromJson<ShoppingCart>(key) ?? new ShoppingCart();
        }
        public void SaveCart(ISession session, ShoppingCart cart, string key = "Cart")
        {
            session.SetObjectAsJson(key, cart);
        }
        public void ClearCart(ISession session, string key = "Cart")
        {
            session.Remove(key);
        }
    }
}
