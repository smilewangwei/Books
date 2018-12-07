using Abp.Authorization;
using Abp.Localization;
using BookList.Authorization;
using System.Linq;

namespace BookList.BooklistManagement.Books.Authorization
{
    public  class BookAuthorizationProvider: AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //L("Pages")多语言
            var pages = context.GetPermissionOrNull(PermissionNames.Pages) ?? context.CreatePermission(PermissionNames.Pages, L("Pages"));
            var admin = pages.Children.FirstOrDefault(a => a.Name == PermissionNames.Pages_Administrator) ?? pages.CreateChildPermission(PermissionNames.Pages_Administrator, L("Administrator"));

            var entityPermission = admin.CreateChildPermission(BookPermissions.BookManager, L("BookManager"));
            entityPermission.CreateChildPermission(BookPermissions.Query, L("Query"));
            entityPermission.CreateChildPermission(BookPermissions.BatchDelete, L("BatchDelete"));
            entityPermission.CreateChildPermission(BookPermissions.Create, L("Create"));
            entityPermission.CreateChildPermission(BookPermissions.Delete, L("Delete"));
            entityPermission.CreateChildPermission(BookPermissions.Edit, L("Edit"));
        }

        private static ILocalizableString L(string name)
        {
          return  new LocalizableString(name, BookListConsts.LocalizationSourceName);
        }
    }
}
