using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Bondareva
{
    public static class Triangle
    {
        public static (string, float[], float[], float[]) GoTriangle(string A, string B, string C)
        {
            try
            {
                float a = float.Parse(A);
                float b = float.Parse(B);
                //Single a1 = -1;
                //Single.TryParse(A, out a1);
                //if(a1 != -1)
                //{

                //}
                float c = float.Parse(C);

                if (a <= 0 || b <= 0 || c <= 0)
                {
                    float[] xy1 = new float[] { -2, -2 };
                    float[] xy2 = new float[] { -2, -2 };
                    float[] xy3 = new float[] { -2, -2 };
                    string msg = $" ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                    Log.Information(msg);
                    return ("", xy1, xy2, xy3);
                }

                string type = "";
                if (a + b >= c && a + c >= b && b + c >= a)
                {

                    if (a == b && b == c && a == c) { type = "Равносторонний"; }
                    else if (a == b || b == c || c == a) { type = "Равнобедренный"; }
                    else { type = "Разносторонний"; }

                    float[] xy1 = new float[] { 0, 0 };
                    float[] xy2 = new float[] { c, 0 };

                    float cosA = (b * b + c * c - a * a) / (2 * b * c);
                    float sinA = (float)Math.Sqrt(1 - cosA * cosA);
                    float height = b * sinA;

                    float temp = (c * c - b * b + a * a) / (2 * a); // находим координаты третьей вершины
                    float[] xy3 = new float[] { temp, (float)Math.Sqrt(height * height - temp * temp) };

                    string msg = $"{type} ({xy1[0]}; {xy1[1]}), ({xy2[0]}; {xy2[1]}), ({xy3[0]}; {xy3[1]})";
                    Log.Information(msg);
                    return (type, xy1, xy2, xy3); // возвращаем значения, логируем
                }
                else
                {
                    float[] xy1 = new float[] { 0, 0 };
                    float[] xy2 = new float[] { 0, 0 };
                    float[] xy3 = new float[] { 0, 0 };

                    type = "Не треугольник";
                    string msg = $"{type}";
                    Log.Error(msg);
                    return ("Не треугольник", xy1, xy2, xy3);
                }
            }
            catch (Exception ex) // случай, при котором данные не могут быть корректно конвертированы
            {
                float[] xy1 = new float[] { -2, -2 };
                float[] xy2 = new float[] { -2, -2 };
                float[] xy3 = new float[] { -2, -2 };
                string msg = $" ";
                Log.Error(ex, msg);
                return ("", xy1, xy2, xy3);
            }
        }
    }
}
