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
int n = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[n];

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
            Console.WriteLine($"Введите {i}-й элемент массива: ");
            arr[i] = Console.ReadLine();
        }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
       
            Console.Write($"{arr[i]} ");
        
    }
    Console.WriteLine();
}


FillArray(Array);
Console.WriteLine();
PrintArray(Array);
Console.WriteLine();


 

