// This module is generic. Customize it for your API needs.
﻿using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Aggregates;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Commands;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;

public interface IUserCommandService
{
    Task<User?> Handle(CreateUserCommand command);
}
