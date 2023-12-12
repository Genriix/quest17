public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Gray
}

public static class ColorPrinter
{
    public static void Print(string stroka, Color color)
    {
        Console.ForegroundColor = GetConsoleColor(color);
        Console.WriteLine(stroka);
        Console.ResetColor();
    }

    private static ConsoleColor GetConsoleColor(Color color)
    {
        switch (color)
        {
            case Color.Red:
                return ConsoleColor.Red;
            case Color.Green:
                return ConsoleColor.Green;
            case Color.Blue:
                return ConsoleColor.Blue;
            case Color.Yellow:
                return ConsoleColor.Yellow;
            case Color.Gray:
                return ConsoleColor.Gray;
            default:
                return ConsoleColor.White;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        Console.WriteLine("Выберите цвет: ");
        foreach (Color color in Enum.GetValues(typeof(Color)))
        {
            Console.WriteLine($"{(int)color}. {color}");
        }
        Console.Write("Цвет (номер): ");
        int colorNumber = int.Parse(Console.ReadLine());

        Color selectedColor = (Color)colorNumber;

        ColorPrinter.Print(stroka, selectedColor);

        Console.ReadLine();
    }
}