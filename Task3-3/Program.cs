// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int number = GetValue("Введите число: ");

Console.WriteLine("Таблица кубов чисел от 1 до " + number + " :");

for (int i=1; i<=number; i++)
    if (i != number)
        Console.Write(Math.Pow(i, 3) + ", ");
    else
        Console.Write(Math.Pow(i, 3));

