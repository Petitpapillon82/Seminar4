//Напишите программу, которая принимает на вход число и выдаёт 
//количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int count = 0; 
for (int i = 0; i <= num; i++)
{
       num = num/10;
       count ++;
}
Console.Write("Количество цифр в числе равно " + count);


