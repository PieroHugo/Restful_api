// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Queries;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Application.Internal.QueryServices;

public class RoleQueryService(IRoleRepository roleRepository) : IRoleQueryService
{
    public async Task<Role?> Handle(GetRoleByIdQuery query)
    {
        return await roleRepository.FindByIdAsync(query.RoleId);
    }

    public async Task<IEnumerable<Role>> Handle(GetAllRolesQuery query)
    {
        return await roleRepository.ListAsync();
    }
}
