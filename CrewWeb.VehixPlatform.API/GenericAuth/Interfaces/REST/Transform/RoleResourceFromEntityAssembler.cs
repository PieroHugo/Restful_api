// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Transform;

public static class RoleResourceFromEntityAssembler
{
    public static RoleResource ToResourceFromEntity(Role role)
    {
        return new RoleResource(role.Id, role.Name);
    }
}
