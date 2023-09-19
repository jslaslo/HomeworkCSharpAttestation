// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
System.Console.WriteLine(GetSumNumbers(4, 8));
int GetSumNumbers(int minValue, int maxValue)
{    
    if (minValue == maxValue)
    {
        return minValue;
    }
    else
    {        
        return minValue + GetSumNumbers(minValue + 1, maxValue);
    }
}
