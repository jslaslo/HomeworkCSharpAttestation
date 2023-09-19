// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
System.Console.WriteLine(GetAckermanFunc(3,2));
int GetAckermanFunc(int firstValue, int secondValue){
    while(firstValue != 0){
        if(secondValue == 0){
            secondValue = 1;
        }
        else{
        secondValue = GetAkkermanFunc(firstValue,secondValue-1);
        }
        firstValue -= 1;
    }
    return secondValue + 1;
}