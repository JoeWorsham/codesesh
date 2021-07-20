using System;
using CodeSESH.OOPS.Classes;

namespace CodeSESH
{
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


      var myDog = new Dog();
      myDog.Name = "Louis";

      myDog.Eat();

      //var myDogMealsEatenMessage = $"My dog named {myDog.Name} has eaten {myDog}";
      //Console.WriteLine(myDogMealsEatenMessage);

      myDog.PrintNumberOfMeals();


    }
  }
}
