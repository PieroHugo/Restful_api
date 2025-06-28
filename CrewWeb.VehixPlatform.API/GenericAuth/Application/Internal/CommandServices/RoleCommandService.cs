// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;
using CrewWeb.VehixPlatform.API.Shared.Domain.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Application.Internal.CommandServices;

public class RoleCommandService(
    IRoleRepository roleRepository,
    IUnitOfWork unitOfWork) : IRoleCommandService
{
    public async Task<Role?> Handle(CreateRoleCommand command)
    {
        var role = new Role(command);
        await roleRepository.AddAsync(role);
        await unitOfWork.CompleteAsync();
        return role;
    }
}
