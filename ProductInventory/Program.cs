using System;
using System.Xml.Linq;


Console.WriteLine("=== 상품 목록 ===");

Product p1 = new Product("노트북", 1500000, 5);
Product p2 = new Product("마우스", 35000, 20);
Product p3 = new Product("키보드", 89000, 15);

Console.WriteLine("\n=== 거래 ===");
p1.Sell(2);
p2.Sell(5);
p3.Sell(20);
p3.AddStock(10);

Console.WriteLine("\n=== 최종 상품 목록 ===");

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Console.WriteLine("\n=== 총 재고 가치 ===");
Console.WriteLine($"{p1.name}: {p1.GetTotalValue()}원");
Console.WriteLine($"{p2.name}: {p2.GetTotalValue()}원");
Console.WriteLine($"{p3.name}: {p3.GetTotalValue()}원");

Console.WriteLine("---");

Console.WriteLine($"전체 재고 총 가치: {p1.GetTotalValue() + p2.GetTotalValue() + p3.GetTotalValue()}원");