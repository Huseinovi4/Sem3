System.Console.WriteLine("Написать программу вычисления произведения чисел от 1 до N");
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
int multiply = 1;
for(int i = 1;i<=number;i++){
multiply = multiply*i;
}
System.Console.WriteLine(multiply);

