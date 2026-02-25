using System;
using System.Collections.Generic;
using System.Text;

public class Product
{
    public string name;
    int price;
    int stock;

    public Product(string name, int price, int stock)
    {
        this.name = name;
        this.price = price;
        this.stock = stock;

        Console.WriteLine($"[{name}] {price}원 (재고: {stock}개)");
    }

    public void AddStock(int quantity)
    {
        stock += quantity;

        Console.WriteLine($"{name} {quantity}개 재고 추가. 현재 재고: {stock}개");
    }

    public void Sell(int quantity)
    {
        if (stock >= quantity)
        {
            stock -= quantity;
            Console.WriteLine($"{name} {quantity}개 판매 완료. 남은 재고: {stock}개");
        }
        else
        {
            Console.WriteLine($"{name} {quantity}개 판매 실패. 재고가 부족합니다. (현재 재고: {stock}개)");
        }
    }

    public int GetTotalValue()
    {
        return price * stock;
    }

    public override string ToString()
    {
        return $"[{name}] {price}원 (재고: {stock}개)";
    }
}