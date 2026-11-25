using System;

namespace OrderManagement
{
    struct Order
    {
        public int OrderId { get; }
        public string CustomerName { get; }
        public int ProductId { get; }
        public int Quantity { get; }
        public decimal TotalAmount { get; }
        public OrderStatus Status { get; }

        public Order(int orderId, string customerName, int productId, int quantity, decimal totalAmount)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Количество должно быть больше нуля");
            }

            if (totalAmount <= 0)
            {
                throw new ArgumentException("Сумма заказа должна быть больше нуля");
            }

            OrderId = orderId;
            CustomerName = customerName;
            ProductId = productId;
            Quantity = quantity;
            TotalAmount = totalAmount;
            Status = OrderStatus.Created;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Заказ №{OrderId}");
            Console.WriteLine($"Покупатель: {CustomerName}");
            Console.WriteLine($"Id товара: {ProductId}");
            Console.WriteLine($"Количество: {Quantity}");
            Console.WriteLine($"Сумма заказа: {TotalAmount}");
            Console.WriteLine($"Статус: {Status}");
        }
    }
}
