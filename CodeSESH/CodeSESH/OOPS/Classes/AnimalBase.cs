using System;
using System.Collections.Generic;
using System.Text;

namespace CodeSESH.OOPS.Classes
{
  public interface IAnimal
  {
    string Name { get; set; }
    bool Walk();
    bool Eat();
    void Speak(string whatToSay);
    void PrintNumberOfMeals();
  }

  public class Animal : IAnimal
  {
    #region Properties

    private int NumberOfMealsEaten { get; set; }
    public string Name { get; set; }

    #endregion

    #region Functions
    public bool Walk()
    {
      var result = false;

      Console.WriteLine($"The animal named {Name} walked.");
      result = true;

      return result;
    }

    public bool Eat()
    {
      var result = false;

      Console.WriteLine("Animal ate.");

      // short hand incrementing
      NumberOfMealsEaten++;

      // the long way
      //NumberOfMealsEaten = NumberOfMealsEaten + 1;
      result = true;

      return result;
    }

    #endregion

    #region Methods

    public void Speak(string whatToSay)
    {
      Console.WriteLine($"This animal says {whatToSay}");
    }

    public void PrintNumberOfMeals()
    {
      var myAnimalMealsEatenMessage = $"My animal named {Name} has eaten {NumberOfMealsEaten}";
      Console.WriteLine(myAnimalMealsEatenMessage);
    }

    #endregion
  }
}
