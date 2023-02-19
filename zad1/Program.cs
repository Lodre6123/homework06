/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int NumPolog(int number)
{
    int result = 0;
    for(int i = 0; i < number; i++)
    {
        Console.Write($"вы ввели #{i + 1}: ");
        if(Convert.ToInt32(Console.ReadLine()) > 0)
            result++;
    }
    return result;
}

Console.Write("Вводим кол-во чисел: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено {NumPolog(num)} положительных числа");