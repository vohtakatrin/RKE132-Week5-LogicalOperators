//Math >= 90; Biology >=90; Chemistry >=90;


int math, biology, chemistry;
Console.WriteLine("Enter yout Math exam result(points):");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yout Biology exam result(points):");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yout Chemistry exam result(points):");
chemistry = Int32.Parse(Console.ReadLine());



if (math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved");
}
