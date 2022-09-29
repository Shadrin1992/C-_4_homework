// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
string num1 = Convert.ToString(Console.ReadLine());

int[] arr = new int[num1.Length];
int i;
int result = 0;

for(i = 0; i < num1.Length; i++)
{
    arr[i] = Convert.ToInt32(num1[i].ToString());
}

for(i=0; i < num1.Length; i++)
{
    result = result + arr[i];
}
Console.WriteLine(result);