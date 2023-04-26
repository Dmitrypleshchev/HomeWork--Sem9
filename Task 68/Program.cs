/* Задача 68:Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int InputNumbers(string argument)
{
  Console.WriteLine($"Введите {argument}:");
  return int.Parse(Console.ReadLine());
}

int m = InputNumbers("число M");
int n = InputNumbers("число N");

int FindAkkerman (int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return FindAkkerman(m - 1, 1);
else return FindAkkerman(m - 1, FindAkkerman(m, n - 1));
}

Console.WriteLine($"Функция Аккермана равна {FindAkkerman(m, n)}");