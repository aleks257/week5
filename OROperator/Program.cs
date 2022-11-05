//Math >= 90 OR Chemistry >= 90

//math && chemistry || math && bioligy || chemistry && bioligy

int math, bioligy, chemistry;

Console.WriteLine("Enter your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Bioligy result:");
bioligy = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (math >= 90 && bioligy >= 90) || (chemistry >= 90 && bioligy >= 90))
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}