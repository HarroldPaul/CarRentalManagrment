using CarRentalManagement.Domain;

namespace CarRentalManagrment.Domain
{
    public class Booking : BasedDomainModel
    {
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int VehicleId { get; set; }
        public int CustomerId { get; set; }
    }
}
