using CoachFit.Application.DTOs;
using CoachFit.Application.UseCases;
using CoachFit.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/routines")]
public class RoutinesController : ControllerBase
{
    private readonly CreateRoutineUseCase _useCase;

    public RoutinesController(CreateRoutineUseCase useCase)
    {
        _useCase = useCase;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateRoutineRequest request)
    {
        var result = await _useCase.ExecuteAsync(request);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok();
    }

}
