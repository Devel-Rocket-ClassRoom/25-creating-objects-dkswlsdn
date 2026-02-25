using System;

Console.WriteLine("=== 계좌 개설");
BankAccount b1 = new("1001", "홍길동", 100000  );
BankAccount b2 = new("1002", "이순신", 50000);
BankAccount.ShowTotalAccounts();

Console.WriteLine();

Console.WriteLine("=== 거래 ===");

b1.Deposit(50000);
b2.Deposit(30000);
b1.Withdraw(200000);
b1.Withdraw(100000);

Console.WriteLine();

Console.WriteLine("=== 최종 계좌 정보 ===");

b1.ShowInfo();
b2.ShowInfo();