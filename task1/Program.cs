// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
string[] array1 = new string[11] {"One", "2", "3", "hello", "hello", "world", "Russia", "Denmark", "Kazan", "computer", "science"};
string[] array2 = new string[array1.Length];
void TreeDigitsArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; array1[i].Length <= 3; i++)
    {
        array2[count] = array1[i];
        count++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
TreeDigitsArray(array1, array2);
System.Console.WriteLine();
System.Console.WriteLine("Массив 1: ");
System.Console.WriteLine();
PrintArray(array1);
System.Console.WriteLine();
System.Console.WriteLine("Массив 2: ");
PrintArray(array2);
System.Console.WriteLine();