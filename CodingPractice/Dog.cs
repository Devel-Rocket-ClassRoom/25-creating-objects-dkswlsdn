using System;
using System.Collections.Generic;
using System.Text;

public class Dog
{
    public string name;
    public int age;

    public void Bark()
    {
        Console.WriteLine($"{name}: 멍멍!");
    }
}