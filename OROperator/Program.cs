int math, biology, chemistry;

Console.WriteLine("Enter your Math result:");
math = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = int.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = int.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && biology >= 90) || (chemistry >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You got accepted.");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}