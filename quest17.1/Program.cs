class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите дату вашего рождения (в формате ДД.ММ.ГГГГ):");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime birthday))
        {
            DateTime today = DateTime.Today;

            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            int daysUntilNextBirthday = (nextBirthday - today).Days;

            Console.WriteLine($"До вашего следующего дня рождения осталось: {daysUntilNextBirthday} дней");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты");
        }

        Console.ReadLine();
    }
}