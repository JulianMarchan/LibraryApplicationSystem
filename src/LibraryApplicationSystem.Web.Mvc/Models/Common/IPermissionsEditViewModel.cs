﻿using System.Collections.Generic;
using LibraryApplicationSystem.Roles.Dto;

namespace LibraryApplicationSystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}