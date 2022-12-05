// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите колличество элементов массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int [] array = new int [i];

int sum = 0;

for (int count = 0; count < i; count++) 
{
    Console.WriteLine($"Введите {count + 1} элемент массива");
    array[count] = Convert.ToInt32(Console.ReadLine());
    if (array[count] > 0) 
    {
        sum++; 
    }
}
Console.WriteLine(string.Join (", ", array));
Console.WriteLine($"Чесел введенных больше 0 => {sum}");