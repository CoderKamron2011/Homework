
using Lesson2;

bool isContinue = true;

do
{
    Menu();

    Console.Write("Enter command: ");
    string commandMenu = Console.ReadLine();

    if (commandMenu.Contains("1"))
    {
        Console.Write("Rectengle heigth: ");
        double heigth = Convert.ToDouble(Console.ReadLine());
        Console.Write("Rectengle width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        IShapeCalculator rectagle = new RectangleService(width, heigth);

        Console.WriteLine($"Rectengle is surface: {rectagle.Yuza()}");
        Console.WriteLine($"Rectengle is perimetr: {rectagle.ShaklUzunligi()}");
    }
    if (commandMenu.Contains("2"))
    {

    }
    if (commandMenu.Contains("3"))
    {

    }

    Console.Write("Is Continue(yes/ no): ");
    string command = Console.ReadLine();
    if (command.Contains("no") is true)
    {
       isContinue = false;
    }
} while (isContinue is true);

static void Menu()
{
    Console.WriteLine("Wolcome to, project");
    Console.WriteLine("1. Rectengle");
    Console.WriteLine("2. Circle");
    Console.WriteLine("3. Square");
}