using CoachFit.Application.Common;
using CoachFit.Application.DTOs;
using CoachFit.Application.Interfaces;
using CoachFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachFit.Application.UseCases
{
    public class CreateRoutineUseCase
    {
        private readonly IRoutineRepository _routineRepository;

        public CreateRoutineUseCase(IRoutineRepository routineRepository)
        {
            _routineRepository = routineRepository;
        }

        public async Task<Result> ExecuteAsync(CreateRoutineRequest request)
        {
            try
            {
                var routine = new Routine(
                    request.Name,
                    request.Description,
                    request.CoachId
                );

                await _routineRepository.AddAsync(routine);
                return Result.Success();
            }
            catch (ArgumentException ex)
            {
                return Result.Failure(ex.Message);
            }
        }
    }
}
