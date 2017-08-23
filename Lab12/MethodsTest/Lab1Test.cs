using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Methods;

namespace MethodsTest
{
    [TestClass]
    public class Lab1Test
    {
        StringWriter writer;

        [TestInitialize] 
        public void SetUp()
        {
            //Выполняется перед каждым тестовым методом
            writer = new StringWriter();
        }

        [TestCleanup]
        public void Cleanup()
        {
            //Выполняется после каждого тестового метода
            writer.Close();
        }

        [TestMethod]
        public void Test1860case1()
        {
            //Подготовить контекст
            Console.SetOut(writer);
            //Выполнить действие
            Lab01.task1860("знаниям");
            String result = writer.GetStringBuilder().ToString();
            //Проверить результат
            Assert.AreEqual("Мы стремимся к знаниям", result);
        }

        [TestMethod]
        public void Test1860case2()
        {
            //Подготовить контекст
            Console.SetOut(writer);
            //Выполнить действие
            Lab01.task1860("цели");
            String result = writer.GetStringBuilder().ToString();
            //Проверить результат
            Assert.AreEqual("Мы стремимся к цели", result.Trim());
        }

        [TestMethod]
        public void Test1860case3()
        {
            //Подготовить контекст
            Console.SetOut(writer);
            //Выполнить действие
            Lab01.task1860("результату");
            String result = writer.GetStringBuilder().ToString();
            //Проверить результат
            Assert.AreEqual("Мы стремимся к результату", result.Trim());
        }
    }
}
