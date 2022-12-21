// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Random random = new Random();
Console.Write("Введитче число рядов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите глубину массива: ");
int c = Convert.ToInt32(Console.ReadLine());

int j = 10;
int[] randomList = new int[90];
for (int i = 0; i < 90; i++, j++)
{
    randomList[i] = j;
}
for (int k = 89; k >= 1; k--)
{
    int l = random.Next(k + 1);
    int tmp = randomList[l];
    randomList[l] = randomList[k];
    randomList[k] = tmp;
}

Console.WriteLine();
int[,,] table = new int[a, b, c];
int element = 0;
for (int x = 0; x < a; x++)
{
    for (int y = 0; y < b; y++)
    {
        for (int z = 0; z < c; z++, element++)
        {
            table[x, y, z] = randomList[element];
            Console.Write($"{table[x, y, z]}({x},{y},{z}) ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();