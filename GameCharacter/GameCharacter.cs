using System;
using System.Collections.Generic;
using System.Text;

public class GameCharacter
{
    public string name;
    public string job;
    int level = 1;
    int exp = 0;

    public void ShowStatus()
    {
        Console.WriteLine($"[{job}] {name} - Lv.{level} (EXP: {exp}/100)");
    }

    public void GainExp(int amount)
    {
        exp += amount;

        if (exp >= 100)
        {
            level++;
            exp -= 100;
            Console.WriteLine($"레벨 업! {name} Lv.{level} 달성!");
        }
        else
        {
            Console.WriteLine($"경험치 획득! 현재 EXP: {exp}/100");
        }
    }
}