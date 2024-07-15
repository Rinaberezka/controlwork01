﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
    
// string[] Array = Console.ReadLine().Split();
        
string[] Array = ["Hello", "2", "world", ":-)"];

// string[] Array = ["123", "-2", "company"];
        
string[] tempArray = new string[Array.Length];
int n = 0;

        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i].Length <= 3)
            {
                tempArray[n] = Array[i];
                n++;
            }
        }

        // Создание нового массива
        string[] newArray = new string[n];
        for (int i = 0; i < n; i++)
        {
            newArray[i] = tempArray[i];
           Console.WriteLine(newArray[i]); 
        }
        
 Console.WriteLine("Новый массив строк:[{0}]",string.Join(" ,", newArray));
