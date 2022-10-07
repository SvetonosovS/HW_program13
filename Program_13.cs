Console.Clear();

int num;
{
while (true)
    {
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out num))
        break;
    Console.WriteLine($"ошибка ввода");   
    }
 
Console.Write(num +" -> ");

while (num >= 999)
    {
    num = num / 10;
    }
if (num <= 99)
    {
      Console.WriteLine("Третьей цифры нет");   
    }  
if (num >=100)
    {
num = num % 10; 
Console.WriteLine(num);
    }
}