// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.WriteLine("Введите палиндром");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];

bool res = true;
for (int i = 0; i < num.Length / 2; i++)
{
    if(num[i] != num[num.Length - 1 - i])
    {
        res = false;
    }
}
Console.WriteLine (res);
