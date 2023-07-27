void Intersection_point(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());


Intersection_point(k1, b1, k2, b2);