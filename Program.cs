// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int n = 0;
int j = 0;
string[] array = new string [size];
createArray(array);
CheckShortStrings(array);
string[] newarray = new string[n];
TransferShortStrings(array,newarray);

void createArray (string[] array)
{
    for (int i = 0; i < size; i++)
    {
        System.Console.WriteLine($"Введите {i+1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
}

void CheckShortStrings(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.WriteLine(array[i]);
            n++;
        }
    }
}

void TransferShortStrings(string[] array, string[] newarray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
}
