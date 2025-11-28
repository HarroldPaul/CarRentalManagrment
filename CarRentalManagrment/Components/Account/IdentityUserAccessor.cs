using CarRentalManagrment.Data;
using Microsoft.AspNetCore.Identity;

namespace CarRentalManagrment.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<CarRentalManagrmentUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<CarRentalManagrmentUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
