Console.WriteLine("Введите число A");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число C");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите делитель k");
double k = Convert.ToDouble(Console.ReadLine());
if (a % k == 0) {
    Console.WriteLine("Является делителем числа A");
}
else
{
    Console.WriteLine("Не является делителем числа A");
}
if (b % k == 0)
{
    Console.WriteLine("Является делителем чила B");
}
else
{
    Console.WriteLine("Не является делителем числа B");
}
if (c % k == 0)
{
    Console.WriteLine("Является делителем числа C");
}
else
{
    Console.WriteLine("Не является делителем числа C");
}