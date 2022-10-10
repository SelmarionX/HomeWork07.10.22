// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write(" Координата X точти A: ");
double ax = int.Parse(Console.ReadLine());

Console.Write(" Координата Y точти A: ");
double ay = int.Parse(Console.ReadLine());

Console.Write(" Координата Z точти A: ");
double az = int.Parse(Console.ReadLine());

Console.Write(" Координата X точти B: ");
double bx = int.Parse(Console.ReadLine());

Console.Write(" Координата Y точти B: ");
double by = int.Parse(Console.ReadLine());

Console.Write(" Координата Z точти B: ");
double bz = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2)); //формула вычесления расстояния между точек в пространстве
Console.WriteLine($"Растояние между точками равно: {Math.Round(result, 3)}");
