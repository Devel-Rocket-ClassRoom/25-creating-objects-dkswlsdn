using System;
using System.Collections.Generic;
using System.Text;

public class Item2
{
    public string name;
    public int price;

    public override string ToString()
    {
        return $"[아이템] {name} - {price}골드";
    }
}