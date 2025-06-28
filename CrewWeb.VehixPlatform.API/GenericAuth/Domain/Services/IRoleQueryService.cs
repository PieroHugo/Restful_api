// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Queries;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;

public interface IRoleQueryService
{
    Task<Role?> Handle(GetRoleByIdQuery query);
    Task<IEnumerable<Role>> Handle(GetAllRolesQuery query);
}
