// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int n = Convert.ToInt16(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine("Введите числа");
for(int i=0; i<array.Length; i++)
array[i] = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(string.Join(",", (Count(array))));

int Count(int[] array)
{
    int C = 0;
    for(int i=0; i<array.Length; i++)
    if(array[i] > 0) 
        C=C+1;
    return C;
}