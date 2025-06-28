// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Transform;

public static class UserResourceFromEntityAssembler
{
    public static UserResource ToResourceFromEntity(User user)
    {
        return new UserResource(
            user.Id,
            user.Name,
            user.Lastname,
            user.Email,
            user.PasswordHash,
            user.PhoneNumber,
            user.Dni,
            user.Gender,
            user.PlanId,
            user.RoleId,
            user.Role.Name);
    }
}