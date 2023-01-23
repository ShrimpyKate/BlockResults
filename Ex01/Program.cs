// Написать программу, которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

//1. Задать размер массива
//2. Создать массив 
//3. Наполнить массив
//4. Наполнить новый массив длинна >=3

//1. Set size of array
int GetArraySize()
{
  Console.WriteLine("Введите количество элементов массива: ");
  int size = Convert.ToInt32(Console.ReadLine());
  return size;
}

//2.Create array
string[] CreateArray(int size)
{
  return new string[size];
}

//3.Fill array 
void FillArray(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    stringArray[i] = Console.ReadLine();
  }
}
//4.Set array random size
int GetArrayRandomSize()
{
  Console.WriteLine("Количество элементов нового массива: ");
  int size = Random.Shared.Next(0, 4);
  Console.WriteLine(size);
  return size;

}
//5. Fill new array
void FillNewStringArray(string[] stringArray, string[] newStringArray)
{
  Console.Write("[");
  for (int i = 0; i < newStringArray.Length; i++)
  {
    newStringArray[i] = stringArray[i];
    if (i == newStringArray.Length - 1)
      Console.Write($"{stringArray[i]}]");
    else Console.Write($"{stringArray[i]}, ");

  }
}

int size = GetArraySize();
string[] stringArray = CreateArray(size);
FillArray(stringArray);
int newsize = GetArrayRandomSize();
string[] newStringArray = CreateArray(newsize);
Console.WriteLine("Новый массив строк: ");
FillNewStringArray(stringArray, newStringArray);
