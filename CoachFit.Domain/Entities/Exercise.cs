using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoachFit.Domain.Entities;

public class Exercise
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string MuscleGroup { get; private set; }
    public int Sets { get; private set; }
    public int Reps { get; private set; }

    private Exercise() { }

    public Exercise(string name, string muscleGroup, int sets, int reps)
    {
        Id = Guid.NewGuid();
        Name = name;
        MuscleGroup = muscleGroup;
        Sets = sets;
        Reps = reps;
    }
}

