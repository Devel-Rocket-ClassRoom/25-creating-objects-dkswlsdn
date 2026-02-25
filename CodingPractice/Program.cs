using System;


Console.WriteLine("\n==========================");

Dog dog = new Dog
{
    name = "초코",
    age = 3
};

dog.Bark();
Console.WriteLine($"이름: {dog.name}, 나이: {dog.age}살");


Console.WriteLine("\n==========================");

Monster monster1 = new Monster();
var monster2 = new Monster();

Console.WriteLine(monster1);
Console.WriteLine(monster2);


Console.WriteLine("\n==========================");

Calculator calc = new Calculator();
Console.WriteLine($"합계: {calc.Add(3, 5)}");
Console.WriteLine($"곱: {calc.Multiply(4, 6)}");


Console.WriteLine("\n==========================");

Counter counter = new Counter();
counter.Increment();
counter.Increment();
counter.Increment();
counter.Reset();


Console.WriteLine("\n==========================");

GameManager gameManager = new GameManager();
gameManager.playerName = "홍길동";
GameManager.TotalPlayers = 10;
GameManager.ShowStatus();
gameManager.Greet();


Console.WriteLine("\n==========================");

Greeting.SayHello();
Farawell.Wave();

Greeting greeting = new Greeting();
greeting.SayGoodBye();
Farawell farawell = new Farawell();
farawell.Bow();


Console.WriteLine("\n==========================");

Item item = new Item { name = "포션", price = 100 };

Console.WriteLine(item);


Console.WriteLine("\n==========================");

Item2 item2 = new Item2 { name = "포션", price = 100 };

Console.WriteLine(item2);


Console.WriteLine("\n==========================");

Player player1 = new Player() { health = 200, level = 10, name = "전사" };
Player player2 = new Player() { health = 120, name = "마법사", level = 8 };

Console.WriteLine(player1);
Console.WriteLine(player2);


Console.WriteLine("\n==========================");

Enemy[] enemies = new Enemy[3];
enemies[0] = new Enemy { name = "고블린", health = 50};
enemies[1] = new Enemy { name = "오크", health = 100};
enemies[2] = new Enemy { name = "드래곤", health = 500};

foreach (Enemy enemy in enemies)
{
    enemy.ShowInfo();
}


Console.WriteLine("\n==========================");

Console.WriteLine("=== 인벤토리 ===");

Item3[] items = new Item3[3];
items[0] = new Item3 { name = "검", price = 500 };
items[1] = new Item3 { name = "방패", price = 300 };
items[2] = new Item3 { name = "포션", price = 50 };

foreach (var i in items)
{
    Console.WriteLine(i);
}


Console.WriteLine("\n==========================");

Character c1 = new Character();
c1.name = "홍길동";
c1.job = "전사";
c1.level = 1;

Character c2 = new Character { name = "이순신", level = 5, job = "궁수" };

c1.ShowStatus();
c2.ShowStatus();


Console.WriteLine("\n==========================");

Student s1 = new Student { name = "김철수", score = 85 };
Student s2 = new Student { name = "이영희", score = 92 };
Student s3 = new Student { name = "박민수", score = 78 };

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);