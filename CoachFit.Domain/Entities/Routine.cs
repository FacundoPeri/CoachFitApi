using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoachFit.Domain.Entities;

public class Routine
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public Guid CoachId { get; private set; }

    private readonly List<Exercise> _exercises = new();
    public IReadOnlyCollection<Exercise> Exercises => _exercises;

    private Routine() { }

    public Routine(string name, string description, Guid coachId)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("El nombre de la rutina es obligatorio");

        if (name.Length > 100)
            throw new ArgumentException("El nombre no puede superar los 100 caracteres");

        Id = Guid.NewGuid();
        Name = name;
        Description = description;
        CoachId = coachId;
    }
    public void AddExercise(Exercise exercise)
    {
        if (exercise == null)
            throw new ArgumentNullException(nameof(exercise));

        _exercises.Add(exercise);
    }
}
