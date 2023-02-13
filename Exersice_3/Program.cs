Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 1)
{
    Console.WriteLine($"Число ({number}) является: НЕЧЕТНЫМ");
}
else
{
    Console.WriteLine($"Число ({number}) является: ЧЕТНЫМ");
}