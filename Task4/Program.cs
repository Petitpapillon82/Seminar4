//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

Console.WriteLine("Массив из 8 элементов, заполненный нулями и единицами в случайном порядке: ");
int[] array = new int[8];
Random r = new Random();
for (int i = 0; i < array.Length; i++)
{
array[i] = r.Next(0, 2);
Console.Write(array[i] + " ");
}
Console.Read();