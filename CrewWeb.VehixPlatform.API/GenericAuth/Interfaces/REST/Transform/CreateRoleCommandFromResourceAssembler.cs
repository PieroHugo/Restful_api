// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Resources;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Transform;

public static class CreateRoleCommandFromResourceAssembler
{
    public static CreateRoleCommand ToCommandFromResource(CreateRoleResource resource)
    {
        return new CreateRoleCommand(resource.Name);
    }
}
