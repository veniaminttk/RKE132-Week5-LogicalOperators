Console.WriteLine("Enter the temperature:");
int temp = int.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Boiling hot.");
}
else if (temp >= 20)
{
    Console.WriteLine("Hot.");
}
else if (temp >= 15)
{
    Console.WriteLine("Warm.");
}
else if (temp >= 10)
{
    Console.WriteLine("Chilly.");
}
else if (temp > 0)
{
    Console.WriteLine("Cold.");
}
else
{
    Console.WriteLine("Freezing cold.");
}