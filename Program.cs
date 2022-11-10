// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
FillArrayRandomNum (num);

PrintArray(num);
int count = 0;

for (int z = 0; z < num.Length; z++)
if (num[z] % 2 == 0)
count++;

Console.WriteLine($"В массиве  {num.Length} числа, {count} из них чётные");

void FillArrayRandomNum (int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
        for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
       Console.WriteLine();
}
