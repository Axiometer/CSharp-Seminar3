// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int GetValue(string msg)
{
    System.Console.Write(msg);
    string v = Console.ReadLine();
    return Convert.ToInt32(v);
}

int ReverseInt(int num)
{
    int reversenum = 0;
    while (num > 0)
    {
        reversenum = reversenum * 10 + num % 10;
        num /= 10;
    }

    return reversenum;
}

int number = GetValue("Введите число (например, пятизначное): ");

if (number == ReverseInt(number))
    Console.WriteLine("Данное число является палиндромом");
else
    Console.WriteLine("Данное число не является палиндромом");