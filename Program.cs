/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

*/



System.Console.WriteLine("Введите элементы массива через пробел:");
string[] InputArray = Console.ReadLine().Split(' ');
 
int count = 0;
    foreach (string str in InputArray)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }
 
string [] OutputArray = new string[count];
Console.WriteLine("Новый массив:");
 
int index = 0;
    foreach (string str in InputArray)
    {
        if (str.Length <= 3)
        {
            OutputArray[index] = str;
            System.Console.Write(OutputArray[index] + " ");
            index++;
        }
    }
