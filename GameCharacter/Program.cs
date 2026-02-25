using System;

GameCharacter warrior = new GameCharacter();
warrior.name = "홍길동";
warrior.job = "전사";
warrior.ShowStatus();

warrior.GainExp(50);
warrior.GainExp(30);
warrior.GainExp(40);
warrior.ShowStatus();

Console.WriteLine();

GameCharacter mage = new GameCharacter();
mage.name = "김철수";
mage.job = "마법사";
mage.ShowStatus();

mage.GainExp(100);
mage.ShowStatus();