using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №4\nТема роботи: Оператор розгалуження if / else\n");
            Console.WriteLine("Варіант №32\nВирази:\n1) a-b+c+(a+x*t)\n2) a+b-(a+b+a)\n3) a*a+x/2+(b-c)\n");
            Console.WriteLine("Тип даних:\n--- згідно завдання ---\na, x - long\nb - double\nc - double\n\n--- задав самостійно ---\nt - long\n");

            Console.WriteLine("(!) Додаткова умова:\na, x, t – можуть бути тільки додатні\n");

            // введення змінної a з додатковою умовою
            Console.Write("Введіть значення змінної a: ");
            long a = long.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("Ви ввели додатнє число, все правильно");
            }
            else
            {
                Console.WriteLine("Ви ввели число " + a + ", воно не є додатнім.");
                a = Math.Abs(a);
                Console.WriteLine("Ми перетворили його на додатнє згідно умови: " + a);
            }

            // введення змінної b
            Console.Write("\nВведіть значення змінної b: ");
            double b = double.Parse(Console.ReadLine());

            // введення змінної c
            Console.Write("\nВведіть значення змінної c: ");
            double c = double.Parse(Console.ReadLine());

            // введення змінної x з додатковою умовою
            Console.Write("\nВведіть значення змінної x: ");
            long x = long.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Ви ввели додатнє число, все правильно");
            }
            else
            {
                Console.WriteLine("Ви ввели число " + x + ", воно не є додатнім.");
                x = Math.Abs(x);
                Console.WriteLine("Ми перетворили його на додатнє згідно умови: " + x);
            }

            // введення змінної t з додатковою умовою
            Console.Write("\nВведіть значення змінної t: ");
            long t = long.Parse(Console.ReadLine());
            if (t > 0)
            {
                Console.WriteLine("Ви ввели додатнє число, все правильно");
            }
            else
            {
                Console.WriteLine("Ви ввели число " + t + ", воно не є додатнім.");
                t = Math.Abs(t);
                Console.WriteLine("Ми перетворили його на додатнє згідно умови: " + t);
            }

            Console.WriteLine("\nВи ввели a = "+ a +", b = "+ b +", c = "+ c +", x = "+ x +", t = " + t +"\n");

            // беремо максимальни діпазон даних у нас це double
            double[] vsichysla = { a, x, b, c, t };

            double min = vsichysla.Min();
            double max = vsichysla.Max();

            Console.WriteLine("Мінімальне значення = " + min);
            Console.WriteLine("Максимальне значення = " + max);

            Console.WriteLine("\n------------ початок розрахунків --------------\n");

            double vyraz1 = a - b + c + (a + x * t);
            double vyraz2 = a + b - (a + b + a);
            double vyraz3 = a * a + x / 2 + (b - c);

            Console.WriteLine("Розрахунки виразів:");

            Console.WriteLine("1) a-b+c+(a+x*t) = " + vyraz1); // відповідь виразу 1
            Console.WriteLine("2) a+b-(a+b+a) = " + vyraz2); // відповідь виразу 2
            Console.WriteLine("3) a*a+x/2+(b-c) = " + vyraz3); // відповідь виразу 3

            Console.WriteLine("\nПеревірка входження розрахунку виразів у діпазон значень:");

            // головна частина завдання

            // порівняння виразу 1
            if (vyraz1 >= min && vyraz1 <= max) {
                Console.WriteLine("Відповідь виразу (1) = " + vyraz1 + " входить у діпазон, тому що " + vyraz1 + " >= " + min + " та " + vyraz1 + " <= " + max);
            }
            else if (vyraz1 > max)
            {
                Console.WriteLine("Відповідь виразу (1) = " + vyraz1 + " не входить у діпазон, тому що " + vyraz1 + " > " + max);
            } 
            else
            {
                Console.WriteLine("Відповідь виразу (1) = " + vyraz1 + " не входить у діпазон, тому що " + vyraz1 + " < " + min);
            }

            // порівняння виразу 2
            if (vyraz2 >= min && vyraz2 <= max)
            {
                Console.WriteLine("Відповідь виразу (2) = " + vyraz2 + " входить у діпазон, тому що " + vyraz2 + " >= " + min + " та " + vyraz2 + " <= " + max);
            }
            else if (vyraz2 > max)
            {
                Console.WriteLine("Відповідь виразу (2) = " + vyraz2 + " не входить у діпазон, тому що " + vyraz2 + " > " + max);
            }
            else
            {
                Console.WriteLine("Відповідь виразу (2) = " + vyraz2 + " не входить у діпазон, тому що " + vyraz2 + " < " + min);
            }

            // порівняння виразу 3
            if (vyraz3 >= min && vyraz3 <= max)
            {
                Console.WriteLine("Відповідь виразу (3) = " + vyraz3 + " входить у діпазон, тому що " + vyraz3 + " >= " + min + " та " + vyraz3 + " <= " + max);
            }
            else if (vyraz3 > max)
            {
                Console.WriteLine("Відповідь виразу (3) = " + vyraz3 + " не входить у діпазон, тому що " + vyraz3 + " > " + max);
            }
            else
            {
                Console.WriteLine("Відповідь виразу (3) = " + vyraz3 + " не входить у діпазон, тому що " + vyraz3 + " < " + min);
            }

            // кінець головної частини

            Console.WriteLine("\n------------ кінець розрахунків --------------\n");
            Console.WriteLine("Виконав студент БІП1-25\nФризько Денис");

        }
    }
}
