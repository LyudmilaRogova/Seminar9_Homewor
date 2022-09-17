//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//Запрос данных от пользоватея
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"1");
    return num;
}

//Рекурсия: числа от M до N
string NumMN(int numM, int numN)
{
    if (numM >= numN) return numN.ToString(); //точка остановки рекурсии
    else return numM + ", " + NumMN(numM + 1, numN);
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
string outLine = (numM < numN) ? (NumMN(numM, numN)) : (NumMN(numN, numM));
if (numM < numN) PrintData($"Числа от {numM} до {numN}: ", outLine);
else PrintData($"Числа от {numN} до {numM}: ", outLine);

