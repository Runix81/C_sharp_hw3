// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int InputInt(string message)
{
    System.Console.Write($"{message} -> ");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x1 - x2;
    int deltaY = y1 - y2;
    int deltaZ = z1 - z2;
    return Math.Sqrt(deltaX*deltaX + deltaY*deltaY + deltaZ*deltaZ);
}
int x1 = InputInt($"Введите координату x первой точки");
int x2 = InputInt($"Введите координату x второй точки");
int y1 = InputInt($"Введите координату y первой точки");
int y2 = InputInt($"Введите координату y второй точки");
int z1 = InputInt($"Введите координату z первой точки");
int z2 = InputInt($"Введите координату z второй точки");

System.Console.WriteLine($"Расстояние между точкой A({x1},{y1},{z1}) и B({x2},{y2},{z2}) равно {Distance(x1,y1,z1,x2,y2,z2):F2}");