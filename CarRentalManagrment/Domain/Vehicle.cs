using CarRentalManagement.Domain;

namespace CarRentalManagrment.Domain
{
    public class Vehicle : BasedDomainModel
    {
        public int Year { get; set; }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public int ColourId { get; set; }
    }
}
