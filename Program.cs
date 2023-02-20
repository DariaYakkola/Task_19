Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0) 
{
  if (number > 9999 && number < 100000)
  {
    int number1 = number / 10000;
    int mediumNumber5_1 = number % 10000;
    int mediumNumber5_2 = mediumNumber5_1 % 1000;
    int mediumNumber5_3 = mediumNumber5_2 % 100;
    int number5 = mediumNumber5_3 % 10;
    if (number1 == number5)
    {
      int mediumNumber2 = number % 10000;
      int number2 = mediumNumber2 / 1000;
      int mediumNumber4_1 = mediumNumber2 % 1000;
      int mediumNumber4_2 = mediumNumber4_1 % 100;
      int number4 = mediumNumber4_2 / 10;
      if (number2 == number4)
      {
        Console.WriteLine($"{number} - это палиндром!");
      }
      else
      {
        Console.WriteLine($"{number} - это не палиндром!");
      }
    }
    else
    {
      Console.WriteLine($"{number} - это не палиндром!");
    }
    
  }
  else
  {
    Console.WriteLine($"Введено не пятизначное число! ");
  }
}
else
{
  int positiveNumber = number * -1;
  if (positiveNumber > 9999 && positiveNumber < 100000)
  {
    int number1 = positiveNumber / 10000;
    int mediumNumber5_1 = positiveNumber % 10000;
    int mediumNumber5_2 = mediumNumber5_1 % 1000;
    int mediumNumber5_3 = mediumNumber5_2 % 100;
    int number5 = mediumNumber5_3 % 10;
    if (number1 == number5)
    {
      int mediumNumber2 = positiveNumber % 10000;
      int number2 = mediumNumber2 / 1000;
      int mediumNumber4_1 = mediumNumber2 % 1000;
      int mediumNumber4_2 = mediumNumber4_1 % 100;
      int number4 = mediumNumber4_2 / 10;
      if (number2 == number4)
      {
        Console.WriteLine($"{number} - это палиндром!");
      }
      else
      {
        Console.WriteLine($"{number} - это не палиндром!");
      }
      }
    else
    {
      Console.WriteLine($"{number} - это не палиндром!");
    }
    }
  else
  {
    Console.WriteLine($"Введено не пятизначное число! ");
  }
}
