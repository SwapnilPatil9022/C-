//1. Write a program which containcs one function named as fun(). The function should display "Hello from Fun" on console.

using System;

public class Demo
{
    public void fun()
    {
        Console.WriteLine("Hello from fun");
    }
}

public class program1_2
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Hello Mono World");
        
        Demo obj = new Demo();
        obj.fun();
    }
}