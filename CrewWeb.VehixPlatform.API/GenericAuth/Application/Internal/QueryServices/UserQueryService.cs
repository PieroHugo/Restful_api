// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Queries;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Repositories;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Application.Internal.QueryServices;

public class UserQueryService(IUserRepository userRepository) : IUserQueryService
{
    public async Task<User?> Handle(GetUserByIdQuery query)
    {
        return await userRepository.FindByIdAsync(query.UserId);
    }

    public async Task<IEnumerable<User>> Handle(GetAllUsersQuery query)
    {
        return await userRepository.ListAsync();
    }
}
