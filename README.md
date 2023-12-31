# Итоговая контрольная работа по основному блоку
## Описание задачи
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры:**
```
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
```
## Описание решения задачи
1. Создание функции для ввода массива через терминал
2. Создание функции для вывода массива на экран
3. Проверяем сколько будет длинна массива **arrayTwo** с помощью цикла ``for``
4. Проверяем каждый эелемент массива **arrayOne** , подходят они под условие или нет
5. Элементы которые подходят складываем в массив **arrayTwo**
6. Выводим исходный массив и получившийся результат
## Блок-схема задачи
![Block-diagram](Final_test/picture/block_diagram.png)
Ссылка на блок-схему 
```
https://drive.google.com/file/d/1l8yKSB76FPd4EGniTsztQlZSkqTbNn6d/view?usp=sharing
```
## Код задачи
```
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
```