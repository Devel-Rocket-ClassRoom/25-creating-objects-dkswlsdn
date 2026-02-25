using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    public string name;
    public int level;
    public int health;

    public override string ToString()
    {
        return $"[{level}레벨] {name} (HP: {health})";
    }
}