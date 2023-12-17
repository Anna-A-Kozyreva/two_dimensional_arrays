
// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


// int[,] CreateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] res = CreateMatrix(4, 4, 0, 10);

// PrintMatrix(res);

// int row = res.GetLength(0);
// int col = res.GetLength(1);


// int GetElementValue(int[,] res, int row, int col)
// {
//     if (row < res.GetLength(0) && col < res.GetLength(1))
//     {
//         return res[row, col];
//     }
//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine(GetElementValue(res,1,0));

//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] charArray = new char[,] { { 'a', 'b' }, { 'c', 'd' } };

string result = CreateStringFromArray(charArray);
Console.WriteLine(result);

string CreateStringFromArray(char[,] charArray)
{
    string result = "";

    for (int i = 0; i < charArray.GetLength(0); i++)
    {
        for (int j = 0; j < charArray.GetLength(1); j++)
        {
            result += charArray[i, j];
        }
    }
    return result;
}

//Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string input = "ZDfR1PfE-";
string result = input.ToLower();
Console.WriteLine(result);
