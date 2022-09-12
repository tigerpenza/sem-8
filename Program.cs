/*
//Task 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
void SwitchRows(int [,] array, int row1, int row2){
    if (row1 >= 0 && row1 < array.GetLength(0) && row2 >= 0 && row2 < array.GetLength(0) && row1 != row2)
        for (int j = 0; j < array.GetLength(1); j++){
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
}
int[,] newArray = CreateRandom2Array();
ShowArray2(newArray);
SwitchRows(newArray, 0, 1);
ShowArray2(newArray);
*/

/*
//Task 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Transpose (int [,] array){
    if (array.GetLength(0) == array.GetLength(1))
        for (int i = 0; i < array.GetLength(0) - 1; i++){
            for (int j = i + 1; j < array.GetLength(1); j++){
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    else Console.WriteLine("Массив не квадратный\n");
}
int[,] newArray = CreateRandom2Array();
ShowArray2(newArray);
Transpose(newArray);
ShowArray2(newArray);
*/


//Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}

void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RemoveMinElement (int [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] changeArr = new int [rows - 1, columns - 1];
    int min = array[0,0];
    int minRow = 0;
    int minColumn = 0;

    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            if(min > array[i,j]){
                min = array[i,j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    int m = 0;
    for(int i = 0; i < rows; i++){
        if (i == minRow) continue;
        int n = 0;
        for(int j = 0; j < columns; j++){
            if (j == minColumn) continue;
            changeArr[m, n] = array[i, j];
            n++;

        }
        m++;
    }

    return changeArr;
}

int[,] newArray = CreateRandom2Array();
ShowArray2(newArray);
int[,] myArr = RemoveMinElement(newArray);
ShowArray2(myArr);


/*
//Task 4. Написать программу поэлементного копирования двумерного массива.
int[,] CreateRandom2Array()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input the max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newArray = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);   
        }
    }
    
    return newArray;
}
void ShowArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CopyArray (int [,] array){
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] changeArr = new int [rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            changeArr[i, j] = array[i, j];
        }
    }
    return changeArr;
}
int[,] newArray = CreateRandom2Array();
ShowArray2(newArray);
int[,] myArr = CopyArray(newArray);
ShowArray2(myArr);
*/