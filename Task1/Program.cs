



Console.Clear();

Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(A));

int GetSum(int a)
{
    int sum = 0;

    for (int i = 0; i <= a; i++) 
    {
        sum += 1;    
    }

     return sum;   
}
Console.WriteLine()