using System;

class Program
{
    static void Main(string[] args)
    {
        // Вводим исходный массив строк с клавиатуры
        Console.WriteLine("Введите количество строк в массиве:");
        int n = int.Parse(Console.ReadLine());
        
        string[] originalArray = new string[n];
        Console.WriteLine("Введите строки:");
        for (int i = 0; i < n; i++)
        {
            originalArray[i] = Console.ReadLine();
        }

        // Формируем новый массив из строк, длина которых <= 3 символам
        string[] newArray = FilterArray(originalArray);
        
        // Выводим новый массив на экран
        Console.WriteLine("Новый массив:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
    
    static string[] FilterArray(string[] array)
    {
        // Считаем количество строк, длина которых <= 3 символам
        int count = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        
        // Создаем новый массив нужного размера
        string[] filteredArray = new string[count];
        
        // Заполняем новый массив строками, длина которых <= 3 символам
        int index = 0;
        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                index++;
            }
        }
        
        return filteredArray;
    }
}

