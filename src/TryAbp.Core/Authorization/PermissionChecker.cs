using Abp.Authorization;
using TryAbp.Authorization.Roles;
using TryAbp.Authorization.Users;

namespace TryAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
