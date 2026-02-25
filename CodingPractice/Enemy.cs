using System;
using System.Collections.Generic;
using System.Text;

public class Enemy
{
    public string name;
    public int health;

    public void ShowInfo() => Console.WriteLine($"{name}: HP {health}");
}