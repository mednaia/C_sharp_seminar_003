Console.WriteLine("Input positive integer and press Enter: ");
int a = int.Parse(Console.ReadLine());
string c;
c = a.ToString();
int number = c.Length;
Console.Write($"The number of digits in {a} = {number}.");