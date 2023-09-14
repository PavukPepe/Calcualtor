using System.Net.WebSockets;

do
{
    Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы");

    string txt = Console.ReadLine();
    if (txt == "2" ||  txt == "1" || txt == "3" || txt == "4")
    {
        Console.WriteLine("Введите первое число: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        if (txt == "1")
        {
            Console.WriteLine(n1 + n2);
        }
        if (txt == "2")
        {
            Console.WriteLine(n2 - n1);
        }
        if (txt == "3")
        {
            Console.WriteLine(n1 * n2);
        }
        if (txt == "4")
        {
            Console.WriteLine(n1 / n2);
        }
        Console.WriteLine("Введите следующее действие: ");
    }
    if (txt == "5")
    {
        Console.WriteLine("Введите первое число: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите степень: ");
        double n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(n1, n2));
    }

    if (txt == "6")
    {
        Console.WriteLine("Введите число: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(n1));
    }

    if (txt == "7")
    {
        Console.WriteLine("Введите число: ");
        double n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(n1 / 100);
    }

    if (txt == "8")
    {
        Console.WriteLine("Введите число: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = 1;
        for (int i = 1; i <= n1; i++)
        {
            n2 *= i;
        }
        Console.WriteLine(n2);

    }

    if (txt == "9")
        break;
    else
        Console.WriteLine("Выберите следующую операцию");

} while (true);