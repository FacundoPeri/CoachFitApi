using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CoachFit.Domain.Entities;

public class MealPlan
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Calories { get; private set; }

    private readonly List<Meal> _meals = new();
    public IReadOnlyCollection<Meal> Meals => _meals;

    private MealPlan() { }

    public MealPlan(string name, int calories)
    {
        Id = Guid.NewGuid();
        Name = name;
        Calories = calories;
    }

    public void AddMeal(Meal meal)
    {
        _meals.Add(meal);
    }
}
