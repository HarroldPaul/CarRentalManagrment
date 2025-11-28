using CarRentalManagement.Domain;

namespace CarRentalManagrment.Domain
{
    public class Customer : BasedDomainModel
    {
        public string? DrivingLincense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }

    }
}
