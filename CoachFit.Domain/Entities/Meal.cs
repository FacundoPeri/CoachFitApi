using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoachFit.Domain.Entities;

public class Meal
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Protein { get; private set; }
    public int Carbs { get; private set; }
    public int Fats { get; private set; }

    private Meal() { }

    public Meal(string name, int protein, int carbs, int fats)
    {
        Id = Guid.NewGuid();
        Name = name;
        Protein = protein;
        Carbs = carbs;
        Fats = fats;
    }
}
