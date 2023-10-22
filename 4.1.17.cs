class MainClass
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
		var Color = Console.ReadLine();
		if (Color == "gray")
		{
			Console.BackgroundColor = ConsoleColor.Gray;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is gray!");
		}
		else if (Color == "green")
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;


			Console.WriteLine("Your color is green!");
		}
		else
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is cyan!");
		}
	}
}