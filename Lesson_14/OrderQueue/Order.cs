namespace OrderQueue
{
    internal class Order
    {
        public static int orderNumber;
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }

        public Order(string orderName, double totalAmouant)
        {
            OrderNumber = orderNumber++;
            CustomerName = orderName;
            TotalAmount = totalAmouant;
        }

        public override string ToString()
        {
            return $"Номер заказа: {OrderNumber}, клиент: {CustomerName}, сумма заказа: {TotalAmount}";
        }
    }
}
