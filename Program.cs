string [] GetArray (int size)
{
    string [] array = new string[size];
    for (int i=0; i<size; i++)
    {
        Console.Write("Введите строку - элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray (string [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"'{array[i]}' ");
    }
    Console.WriteLine();
}

int GetNewSize (string [] array)
{
    int size = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i].Length<=3) size++;
    }
    return size;
}

string [] ShortString (string[] array)
{
    int size = GetNewSize(array);
    string [] newarray = new string [size];
    for (int i=0, j=0; i<array.Length; i++)
    {
        if (array [i].Length<=3)
        {
            newarray[j]=array[i];
            j++;
        }
    }
    return newarray;
}

Console.Write("Введите длину массива строк: ");
int lenghtarray = Convert.ToInt32(Console.ReadLine());

string[] array = GetArray(lenghtarray);
PrintArray(array);

if (GetNewSize(array) == 0)
    {
        Console.WriteLine("[]");
        return;
    }

Console.WriteLine("Новый массив из стрoк, которые содержат не более трёх символов:");
PrintArray(ShortString(array));