using System;
using System.Runtime.InteropServices;
using CodeSESH.OOPS.Classes;

namespace CodeSESH
{
  public enum AnimalTypes
  {
    Dog = 1,
    Cat = 2,
    Velociraptor = 3
  }

  class Program
  {
    static void Main(string[] args)
    {

      // todo: goal one greeting and length printed out in console

      // var greeting = "Hello there stranger";
      // Console.WriteLine(greeting);
      // Console.WriteLine(greeting.Length);

      // todo: goal two reverse order of greeting and print in console

      // Calling the method created in the StringReversal Class to output the results
      //StringReversal.StringReverseWithCharArray();

      // todo: goal three reverse greeting back and capitalize first letter in each word

      //OOPS
      var myCat = new Cat();
      myCat.Name = "Althea";
      
      myCat.Walk();
      myCat.Speak("meow meow");
      
      var myDog = new Dog();
      myDog.Name = "Louis";

      myDog.Eat();

      //var myDogMealsEatenMessage = $"My dog named {myDog.Name} has eaten {myDog}";
      //Console.WriteLine(myDogMealsEatenMessage);

      myDog.PrintNumberOfMeals();

      // the usage of "is" to compare a type
      var result= myCat is Cat;

      IAnimal myAnimal;

      var myAnimalType = AnimalTypes.Cat;

      switch (myAnimalType)
      {
        case AnimalTypes.Dog:
          myAnimal = new Dog();
          break;
        case AnimalTypes.Cat:
          myAnimal = new Cat();
          break;
        case AnimalTypes.Velociraptor:
          myAnimal = new Velociraptor();
          break;
        default:
          throw new ArgumentOutOfRangeException();
      }

      var isMyAnimalADog = myAnimal is Dog;

      if (isMyAnimalADog)
      {
        myAnimal.Speak("yo");
      }

      myAnimal.Walk();

    }
  }
}
