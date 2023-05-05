using System.Collections.Generic;
using LibraryApplicationSystem.Roles.Dto;

namespace LibraryApplicationSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
