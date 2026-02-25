using System;
using System.Collections.Generic;
using System.Text;

public class BankAccount
{
    static int TotalAccount;

    string accountNumber;
    string ownerName;
    int balance;

    public BankAccount(string accountNumber, string ownerName, int balance)
    {
        this.accountNumber = accountNumber;
        this.ownerName = ownerName;
        this.balance = balance;

        TotalAccount++;

        Console.WriteLine($"[{accountNumber}] {ownerName} 계좌가 개설되었습니다");
    }

    public static void ShowTotalAccounts()
    {
        Console.WriteLine($"현재 총 계좌 수: {TotalAccount}개");
    }

    public void Deposit(int amount)
    {
        balance += amount;

        Console.WriteLine($"[{accountNumber}] {amount}원 입금 완료. 잔액: {balance}원");
    }

    public void Withdraw(int amount)
    {
        if (balance - amount < 0)
        {
            Console.WriteLine($"[{accountNumber}] {amount}원 출금 실패. 잔액이 부족합니다.");
            return;
        }

        balance -= amount;

        Console.WriteLine($"[{accountNumber}] {amount}원 출금 완료. 잔액: {balance}원");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {accountNumber}, 예금주: {ownerName}, 잔액: {balance}원");
    }
}