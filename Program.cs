//1.Операция логического умножения: 
Console.WriteLine("Операция логического умножения");
Console.Write("Введите первое число: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(x1 & y1);
//2.Операция логического сложения
Console.WriteLine("Операция логического сложения");
Console.Write("Введите первое число: ");
int a1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine(a1 | b1);
//3.Операция логического исключения
Console.WriteLine("Операция логического исключения");
Console.Write("Введите число: ");
int z = int.Parse(Console.ReadLine()!);
Console.Write("Введите ключ: ");
int key = int.Parse(Console.ReadLine()!);
Console.WriteLine(z ^ key);