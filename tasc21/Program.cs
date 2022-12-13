// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53
// D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2)

Console.WriteLine("Введите координаты числа А по х:");
double Ax=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа А по y:");
double Ay=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа А по z:");
double Az=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа B по х:");
double Bx=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа B по y:");
double By=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты числа B по z:");
double Bz=Convert.ToInt32(Console.ReadLine());

double resx = Math.Pow((Bx-Ax),2);
double resy = Math.Pow((By-Ay),2);
double resz = Math.Pow((Bz-Az),2);
Console.WriteLine($"{Math.Sqrt(resx+resy+resz):f2}");