System.Console.WriteLine("Показать кубы чисел, заканчивающихся на четную цифру");
System.Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);
double numberCubed = Math.Pow(number, 3);
if (numberCubed % 2 == 0){
  System.Console.WriteLine(numberCubed);
}
else{
  System.Console.WriteLine("Число заканчивается на нечетную цифру");
}