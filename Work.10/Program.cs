Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n1 = number / 100;
int n2= number / 10;
int n3 = number % 10;
Console.WriteLine (n2 % 10);