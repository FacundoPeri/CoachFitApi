using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachFit.Application.DTOs;

public class CreateRoutineRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid CoachId { get; set; }
}

