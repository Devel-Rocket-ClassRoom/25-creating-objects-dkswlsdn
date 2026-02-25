using System;
using System.Collections.Generic;
using System.Text;

public class Item3
{
    public string name;
    public int price;

    public override string ToString()
    {
        return $"{name}: {price}골드";
    }
}
