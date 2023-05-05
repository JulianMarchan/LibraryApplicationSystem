using Abp.Authorization;
using LibraryApplicationSystem.Authorization.Roles;
using LibraryApplicationSystem.Authorization.Users;

namespace LibraryApplicationSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
