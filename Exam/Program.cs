//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите кол-во элементов в массиве: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int RandomNumbers(int numberElements, int min, int max)
{
  int[] array = new int [numberElements];
  int sumElements = 0;
  Console.Write("Сгенерированный массив: ");

    for (int i = 0; i < array.Length; i++)
    {
      array[i] = new Random().Next(min, max);

      Console.Write(array[i] + "  ");
      if (i % 2 !=1)
      {
        sumElements += array[i];
      }
    }
    return sumElements;  
}
int array = RandomNumbers(numberElements, 1, 10);
Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях равна {array}");