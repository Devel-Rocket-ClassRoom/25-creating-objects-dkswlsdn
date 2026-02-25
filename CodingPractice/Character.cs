using System;
using System.Collections.Generic;
using System.Text;

public class Character
{
    public string name;
    public int level;
    public string job;

    public void ShowStatus()
    {
        Console.WriteLine($"{name} - {job} Lv.{level}");
    }
}