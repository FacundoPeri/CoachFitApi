using CoachFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoachFit.Application.Interfaces;

public interface IRoutineRepository
{
    Task AddAsync(Routine routine);
}
