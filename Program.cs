// написать программу, которая из имеющегося массива строк формирует массив строк длина которых меньше
// либо равна 3 символам. Первоначальный массив нужно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма

using System;
using static System.Console;
Clear();

string[] M; 
WriteLine("Please type strings separated by spaces:");
string initialString = ReadLine();
M = initialString.Split(' ');
string[] result = new string[M.Length];
int size = 0;
foreach (var value in M)
{
    if(value.Length <=3)
    {
        result[size] = value;
        size++;
    }
}
WriteLine(string.Join(" ", result, 0, size));









