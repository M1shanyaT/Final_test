string[] arrayOne = GetArray(5);
int lengthArrayTwo = 0;
for (int i = 0; i <= arrayOne.Length - 1; i++)
{
    if (arrayOne[i].Length <= 3) lengthArrayTwo++;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join("; ", array)}]");
}

string[] GetArray(int size)
{
string[] array = new string[size]; 
for (int i = 0; i < size; i++) 
{
Console.Write($"Введите {i} элемент массива: ");
array[i] = Console.ReadLine();
}
return array;
}



