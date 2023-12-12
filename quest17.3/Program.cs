public enum Position
{
    Manager = 160,
    Developer = 160,
    Designer = 160,
    Salesperson = 160,
    Marketer = 160
}

public class Accountant
{
    public bool AskForBonus(Position worker, int hours)
    {
        return hours > (int)worker;
    }
}

class Programm
{
    static public void CreateMenu(
    string head /*Шапка (Не больше 8 в высоту)*/,
    int version /*Видимость версии*/,
    Dictionary<string, Action> programs /*Словарь*/)
    {
        Console.Clear();
        string[] items = new string[programs.Keys.Count];
        programs.Keys.CopyTo(items, 0);

        int index = 0;
        while (true)
        {
            Console.CursorVisible = false;

            if (head != "0")
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(head);
            }

            for (int i = 0; i < items.Length; i++)
            {
                Console.SetCursorPosition(52, i + 12);
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("// " + items[i]);
                    Console.ResetColor();
                }
                else { Console.WriteLine(" " + items[i] + "  "); }
            }

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.Q: Console.Clear(); return;

                case ConsoleKey.DownArrow:
                    if (index < items.Length - 1) index++;

                    else index = 0;

                    break;
                case ConsoleKey.UpArrow:
                    if (index > 0) index--;

                    else index = items.Length - 1;

                    break;
                case ConsoleKey.Enter:
                    programs.Values.ElementAt(index).Invoke(); Console.Clear(); break; // Выполнение функции класса Execute
            }
        }
    }
    static public void CheckHoursManager()
    {
        Console.Clear();
        Console.SetCursorPosition(48, 12);
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Accountant accountant = new Accountant();

        if (accountant.AskForBonus(Position.Manager, hours))
        {
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("Бонус получен");
        }
        else
        {
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("Бонуса не будет");
        }
        Console.ReadKey();
    }
    static public void CheckHoursDeveloper()
    {
        Console.Clear();
        Console.SetCursorPosition(48, 12);
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Accountant accountant = new Accountant();

        if (accountant.AskForBonus(Position.Developer, hours))
        {
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("Бонус получен");
        }
        else
        {
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("Бонуса не будет");
        }
        Console.ReadKey();
    }
    static public void CheckHoursDesigner()
    {
        Console.Clear();
        Console.SetCursorPosition(48, 12);
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Accountant accountant = new Accountant();

        if (accountant.AskForBonus(Position.Designer, hours))
        {
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("Бонус получен");
        }
        else
        {
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("Бонуса не будет");
        }
        Console.ReadKey();
    }
    static public void CheckHoursSalesperson()
    {
        Console.Clear();
        Console.SetCursorPosition(48, 12);
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Accountant accountant = new Accountant();

        if (accountant.AskForBonus(Position.Salesperson, hours))
        {
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("Бонус получен");
        }
        else
        {
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("Бонуса не будет");
        }
        Console.ReadKey();
    }
    static public void CheckHoursMarketer()
    {
        Console.Clear();
        Console.SetCursorPosition(48, 12);
        Console.Write("Введите количество часов: ");
        int hours = int.Parse(Console.ReadLine());

        Accountant accountant = new Accountant();

        if (accountant.AskForBonus(Position.Marketer, hours))
        {
            Console.SetCursorPosition(55, 13);
            Console.WriteLine("Бонус получен");
        }
        else
        {
            Console.SetCursorPosition(54, 13);
            Console.WriteLine("Бонуса не будет");
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {

        Dictionary<string, Action> position = new Dictionary<string, Action>()
        {
            ["Менеджер"] = CheckHoursManager,
            ["Разработчик"] = CheckHoursDeveloper,
            ["Дизайнер"] = CheckHoursDesigner,
            ["Менеджер продаж"] = CheckHoursSalesperson,
            ["Маркетолог"] = CheckHoursMarketer
        };

        Console.Clear();
        CreateMenu("0", 0, position);
        Console.Clear();
    }
}
