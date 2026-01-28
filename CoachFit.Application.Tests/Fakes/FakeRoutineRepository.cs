using CoachFit.Application.Interfaces;
using CoachFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachFit.Application.Tests.Fakes
{
    public class FakeRoutineRepository : IRoutineRepository
    {
        public Routine SavedRoutine { get; private set; }

        public Task AddAsync(Routine routine)
        {
            SavedRoutine = routine;
            return Task.CompletedTask;
        }
    }
}
