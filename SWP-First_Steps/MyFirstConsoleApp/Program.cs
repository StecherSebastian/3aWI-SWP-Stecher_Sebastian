Console.WriteLine("Hell SWP!");

string username;
Console.Write("Enter your name: ");
username = Console.ReadLine();
Console.WriteLine("Your name is " + username);

int age = 0;
Console.Write("Enter your age: ");
age = Int32.Parse(Console.ReadLine());
Console.WriteLine("Your age is " + age);
if (age >= 15) 
{
    Console.WriteLine("You are old enough.");
} else
{ 
    Console.WriteLine("You are to young.");
};
