using System;


namespace Console_App { 

// Created a public class 
public class MyClass
{
    public void DoMathOperation(int firstNumber, int secondNumber)
    {
        int result = firstNumber + 10;
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Second Number: " + secondNumber);
    }
}
   class Program
    {
        static void Main()
        {
        MyClass myObject = new MyClass();

        // Calling the method by passing in two numbers
        myObject.DoMathOperation(5, 20);

        // Calling the method by specifying the parameters by name
        myObject.DoMathOperation(firstNumber: 10, secondNumber: 30);

        Console.ReadLine();
        }
    }
}

