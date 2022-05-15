namespace RentACar.Core
{
    public class Customer : BaseEntity
    {
        public string NationalIdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
