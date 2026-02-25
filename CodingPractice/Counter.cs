using System;
using System.Collections.Generic;
using System.Text;

public class Counter
{
    int count;

    public void Increment() => Console.WriteLine($"현재 카운트: {++count}");
    public void Reset()
    {
        count = 0;
        Console.WriteLine("카운트가 초기화되었습니다");
    }
}