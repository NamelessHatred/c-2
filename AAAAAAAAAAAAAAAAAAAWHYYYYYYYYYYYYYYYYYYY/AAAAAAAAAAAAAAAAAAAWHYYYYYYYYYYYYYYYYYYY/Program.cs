namespace AAAAAAAAAAAAAAAAAAAWHYYYYYYYYYYYYYYYYYYY
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine("Выберите программу:");
                Console.WriteLine("1. Игра 'Угадай число'");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("0. Выход");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PlayGuessNumber();
                        break;
                    case 2:
                        PrintMultiplicationTable();
                        break;
                    case 3:
                        PrintDivisors();
                        break;
                    case 0:
                        exitProgram = true;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void PlayGuessNumber() ///Метод
        {
            Random random = new Random(); ///Ввод колекции random
            int targetNumber = random.Next(0, 101); ///Создаёт случайное число
            int userNumber; ///Вводит переменную, которая отвечает за то число, которое вводит пользователь

            Console.WriteLine("Игра 'Угадай число'"); ///Выводит текст
            do
            {
                Console.Write("Введите число: "); ///Выводит текст
                userNumber = Convert.ToInt32(Console.ReadLine()); ///Присваивает переменной число, которое было введено пользоваетелем

                if (userNumber == targetNumber) /// Условие. Если число пользователя равно случайному числу.
                {
                    Console.WriteLine("Поздравляю! Вы угадали число!"); ///Выводит текст
                    return; /// Возвращает к меню
                }
                if (userNumber > targetNumber) /// Условик. Если число пользователя больше.
                {
                    Console.WriteLine("Меньше"); ///Выводит текст
                }
                if (userNumber < targetNumber) ///Условие. Если число пользователя меньше.
                {
                    Console.WriteLine("Больше"); ///Выводит текст
                }
                Console.WriteLine("Неверное число. Попробуйте снова."); ///Выводит текст
            } while (true); ///Условие - пока true
        }

        static void PrintMultiplicationTable() /// Метод, отвечающий за таблицу умножения
        {
            int[,] table = new int[10, 10]; /// Создание массива с ограничением "10, 10"

            for (int i = 1; i <= 10; i++) /// Создание цикла. К переменной i, которая равна одному, прибавляется 1, пока переменная меньше или равна 10.
            {
                for (int j = 1; j <= 10; j++) /// Создание ещё одного цилка. Переменная j равна 1. Пока он равна или меньше 10, к ней прибавляется 1.
                {
                    table[i - 1, j - 1] = i * j; /// заполняет каждый элемент массива table результатом умножения соответствующих множителей i и j.
                }
            }

            Console.WriteLine("Таблица умножения:"); /// Выводит текст
            for (int i = 1; i <= 10; i++) /// Тоже самое создание цикла что и ранее.
            {
                for (int j = 1; j <= 10; j++) /// Тоже самое создание цикла что и ранее.
                {
                    Console.Write("{0,4}", table[i - 1, j - 1]);
                }
                Console.WriteLine();
            }
        }

        static void PrintDivisors()
        {
            Console.WriteLine("Вывод делителей числа");
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Делители числа {0}: ", number);
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}