/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Write($"Сколько чисел вы хотети ввести?. Введите колчиество: ");
int a = 0;

a = int.Parse(Console.ReadLine());

int sum = 0;
int[] array = new int [a];
for (int i = 0; i < a; i++)
{
    Console.Write($"Введите {i+1} число:");
    array[i] = int.Parse(Console.ReadLine());
    if (array[i] > 0)
    {
        sum = sum + 1;
    }
}

for (int i =0; i < a; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine($"-> {sum}");