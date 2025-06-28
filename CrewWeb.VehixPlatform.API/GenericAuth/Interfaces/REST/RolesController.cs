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
[SwaggerTag("Available Role Endpoints")]
public class RolesController(
    IRoleCommandService roleCommandService,
    IRoleQueryService roleQueryService
) : ControllerBase
{
    [HttpGet("{roleId:int}")]
    public async Task<IActionResult> GetRoleById([FromRoute] int roleId)
    {
        var role = await roleQueryService.Handle(new GetRoleByIdQuery(roleId));
        if (role is null) return NotFound();
        var resource = RoleResourceFromEntityAssembler.ToResourceFromEntity(role);
        return Ok(resource);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllRoles()
    {
        var roles = await roleQueryService.Handle(new GetAllRolesQuery());
        var resources = roles.Select(RoleResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(resources);
    }

    [HttpPost]
    public async Task<IActionResult> CreateRole([FromBody] CreateRoleResource resource)
    {
        var command = CreateRoleCommandFromResourceAssembler.ToCommandFromResource(resource);
        var role = await roleCommandService.Handle(command);
        if (role is null) return BadRequest();
        var roleResource = RoleResourceFromEntityAssembler.ToResourceFromEntity(role);
        return CreatedAtAction(nameof(GetRoleById), new { roleId = roleResource.Id }, roleResource);
    }
}