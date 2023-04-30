// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); // определяем количество элементов исходного массива
string[] Array = new string[n];
string[] Array2 = new string[n];

void FillArray(string[] arr)  // метод заполнения исходного массива
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива: ");
        arr[i] = Console.ReadLine();
    }
}

void PrintArray(string[] arr)  // метод вывода на экран массива
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]} ");

    }
    Console.WriteLine();
}

void FindResultArr(string[] Array, string[] Array2) //метод для определения результата
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)  
        {
            Array2[count] = Array[i]; 
        }

    }
    if (count == 0) Console.WriteLine($"Элементов массива с количеством символов больше или равно 3 нет"); //если второй массив остается незаполнен, тогда выводится фраза на экран, что таких элементов нет

}

FillArray(Array);
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();
FindResultArr(Array, Array2);
PrintArray(Array2);




