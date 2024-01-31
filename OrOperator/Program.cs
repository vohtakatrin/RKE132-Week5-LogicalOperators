////Math >= 90 OR Chemistry >=90 OR Biology >= 90;


//int math, chemistry;
//Console.WriteLine("Enter yout Math exam result(points):");
//math = Int32.Parse(Console.ReadLine());

//Console.WriteLine("Enter yout Chemistry exam result(points):");
//chemistry = Int32.Parse(Console.ReadLine());



//if (math >= 90 || chemistry >= 90)
//{
//    Console.WriteLine("Congratulations! You got accepted");
//}
//else
//{
//    Console.WriteLine("Your application cannot be approved");
//}

//3 varianta

//Math >= 90 OR Chemistry >=90 OR Biology >= 90;
//math && chemistry || math && biology || chemistry && biology

int math, chemistry, biology;
Console.WriteLine("Enter yout Math exam result(points):");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yout Biology exam result(points):");
chemistry = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter yout Chemistry exam result(points):");
biology = Int32.Parse(Console.ReadLine());

if (math >= 90 && chemistry >= 90 || math >= 90 && biology >= 90 || chemistry >= 90 && biology >= 90)
    {
        Console.WriteLine("Congratulations! You got accepted");
    }
    else
    {
        Console.WriteLine("Your application cannot be approved");
    }
