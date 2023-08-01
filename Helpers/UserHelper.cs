using Microsoft.AspNetCore.Razor.TagHelpers;
using StarryFlix.Models;
using StarryFlix.Models.Databases;

namespace StarryFlix.Helpers
{
    public class UserHelper
    {
        public static User GetUserFromModel(DirectorModel model, HttpContext httpContext)
        {
            var now = DateTime.Now;
            return new User
            {
                Name = model.Name,
                Family = model.Family,
                Gender = model.Gender,
                BirthDate = model.BirthDate,
                //UserRoles = new List<UserRole>() {
                //    new UserRole
                //    {
                //        AssignDate = DateTime.Now,
                //        Role = (int)SCabEnumHelper.UserRole.Driver,
                //    }
                //}
            };
        }
    }
}
