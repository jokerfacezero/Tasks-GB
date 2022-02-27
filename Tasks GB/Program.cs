//Задание 1. Вывести имя на консоль, вместе временем.


string name;

while(true)
{
    Console.WriteLine("Name?");
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