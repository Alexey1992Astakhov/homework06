//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3,21 7,04 22,93 -2,71 78,24] -> 75,53

double[] array = new double[10];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-1000, 1000)/10.0;
    Console.Write(array[i] + "  ");
  }
    double maxNumber = array[0];
    double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }
  double result = Math.Abs(maxNumber) - Math.Abs(minNumber);
  Console.WriteLine();
  Console.WriteLine($"\nРазница между между максимальным [{maxNumber}] и минимальным [{minNumber}] элементами -----> {result}");