// See https://aka.ms/new-console-template for more information
Console.Write("Введите колличество элементов массива: \t");
int NumberArray = int.Parse(Console.ReadLine());
int[] NewArray = new int[NumberArray];
for (int i = 0; i < NewArray.Length; i++)
{
    Console.Write($"Вы вводите значение массива {i}: \t");
    NewArray[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\nВывод массива : \t");
for (int i = NewArray.Length-1; i >= 0; --i)
{
    Console.WriteLine(NewArray[i]);
}
Console.ReadLine();