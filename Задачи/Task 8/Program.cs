System.Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int i = 0;
while(n > 0){
    i = n % 10;
    sum = sum + i;
    n = n / 10;
    }
Console.WriteLine($"Сумма цифр равна: {sum}");