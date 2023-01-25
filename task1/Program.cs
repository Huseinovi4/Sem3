Console.WriteLine("Найти кубы чисел от 1 до N");
Console.WriteLine("Введите число от 1 до N:");
int number = int.Parse(Console.ReadLine()!);
for(int i = 1;i<=number;i++){
double numberCubed = Math.Pow(i,3);
System.Console.WriteLine(numberCubed);
}

