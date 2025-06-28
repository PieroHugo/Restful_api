// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;
using CrewWeb.VehixPlatform.API.Shared.Domain.Repositories;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Application.Internal.CommandServices;

public class UserCommandService(
    IUserRepository userRepository,
    IRoleRepository roleRepository,
    IUnitOfWork unitOfWork) : IUserCommandService
{
    public async Task<User?> Handle(CreateUserCommand command)
    {
        var role = await roleRepository.FindByIdAsync(command.RoleId);
        if (role is null) throw new Exception("Role not found");

        var user = new User(command);
        await userRepository.AddAsync(user);
        await unitOfWork.CompleteAsync();
        user.Role = role;
        return user;
    }
}