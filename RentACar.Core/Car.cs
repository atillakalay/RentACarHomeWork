namespace RentACar.Core
{
    public class Car : BaseEntity
    {
        public string LicensePlate { get; set; }
        public DateTime ModelYear { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool State { get; set; }
        public int BrandId { get; set; }
        public int CustomerId { get; set; }
        public Brand Brand { get; set; }
        public Customer Customer { get; set; }

    }
}
