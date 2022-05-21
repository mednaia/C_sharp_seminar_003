//Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Input positive integer and press Enter: ");
int n = int.Parse(Console.ReadLine());
int product = 1;
for (int count = 1; count<=n; count++)
{
    product = product * count;
}
Console.Write($"Product of digits from 1 to {n} = {product}.");
