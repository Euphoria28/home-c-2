//Задача 1
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не использовать строки

//14212 -> нет

//12821 -> да

//23432 -> да


Console.Write("Введите число:  ");
int value1 = Convert.ToInt32(Console.ReadLine());

int Ratepower(int Number)
{
    int i = 0;
    while (Number > 0) {
    i++;
    Number = Number / 10;
    }
    return i;
}

int power = Ratepower(value1);
bool palindrome = false;
double symmetry1 = value1 / Math.Pow(10, power-1);
double symmetry2 = value1 % 10;
if(Math.Truncate(symmetry1) == Math.Truncate(symmetry2))
{
    palindrome = true;
    for(int i = 1; i < power/2; i++)
    {
        symmetry1 = (value1 / Math.Pow(10, power-i-1)) % 10;
        symmetry2 = (value1 % Math.Pow(10, i+1)) / Math.Pow(10, i);
        if(Math.Truncate(symmetry1) == Math.Truncate(symmetry2)) palindrome = true;
        else palindrome = false;
    }
}

if(palindrome) Console.WriteLine($"Число является полиндромом");
else Console.WriteLine($"Число не является полиндромом");
