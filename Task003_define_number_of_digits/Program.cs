Console.WriteLine("Input positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
int number = 0;
int temp = a;
while (temp > 0)
{
    temp = temp/10;
    number++;
}
Console.Write($"The number of digits in {a} = {number}.");