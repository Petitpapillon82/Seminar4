//Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120


Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

int GetComp(int a)
{
    int comp = 1; 
    for (int i = 1; i <= a; i++)
    {
        comp *= i;
    }
    return comp;
}
Console.WriteLine(GetComp(A));