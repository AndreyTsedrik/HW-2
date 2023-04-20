void FillArray(int[]collection)
{   
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,99);
        index++;
    }
}
void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
}

int[]array = new int [8];
FillArray(array);
PrintArray(array);