// This module is generic. Customize it for your API needs.
﻿namespace CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Commands;

public record CreateUserCommand(
    string Name,
    string Lastname,
    string Email,
    string PasswordHash,
    string PhoneNumber,
    string Dni,
    string Gender,
    int PlanId,
    int RoleId);