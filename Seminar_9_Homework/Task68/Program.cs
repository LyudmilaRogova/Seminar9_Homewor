// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

//Запрос данных от пользоватея
int ReadData(string line)
{
    Console.Write(line);
    int num = int.Parse(Console.ReadLine()??"1");
    return num;
}

//Вычисление функции Аккермана
int AckermanFunction(int numM, int numN)
{
    if (numM == 0) return numN + 1; //точка остановки рекурсии
    if (numN == 0) return AckermanFunction(numM - 1, 1);
    else return AckermanFunction(numM - 1, AckermanFunction(numM, numN - 1));
}

//Вывод результата
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
int result = AckermanFunction(numM, numN);
PrintData($"A({numM}, {numN}) = ", result.ToString());

