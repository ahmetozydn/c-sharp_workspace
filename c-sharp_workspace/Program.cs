// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    static void Main(string[] args) // can get multiple string arguments
    {
        FunctionWithDefaultParametre(); // doesn't have to send a parametre for default parametres

        int[] myArray = { 1, 2, 3, 4, 5 };
        int[] anArray = new int[5];
        int[] anArray2 = new int[5] { 2, 4, 7, 2, 3 }; // c style declaration


        int number = 46;
        Console.WriteLine(FunctionWithRefKeyword(ref number)); // ref or out keyword changes the value of a primitive type variable

        foreach (int i in anArray2)
        {
            Console.Write($"{i} "); // foreach implementation
        }


        /*Template template = new Template
        {
            Name = "Ahmet",
            Age = 24
        }; */

       // Console.WriteLine(template.Age);

        /*
         * function with default parametres, default parametres must placed to the end of parametre list
         * if no parametre send the default values assigned to parametres.
         */
        static void FunctionWithDefaultParametre(string name = "Guest", int age = 23) // function with default params
        {
            Console.WriteLine($"Hello, {name}! You are {age} years old.");
        }

        static int FunctionWithRefKeyword(ref int number)
        {
            number = 40; // change the value of primitive type use it as reference variable
            return number; // use primitive type as reference variable
        }
        /*
         *  method overloading means change method signature and use it multiple times! Return type also can be changed
         * In java return type cannot be changed to make method overloading
         * Argument is actual values while parametres just placholders.
         * In Java, method names is written with camelCase whereas in C# it is UpperCase
         */

    }
       
    }

class Template
{
    // field, instance var in Java
    private String _Name;
    public String Name { // Encapsulation
        set { _Name = value; } 
        get { return "Mrs" + _Name; } 
    } // getter and setter in C#
    public int Age { set; get; } // default set and get methods, auto property
                                  // field
                                  //private String department;
}


