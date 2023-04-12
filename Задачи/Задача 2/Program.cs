System.Console.WriteLine("Введите число ");
string s = Console.ReadLine();
int i = int.Parse(s);
if (i > 99){
    System.Console.WriteLine(s[2]);
}
else{
    System.Console.WriteLine("Третьей цыфры нет");
}