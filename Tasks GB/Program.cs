﻿//Задание 1. Вывести имя на консоль, вместе временем.
Console.WriteLine("Name?");

string name;

while(true)
{
    name = Console.ReadLine();
    Console.WriteLine(name);
    Console.WriteLine(DateTime.Now.ToString());
    Console.ReadLine();
    if(name == "lll")

    {
        break;

    }
    else
    {
        Console.Clear();
    }
}