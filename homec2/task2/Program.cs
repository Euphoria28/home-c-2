//Задача 2

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

double[] InputArray(string message){
    System.Console.Write($"{message} > ");
    Console.WriteLine();
    double[] array = new double[3];
    int count = 3;

    for(int i = 0; i < count; i++) {
        System.Console.Write($"Значение {i+1} : ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

double Distance(double[] p1, double[] p2) {
    double scalar = 0;
    int count = 3;

    for(int i = 0; i < count; i++)
    {
        scalar = scalar + Math.Pow(p1[i] - p2[i], 2);
    }
    scalar = Math.Pow(scalar, 0.5);
    return scalar;
}

double[] dot1 = InputArray("Введите координаты первой точки: ");
double[] dot2 = InputArray("Введите координаты второй точки: ");

double distance = Distance(dot1, dot2);

System.Console.WriteLine($"Расстояние между точками равно {distance}");