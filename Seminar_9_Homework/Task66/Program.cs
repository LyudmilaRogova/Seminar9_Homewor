// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//Запрос данных от пользоватея
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"1");
    return num;
}

//Рекурентное вычисление суммы чисел от M до N
int SumMN(int numM, int numN)
{
    if (numM >= numN) return numN; //точка остановки рекурсии
    else return numM + SumMN(numM + 1, numN);
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int outSum = (numM < numN) ? (SumMN(numM, numN)) : (SumMN(numN, numM));
if (numM < numN) PrintData($"Сумма чисел от {numM} до {numN}: ", outSum.ToString());
else PrintData($"Сумма чисел от {numN} до {numM}: ", outSum.ToString());

