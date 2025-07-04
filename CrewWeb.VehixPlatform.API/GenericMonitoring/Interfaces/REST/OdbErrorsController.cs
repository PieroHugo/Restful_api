// This module is generic. Customize it for your API needs.
using System.Net.Mime;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Model.Commands;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Queries;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.Services;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Domain.ValueObjects;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Resources;
using CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace CrewWeb.VehixPlatform.API.GenericMonitoring.Interfaces.REST;

[ApiController]
[Route("api/v1/odberrors")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Odb Errors Endpoints")]
public class OdbErrorsController(
    IOdbErrorCommandService odbErrorCommandService,
    IOdbErrorQueryService odbErrorQueryService) : ControllerBase
{
    /// <summary>
    /// Gets Odb Error by its unique identifier.
    /// </summary>
    /// <param name="odbErrorId"></param>
    /// <returns></returns>
    [HttpGet("{odbErrorId:int}")]
    [SwaggerOperation(
        Summary = "Get Odb Error by Id",
        Description = "Returns a Odb error by its unique identifier.",
        OperationId = "GetOdbErrorById")]
    [SwaggerResponse(StatusCodes.Status200OK, "Odb Error found", typeof(OdbErrorResource))]
    [SwaggerResponse(StatusCodes.Status404NotFound, "Category not found")]
    public async Task<IActionResult> GetOdbErrorById(int odbErrorId)
    {
        var getOdbErrorByIdQuery = new GetOdbErrorByIdQuery(odbErrorId);
        var odbError = await odbErrorQueryService.Handle(getOdbErrorByIdQuery);
        if (odbError is null) return NotFound();
        var resource = OdbErrorResourceFromEntityAssembler.ToResourceFromEntity(odbError);
        return Ok(resource);
    }

    /// <summary>
    /// Get All Odb Errors
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get All Odb Errors",
        Description = "Returns a list of all available Odb Errors.",
        OperationId = "GetAllOdbErrors")]
    [SwaggerResponse(StatusCodes.Status200OK, "List of Odb Errors", typeof(IEnumerable<OdbErrorResource>))]
    public async Task<IActionResult> GetAllOdbErrors()
    {
        var odbErrors = await odbErrorQueryService.Handle(new GetAllOdbErrorsQuery());
        var odbErrorResources = odbErrors
            .Select(OdbErrorResourceFromEntityAssembler.ToResourceFromEntity);
        return Ok(odbErrorResources);
    }


    /// <summary>
    /// Creates a new Odb Error and returns the created Odb Error resource.
    /// </summary>
    /// <param name="resource"></param>
    /// <returns></returns>
    [HttpPost]
    [SwaggerOperation(
        Summary = "Create a New Odb Error",
        Description = "Creates a new Odb Error and returns the created Odb Error resource.",
        OperationId = "CreateOdbError")]
    [SwaggerResponse(StatusCodes.Status201Created, "Odb Error created successfully", typeof(OdbErrorResource))]
    [SwaggerResponse(StatusCodes.Status400BadRequest, "Odb Error could not be created")]
    public async Task<IActionResult> CreateOdbError([FromBody] CreateOdbErrorResource resource)
    {
        var createOdbErrorCommand = CreateOdbErrorCommandFromResourceAssembler.ToCommandFromResource(resource);
        var odbError = await odbErrorCommandService.Handle(createOdbErrorCommand);
        if (odbError is null) return BadRequest("Odb Error could not be created.");
        var odbErrorResource = OdbErrorResourceFromEntityAssembler.ToResourceFromEntity(odbError);
        return CreatedAtAction(nameof(GetOdbErrorById), new { odbErrorId = odbErrorResource.Id }, odbErrorResource);
    }
}