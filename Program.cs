using System;

namespace DetermineSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the month number (1 to 12): ");
            int month = int.Parse(Console.ReadLine());

            // Перевірка чи номер місяця лежить у допустимому діапазоні.
            if (month < 1 || month > 12)
            {
                // Виведення повідомлення про помилку, якщо номер місяця не входить у діапазон від 1 до 12.
                Console.WriteLine("Error: Month number must be between 1 and 12.");
            }
            else
            {
                // Використання виразу переключення (switch expression) для визначення пори року.
                string season = month switch
                {
                    // Зима, якщо місяць 12, 1 або 2.
                    12 or 1 or 2 => "Winter",
                    // Весна, якщо місяць 3, 4 або 5.
                    3 or 4 or 5 => "Spring",
                    // Літо, якщо місяць 6, 7 або 8.
                    6 or 7 or 8 => "Summer",
                    // Осінь, якщо місяць 9, 10 або 11.
                    9 or 10 or 11 => "Autumn",

                    // Якщо номер місяця не підпадає під жоден кейс, повернути "Невідомо".
                    _ => "Unknown"
                };

                // Виведення пори року.
                Console.WriteLine("It's " + season + ".");
            }
        }
    }
}
