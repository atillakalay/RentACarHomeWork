namespace RentACar.Core.DTOs
{
    public class CarDto : BaseDto
    {
        public string LicensePlate { get; set; }
        public DateTime ModelYear { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public bool State { get; set; }
        public int BrandId { get; set; }
    }
}
