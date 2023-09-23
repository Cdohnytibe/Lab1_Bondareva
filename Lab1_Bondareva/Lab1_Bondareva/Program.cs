using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bondareva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для вычисления вида треугольника и координат его вершин");
            Console.WriteLine("Введите стороны треугольника"); 
            while (true)
            {
                Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("C:\\Users\\Ksenia\\Desktop\\file.txt")
                .CreateLogger(); // инициализация логгера

                Console.WriteLine("Введите длину стороны A");
                string A = Console.ReadLine();
                Console.WriteLine("Введите длину стороны B");
                string B = Console.ReadLine();
                Console.WriteLine("Введите длину стороны C");
                string C = Console.ReadLine();

                Console.WriteLine("Сторона A = {0}", A);
                Console.WriteLine("Сторона B = {0}", B);
                Console.WriteLine("Сторона C = {0}", C);

                string type;
                float[] a = new float[2]; // переменные для хранения координат
                float[] b = new float[2];
                float[] c = new float[2];

                (type, a, b, c) = Triangle.GoTriangle(A, B, C);

                Log.CloseAndFlush();
            }
        }
    }
}