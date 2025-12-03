using Microsoft.AspNetCore.Identity;

namespace CarRentalManagrment.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentalManagrmentUser : IdentityUser
    {
        public string? FirstName { get; set;}
        public string? LastName { get; set; }                                               
    }
}
