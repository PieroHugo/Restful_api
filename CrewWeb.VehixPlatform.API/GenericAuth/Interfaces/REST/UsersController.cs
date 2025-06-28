// This module is generic. Customize it for your API needs.
﻿using System.Net.Mime;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Model.Queries;
using CrewWeb.VehixPlatform.API.GenericAuth.Domain.Services;
using CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Resources;
using CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CrewWeb.VehixPlatform.API.GenericAuth.Interfaces.REST;

[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available User Endpoints")]
public class UsersController(
    IUserCommandService userCommandService,
    IUserQueryService userQueryService
) : ControllerBase
{
    [HttpGet("{userId:int}")]
    public async Task<IActionResult> GetUserById([FromRoute] int userId)
    {
        var user = await userQueryService.Handle(new GetUserByIdQuery(userId));
        if (user is null) return NotFound();
        var resource = UserResourceFromEntityAssembler.ToResourceFromEntity(user);
        return Ok(resource);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        var users = await userQueryService.Handle(new GetAllUsersQuery());
        var resources = users.Select(UserResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserResource resource)
    {
        var command = CreateUserCommandFromResourceAssembler.ToCommandFromResource(resource);
        var user = await userCommandService.Handle(command);
        if (user is null) return BadRequest();
        var userResource = UserResourceFromEntityAssembler.ToResourceFromEntity(user);
        return CreatedAtAction(nameof(GetUserById), new { userId = userResource.Id }, userResource);
    }
}