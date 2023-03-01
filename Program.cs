// Написать программу, которая из имеющегося массива строк формирует массив
// из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.



// Метод генерации массива
string[] GenerateArray(int itemCount, int maxWordLen)
{
    string[] result = new string[itemCount];
    Random rand = new Random();
    int stringlen;
    int randValue;
    string str;
    char letter;
    for (int row = 0; row < itemCount; row++)
    {
        stringlen = rand.Next(1, maxWordLen);
        str = "";
        for (int i = 0; i < stringlen; i++)
        {

            randValue = rand.Next(0, 26);
            letter = Convert.ToChar(randValue + 65);
            str = str + letter;
        }
        result[row] = str;
    }
    return result;
}

// Метод печати массива
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("");
}

// Метод генерации отфильтрованного массива
string[] ArrayFilter(string[] array, int num)
{
    string[] arr = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num)
        {
            int currLen = arr.Length;
            Array.Resize(ref arr, currLen + 1);
            arr[currLen] = array[i];
        }
    }
    return arr;
}


Console.WriteLine("Введите максимальную длину строки");
int maxWordLen = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите желаемое количество строк в массиве");
int itemCount = Convert.ToInt32(Console.ReadLine());

string[] sourceArray = GenerateArray(itemCount, maxWordLen * 2); // Вызов метода заполнения массива строк
string[] filteredArray = ArrayFilter(sourceArray, maxWordLen); // Вызов метода фильтруещего массив строк

PrintArray(sourceArray); // Печать начально массива строк
Console.WriteLine("Результат");
PrintArray(filteredArray); // Печать отфильтрованного массива строк