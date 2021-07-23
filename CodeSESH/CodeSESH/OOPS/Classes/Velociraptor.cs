using System;

namespace CodeSESH.OOPS.Classes
{
  public class Velociraptor: IAnimal
  {
    public string Name { get; set; }
    public bool Walk()
    {
      throw new NotImplementedException();
    }

    public bool Eat()
    {
      throw new NotImplementedException();
    }

    public void Speak(string whatToSay)
    {
      throw new NotImplementedException();
    }

    public void PrintNumberOfMeals()
    {
      throw new NotImplementedException();
    }
  }
}