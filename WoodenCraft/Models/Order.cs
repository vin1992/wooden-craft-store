public class Order
{
    public int Id { get; set; }
    public int? UserId { get; set; }  // 可空，防止删除用户时出错
    public User User { get; set; }

    public DateTime OrderDate { get; set; }
    public bool IsPaid { get; set; }

    public string ShippingAddress { get; set; }
    public string ShippingCity { get; set; }
    public string ShippingPostalCode { get; set; }

    public string BillingAddress { get; set; }
    public string BillingCity { get; set; }
    public string BillingPostalCode { get; set; }

    public string PhoneNumber { get; set; }
    public decimal TotalPrice { get; set; }

    public List<OrderItem> Items { get; set; }
}
