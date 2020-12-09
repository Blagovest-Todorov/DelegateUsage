using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.LambdaFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // LambdaFunctions -> are anonymous functions, contain Lamda Operator- =>,  reads as goes to, so to, , left side Lamda parameter
            // the right side expression or statement to check, some validation ? //x => x + 2 -is a kind of mapping, kind of transformation //
            // LambdaFunctions are inline funcrions, fuction with parameters and return values
            //  Func<int, int> lambda = x => x / 2;   //lambda is called hier delegate !
            // x -input parameter,  x / 2 ->  this is the returned value
            // x => x / 2; static int Func(int x) { return x / 2; }
            // x => x != 0  static bool Func(int x) {return x !=0 ;}

            //Func<int, bool> lambda = (x) => x != 0; //Delegate->  when we assign a lambda datement to a variable;
            //Console.WriteLine(lambda(5)); // is 5 != than 0; true //lamda is definition of a function it creates a function under it works

            // Func<int, int> lambda = x=> x + 10; //Func is a delegate ! Action and Func are delagates
            // Console.WriteLine(lambda(5)); //the result is 15 = 5 +10 ; //delegates make the reading code easier 
            // Func represents a method that returns something !
            // Func<int, DateTime, string> is a function with  int and DateTime parameters, that returns  a string ; 
            // Action<> and Action is method that returns nothing.
            // Action -has no parameters, Action<string, int> represents a method with a strubg and int parameter
            // Actiono or func, delegate are essensially interchangeable.  Deglaring adelegaesallow, us to gibe it a name that indicates what
            // is it for.
            // A Delegate called  delegate  double MathCValcylation() is clearly intended to do the Math, while Func<float, float, double> does not
            //tell us what the method does/ Its a preference and case by case desicion. Delegates may be clearer, 
            // but Action and Func save us from having to declare
            // Delegate is a special type of  a object in C# /
            //Delegate is a method,  that  contains parameters and return type ; -> Method passed as a parameter to other methods /
            //Delegate signature -> consists of parameters and return type
            //Delegates are types-safe and verysecure-> delegates make event-Handling simple and easy
            // singleCastDelegate---delegate pointint go  1 method
            // multicast delegate -delegate wrapped to more thatn one method
            //Delegates give method name and signature, delegate help us in code optionisation, used in events 
            //Delegate  is a class ->  is a special function that has a input parameter, and return type ;

            // the Where() method is part of Linq  Library 
            Func<int, bool> function = x => x == 0;
            // Delegate   -!   on the left            // Lambda expression  here on the right !!  
            int[] array = new int[] { 0, 5, 6, 8, 0, 9, 11 };
            function(5); //true -evaluated by some rule , by some bool statment
            function(0); // false 
            function(-2); //  true 

            Console.WriteLine(string.Join(" ", array.Where(function))); // where method, take all elements that are true when passed to function
                                                                        // where it the rule the con dition under which elements are checked !
                                                                        // the result here it we take and print all that is  different than  0 ;
                                                                        // our fuinction test if an element is = 0 or not -i e different than 0;
        }
    }
}
