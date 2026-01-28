using CoachFit.Application.Interfaces;
using CoachFit.Domain.Entities;

namespace CoachFit.Infrastructure.Repositories;

public class RoutineRepository : IRoutineRepository
{
    public Task AddAsync(Routine routine)
    {
        return Task.CompletedTask;
    }
}
