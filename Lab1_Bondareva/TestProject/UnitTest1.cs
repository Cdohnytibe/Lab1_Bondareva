using NUnit.Framework;
using Lab1_Bondareva;

namespace TestProject
{
    public class Tests
    {
[SetUp]
        public void Setup()
        {
        }

        [TestCase("3","0","5")]
        public void Test1(string A, string B, string C) //Тест на 0 значение
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("3", "366", "5")]
        public void Test2(string A, string B, string C) //Тест на неправильный треугольник
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("3", "4", "5")]
        public void Test3(string A, string B, string C) //Тест на тип треугольника - разносторонний №1
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Разносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("5", "4", "3")]
        public void Test4(string A, string B, string C) //Тест на тип треугольника - разносторонний №2
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Разносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("4", "4", "4")]
        public void Test5(string A, string B, string C) //Тест на тип треугольника - равносторонний
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("5", "4", "5")]
        public void Test6(string A, string B, string C) //Тест на тип треугольника - равнобедренный №1
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равнобедренный";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("4", "3", "3")]
        public void Test7(string A, string B, string C) //Тест на тип треугольника - равнобедренный №2
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равнобедренный";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("", "3", "3")]
        public void Test8(string A, string B, string C) //Тест на пустые значения
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("3", "", "")]
        public void Test9(string A, string B, string C) //Тест на пустые значения
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("", "", "")]
        public void Test10(string A, string B, string C) //Тест на пустые значения
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("0", "0", "5")]
        public void Test11(string A, string B, string C) //Тест на значение 0
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("0", "0", "0")]
        public void Test12(string A, string B, string C) //Тест на значение 0
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("1000000000000", "1000000000000", "1000000000000")]
        public void Test13(string A, string B, string C) //Тест на большие числа
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("-3", "4", "5")]
        public void Test14(string A, string B, string C) //Тест на минусовое значение
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("три", "4", "4")]
        public void Test15(string A, string B, string C) //Тест на буквы 
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("*4", "4", "4")]
        public void Test16(string A, string B, string C) //Тест на символы
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("3.4", "4.5", "5.1")]
        public void Test17(string A, string B, string C) //Тест на точку
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("8,7", "7,4", "9,5")]
        public void Test18(string A, string B, string C) //Тест на дробные числа
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Разносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("0,1", "0,3", "0,2")]
        public void Test19(string A, string B, string C)  //Тест на маленькие значения (меньше единицы)
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Разносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("0,9", "7839043,7", "0,4")]
        public void Test20(string A, string B, string C) //Тест на большие числа 
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("", "", "5")]
        public void Test21(string A, string B, string C) //Тест на пустые значения
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не введены значения сторон";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("5", "5", "5")]
        public void Test22(string A, string B, string C) //тест на округление до целых чисел
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равносторонний";
            //var expect = new[] { 0, 0, 5, 0, 2, 4 };
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("1000000000", "1000000000", "1000000000")]
        public void Test23(string A, string B, string C) //тест на масштабируемость координат вершин треугольника (не больше 100)
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Равносторонний";
            Assert.AreEqual(expect, x.Item1);
        }
        [TestCase("0,9", "0", "5")]
        public void Test24(string A, string B, string C) //Тест на значение 0
        {
            var x = Triangle.GoTriangle(A, B, C);
            var expect = "Не треугольник";
            Assert.AreEqual(expect, x.Item1);
        }
    }
}