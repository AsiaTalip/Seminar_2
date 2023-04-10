using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        int thirdDigit = GetThirdDigit(number);
        if (thirdDigit == -1) {
            Console.WriteLine("Третьей цифры нет");
        } else {
            Console.WriteLine("Третья цифра числа {0} равна {1}", number, thirdDigit);
        }
    }

    static int GetThirdDigit(int number) {
        int thirdDigit = -1;
        if (number >= 100 && number <= 999) {
            thirdDigit = (number / 100) % 10;
        }
        return thirdDigit;
    }
}