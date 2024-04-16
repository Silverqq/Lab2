using System;

public class Program
{
    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum TimeOfDay
    {
        Morning,
        Daytime,
        Evening,
        Night
    }

    static void Main()
    {
        string dayInput;
        int timeInput;

        Console.WriteLine("Введите день недели: (От 0 до 6)");
        while (true)
        {
            dayInput = Console.ReadLine();
            if (dayInput == "0" | dayInput == "1" | dayInput == "2" | dayInput == "3"|
                dayInput == "4" | dayInput == "5" | dayInput == "6")
            {
                break;
            }
            else
            {              
                Console.WriteLine("Неверное значение дня недели");
                Console.WriteLine("Введите день недели: (От 0 до 6)");
            }

        }

        Console.WriteLine("Введите время (от 0 до 23):");
        while (true)
        {
            timeInput = int.Parse(Console.ReadLine());
            if (timeInput >= 0 && timeInput <= 23) 
            {
                break;
            }
            else
            {
                Console.WriteLine("Неверное значение времени");
                Console.WriteLine("Введите время (от 0 до 23):");
            }
        }

        DayOfWeek day;
        if (!Enum.TryParse(dayInput, out day))
        {
            Console.WriteLine("Некорректный день недели");
            return;
        }
        TimeOfDay time;
        if (timeInput >= 7 && timeInput <= 12)
        {
            time = TimeOfDay.Morning;
        }
        else if (timeInput >= 13 && timeInput <= 18)
        {
            time = TimeOfDay.Daytime;
        }
        else if (timeInput >= 19 && timeInput <= 23)
        {
            time = TimeOfDay.Evening;
        }
        else
        {
            time = TimeOfDay.Night;
        }

        Console.WriteLine($"Сейчас {day}, {(TimeOfDay)time}");
    }
}
