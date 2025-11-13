using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        //int a = 10;
    //Console.WriteLine(a);

    //char a = '2';
    //var str = "nhjkjhkjh";
    //var a1 = '2';

    //var b  = 2;
    //Guid guid = new Guid("1BE8A5E8-FD06-4D4C-8C6A-15C8FD53ED25");
    //Guid guid1 = new Guid("1bE8A5E8-FD06-4D4C-8C6A-15C8FD53ED25");


    //Console.WriteLine(guid == guid1);
    //Console.WriteLine(b.GetType().ToString());
    //Console.WriteLine(b.GetType().Name);

    //double b = 0.2 - 0.1;

    //Console.WriteLine((a-b)< 1e-9);
    //Console.WriteLine(0.3 - 0.2);


    //Console.WriteLine('\u0420' == 'Р'); // Р

    //Console.WriteLine("hello");
    //Console.WriteLine("Компания \"Рога и копыта\"");
    //Console.WriteLine("Привет \nмир");

    //Console.WriteLine("hello: " + (2 + 2));
    //Console.WriteLine("Число: {1}, Число: {0}", 10, 20);
    //Console.WriteLine($"Число: {a}");

    //int number = 23;
    //int text = Console.ReadLine();
    //int number2 = Convert.ToInt32(Console.ReadLine());

    //Console.WriteLine(number2);

    //double z = 10 / 4; //результат равен 2
    //double z1 = 10.0 / 4.0; //результат равен 2.5

    //byte a = 4;
    //byte a1 =70;
    ////byte b = a + a1; // ошибка
    ////byte a = 4;
    //int b1 = (a + 70);
    //bool b = byte.TryParse("12321", );
    //byte a = 4;
    //int b = a + 70; // 74
    //byte a = 4;


    //try{
    //    int a = 33;
    //    int b = 600;
    //    byte c = (byte)(a + b);
    //    Console.WriteLine(c);
    //}
    //catch (OverflowException ex)
    //{
    //     Console.WriteLine(ex.Message);
    //}
    byte a = 3;
    byte b = 2;
    //Console.WriteLine($" {a} = {Convert.ToString(a, 2)}; {b} = {Convert.ToString(b, 2)}; ");
    //Console.WriteLine($"1 Пример {a} & {b} = {a & b} ");
    //Console.WriteLine($"1 Пример {a} ^ {b} = {a ^ b} ");
    //Console.WriteLine($"1 Пример {a} | {b} = {a | b} ");


    bool isTrue = true;
    bool isFalse = false;

    //Console.WriteLine(isTrue && isTrue && isFalse);
    //Console.WriteLine(isFalse || isFalse|| isFalse|| isTrue || isFalse);


    //if (isTrue)
    //{
    //    Console.WriteLine(true);
    //}

    //if (isTrue)
    //    Console.WriteLine(true);



    //if (isTrue)
    //{
    //    Console.WriteLine(true);
    //}

    //else if (isFalse)
    //{
    //    Console.WriteLine(false);
    //}
    //else 
    //{
    //    Console.WriteLine("yayy");
    //}


    //Console.WriteLine("Нажмите Y или N");
    //string selection = Console.ReadLine();
    //switch (selection)
    //{
    //    case "Y":
    //        Console.WriteLine("Вы нажали букву Y");
    //        break;
    //    case "N":
    //        Console.WriteLine("Вы нажали букву N");
    //        break;
    //    default:
    //        Console.WriteLine("Вы нажали неизвестную букву");
    //        break;
    //}

    //int selection = Convert.ToInt32(Console.ReadLine());
    //byte b5 = (byte)(a + 70);
    //switch (selection)
    //{
    //    case >= 90:
    //        Console.WriteLine("A");
    //        break;
    //    case >= 80:
    //        Console.WriteLine("B");
    //        break;
    //    case >= 70:
    //        Console.WriteLine("C");
    //        break;
    //    default:
    //        break;
    //}

    //string result = selection switch
    //{
    //    >= 80+10 => "A",
    //    >= 80 => "B",
    //    >= 70 => "C",
    //    _ => "F"
    //};
    //Console.WriteLine("switch => " + result);
        int x = 10;
        GetMessage(y: 5, x: 10);
    }

    static void GetMessage(int x, int y) 
    {
        Console.WriteLine($"x:{x}, y:{y}");
        //int x = 3;
        //int y = 2;
        Console.WriteLine("Нажмите + или -");
        //string selection = Console.ReadLine();
        //int z;
        //if (selection == "+")
        //{
        //    z = x + y;
        //}
        //else
        //{
        //    z = x - y;
        //}
        //z = (selection == "+" ? (x + y): (x - y);
       //Console.WriteLine(selection == "+" ? $" + {x + y}" : $" - {x - y}");
    }
}
