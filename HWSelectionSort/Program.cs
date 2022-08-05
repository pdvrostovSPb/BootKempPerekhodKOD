/* Дана последовательность из N целых чисел и число K.
Необходимо сдвинуть всю последовательность (сдвиг - циклический)
на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N,
во второй строке записаны N целых чисел Ai,
а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.

Примеры
N = 5
5 3 7 4 6
K = 3	
7 4 6 5 3

N = 5
5 3 7 4 6
K = -3
4 6 5 3 7 

//To do

/* 
Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Сортировка пузырьком
for (int i = 0; i < n - 1; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine("Отсортированный массив:" + i + "[" + string.Join(", ", array) + "]");
}
Console.WriteLine("Отсортированный массив: [" + string.Join(", ", array) + "]"); */

/* Console.WriteLine("Введите кол-во элементов массива:");
int n = Convert.ToInt32(Console.ReadLine());
// Заполнение массива
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

// Сортировка выбором

for (int i = 0; i < n - 1; i++)
{
    int MinIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[MinIndex] > array[j])
        {
            int temp = array[MinIndex];
            array[MinIndex] = array[j];
            array[j] = temp;
        }
        Console.WriteLine("Цикл в цикле: шаг " + j + "[" + string.Join(", ", array) + "]");
    }
    Console.WriteLine("Отсортированный массив: шаг " + i + "[" + string.Join(", ", array) + "]");
} */