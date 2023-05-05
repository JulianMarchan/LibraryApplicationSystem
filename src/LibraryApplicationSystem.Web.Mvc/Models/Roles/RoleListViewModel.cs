using System.Collections.Generic;
using LibraryApplicationSystem.Roles.Dto;

namespace LibraryApplicationSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
