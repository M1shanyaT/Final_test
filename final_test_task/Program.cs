Console.Write("Введите длинну массива -> ");
int length = Convert.ToInt32(Console.ReadLine());

string[] arrayOne = GetArray(length);
int lengthArrayTwo = 0;

for (int j = 0; j < arrayOne.Length; j++)  
{
    if (arrayOne[j].Length <= 3) 
    {
        lengthArrayTwo++;
    }
}

string[] arrayTwo = new string[lengthArrayTwo];
int index = 0;

for (int k = 0; k < arrayOne.Length; k++)
{
    if (arrayOne[k].Length <= 3)
    {
        arrayTwo[index] = arrayOne[k];
        index++;
    }
}

PrintArray(arrayOne);
Console.Write(" -> ");
PrintArray(arrayTwo);

void PrintArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
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



