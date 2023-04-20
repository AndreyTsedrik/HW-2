System.Console.WriteLine("Введите число A: ");
  int A = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число B: ");
  int B = int.Parse(Console.ReadLine());
int pow = A;

for (int count = 1; count < B; count++)
{
    pow = pow * A;
}
Console.WriteLine($"{pow}");


