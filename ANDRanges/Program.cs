//temp <= 0 - Freezing cold
//temp >0 AND temp < 10 - Cold
//temp >= 10 AND temp < 15 - Chilly
//temp >= 15 AND temp < 20 - Warm
//temp >= 20 AND temp < 30 - Hot
//temp >= 30 - Boiling hot

using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Please enter the temperature:");
int temp = Int32.Parse(Console.ReadLine());

if (temp >= 30)
{
    Console.WriteLine("Temperature is Boiling hot");
}
else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("Temperature is Hot");
}
else if (temp >= 15 && temp < 20)
{
    Console.WriteLine("Temperature is Warm");
}
else if (temp >= 10 && temp < 15)
{
    Console.WriteLine("Temperature is Chilly");
}
else if (temp > 0 && temp < 10)
{
    Console.WriteLine("Temperature is Cold");
}
else
{
    Console.WriteLine("Temperature is Freezing cold");
}