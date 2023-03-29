// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array); 
WriteArray(array);
void FillArray(int[] arr) 
{
    Random rand = new Random(); 
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0,101);
    }
}

void WriteArray (int[] arr) // метод вывода массива
{
      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write(arr[i]+ " "); 
      }
}