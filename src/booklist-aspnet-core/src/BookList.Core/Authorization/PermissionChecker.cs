using Abp.Authorization;
using BookList.Authorization.Roles;
using BookList.Authorization.Users;

namespace BookList.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
