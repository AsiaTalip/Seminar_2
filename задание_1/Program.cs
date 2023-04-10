using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите трехзначное число: ");
        int num = int.Parse(Console.ReadLine());

        int secondDigit = (num / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
}
