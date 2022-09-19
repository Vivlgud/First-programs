Console.Clear();

// пример синтаксиса метода (функции)
// // int Max(int arg1, int arg2, int arg3)
// {
//     int res = arg1;
//     if (arg2 > res) res = arg2;
//     if (arg3 > res) res = arg3;
//     return res;
// }
// Пример масива
// int[] array = { 11, 12, 13, 14, 15, 16, 17, 18, 19 };
// int max = Max(array[0], array[1], array[2]);

// int n=array.Length; получение длины массива

// Console.WriteLine(max);

int[] array = new int[10];

// Заполнение массива
void FillArray(int[] num)
{
    int lenght = num.Length;
    int index = 0;
    while (index < lenght)
    {
        num[index] = new Random().Next(1, 10);
        index++;
    }
}
// Вывод массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(col[pos]+", ");
        pos++;
    }

}
// Вызов метода
FillArray (array);
PrintArray(array);

// Поиск элемента
int IndexOf(int[] col,int find)
{
    int count=col.Length;
    int index=0;
    int position=-1;// значение -1 взято для обозначения не найденного значения.
    while(index<count)
    {
        if(col[index]==find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

Console.WriteLine();

int pos1=IndexOf(array,5);
Console.WriteLine(pos1);
