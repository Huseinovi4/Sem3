System.Console.WriteLine("Подсчитать сумму цифр в числе");
Console.WriteLine("Введите любое число:");
int number = int.Parse(Console.ReadLine()!);
string numberStr = Convert.ToString(number);
int sum=0;
for(int i = 0;i<numberStr.Length;i++){
int digit = number%10;
sum = sum + digit;
number=number/10;
}
Console.WriteLine(sum);