//Задача 3

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125


int Prompt(string message){
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int Number = Prompt("Введите число N");
double kub = 0;

for(int i = 0; i < Number; i++){

    kub = Math.Pow((i+1), 3);
    System.Console.WriteLine($"{kub}");
}