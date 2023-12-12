string[] res = GetArray(5);
Console.WriteLine($"Первоначальный массив: [{String.Join("; ", res)}]");
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
