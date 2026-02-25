using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    public string name;
    public int score;

    public override string ToString()
    {
        return $"{name}: {score}점";
    }
}