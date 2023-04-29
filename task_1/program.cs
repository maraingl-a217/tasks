Console.Write("Введите x – > ");
double x = Convert.ToDouble(Console.ReadLine());
if (x > 10)
{
   double xb100 = -Math.Sqrt(x * 2);
   double xb101 = 5 + Math.PI;
   double xb10 = xb100 + xb101;
   Console.Write("y равен – > " + xb10);
}
else if (x == 10)
{
   double xr100 = Math.Pow(x * 2, 3);
   double xr101 = Math.Sqrt(x + 3 * x);
   double xr10 = xr100 + xr101;
   Console.Write("y равен – > " + xr10);
}
else
{
   double xm100 = Math.Pow(x * 2 + 1, 3);
   double xm101 = x - 5;
   double xm10 = xm100 / xm101;
   Console.Write("y равен – > " + xm10);
}