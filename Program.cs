Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
bool isPrime = true;
for (int i = 2; i < number; i++)
{
    if (number % i == 0)
    {
        isPrime = false;
        break;
    }
}
if (isPrime)
{
    Console.WriteLine($"{number} - простое число");
}
else
{
    Console.WriteLine($"{number} - не простое число");
}