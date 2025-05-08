public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public string DefaultShippingAddress { get; set; }
    public string DefaultShippingCity { get; set; }
    public string DefaultShippingPostalCode { get; set; }

    public string DefaultBillingAddress { get; set; }
    public string DefaultBillingCity { get; set; }
    public string DefaultBillingPostalCode { get; set; }

    public DateTime CreatedAt { get; set; }
}
