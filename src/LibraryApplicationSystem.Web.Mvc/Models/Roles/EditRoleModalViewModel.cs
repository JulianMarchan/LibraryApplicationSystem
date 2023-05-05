using Abp.AutoMapper;
using LibraryApplicationSystem.Roles.Dto;
using LibraryApplicationSystem.Web.Models.Common;

namespace LibraryApplicationSystem.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
