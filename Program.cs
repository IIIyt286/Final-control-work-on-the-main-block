Console.WriteLine("Введите размер массива ");
int len = Convert.ToInt32(Console.ReadLine());
string[] array = new string[len];

fillArray(array);
printArray(array);
string[] finalArr = newArray(array);
Console.WriteLine("\nНовый массив");
printArray(finalArr);


void fillArray(string[] arr)
{
    Console.WriteLine("Введите элементы массива ");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
}

void printArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"|{arr[i]}|");
    }
}

string[] newArray(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] resultArray = new string[count];
    
    int index = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[index] = arr[i];
            index++;
        }
    }

    return resultArray;
}





