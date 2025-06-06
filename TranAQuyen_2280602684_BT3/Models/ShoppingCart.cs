﻿namespace TranAQuyen_2280602684_BT3.Models
{
    public class ShoppingCart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public void AddItem(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity; // Nếu sản phẩm đã có trong giỏ, tăng số lượng
            }
            else
            {
                Items.Add(item); // Nếu chưa có, thêm mới sản phẩm vào giỏ
            }
        }
        public void RemoveItem(int productId)
        {
            Items.RemoveAll(i => i.ProductId == productId);
        }
        public void ClearCart()
        {
            Items.Clear();
        }

        // Tính tổng giá trị của giỏ hàng
        public decimal GetTotal()
        {
            return Items.Sum(i => i.Price * i.Quantity); 
        }
        // Các phương thức khác...
    }
}
