// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!! Enter your name");
string name = Console.ReadLine();
System.Console.WriteLine($"Hello {name}!");
Console.WriteLine("Ткаченко Виктория Михайловна");
Console.WriteLine(DateTime.Now);
bool program_running = true;
while (program_running){
    Console.WriteLine(DateTime.Today);
Console.WriteLine("Do you want to continue?");
string answer = Console.ReadLine();
switch (answer)
{
    case "y":
            System.Console.WriteLine("Okay!");break;
    case "n": System.Console.WriteLine("Bye!");
            program_running = false;
    break;
}
}
