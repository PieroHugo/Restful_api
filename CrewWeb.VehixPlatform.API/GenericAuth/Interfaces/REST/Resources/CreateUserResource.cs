// This module is generic. Customize it for your API needs.
﻿namespace CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Resources;

public record CreateUserResource(
    string Name,
    string Lastname,
    string Email,
    string PasswordHash,
    string PhoneNumber,
    string Dni,
    string Gender,
    int PlanId,
    int RoleId);