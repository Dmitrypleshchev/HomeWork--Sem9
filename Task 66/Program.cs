/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int InputNumbers(string argument)
{
  Console.WriteLine($"Введите {argument}:");
  return int.Parse(Console.ReadLine());
}

int m = InputNumbers("число M");
int n = InputNumbers("число N");

void FindSumNumbers(int m, int n, int sum)
{
  if(m > n)
  {
    Console.WriteLine($"Сумма чисел в заданном промежутке равна {sum}");
    return;
  }
  sum = sum + (m++);
  FindSumNumbers(m, n, sum);
}

FindSumNumbers(m, n, 0);

