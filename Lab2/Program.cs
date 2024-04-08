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
        Console.WriteLine("Введите день недели: (От 0 до 6)");
        string dayInput = Console.ReadLine();

        Console.WriteLine("Введите время (от 0 до 23):");
        int timeInput = int.Parse(Console.ReadLine());

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