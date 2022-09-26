//метод для замены одних символов на другие в произвольном тексте
/*string text="Сегодня мы углубимся в тему и выделим 4 основных группы методов.";
string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length=text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]==oldValue) result=result + $"{newValue}";
        else result=result+$"{text[i]}";
    }
    return result;
}

string newtext=Replace(text,' ','=');
Console.WriteLine(newtext);*/

//Сортировка массива

int[] arr={2,3,7,4,9,3,5,6,7,4};

void PrintArray(int[] array)
{
    int count=array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]},");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i=0; i<array.Length-1; i++)
    {
        int minPos=i;
        for (int j = i+1; j < array.Length; j++)
        {
           if(array[j]<array[minPos]) 
           {
            minPos=j;
           }
        }
        int temp=array[i];
        array[i]=array[minPos];
        array[minPos]=temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);