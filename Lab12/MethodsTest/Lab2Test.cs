using Methods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsTest
{
    [TestClass]
    public class Lab2Test
    {
        //Позволяет прятать, но не исключать большие фрагменты кода
        #region task9298
        [TestMethod]
        public void Test9298case1()
        {
            double area = Lab02.task9298(1);
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void Test9298case2()
        {
            double area = Lab02.task9298(5);
            Assert.AreEqual(150, area);
        }

        [TestMethod]
        //В том методе правильнее выбрасывать именно ArgumentException, а не просто Exception
        //Тут нужно будет заменить
        [ExpectedException(typeof(ArgumentException),
            "Для неположительной боковой поверхности вычислился результат")]
        public void Test9298case3()
        {
            double area = Lab02.task9298(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Для неположительной боковой поверхности вычислился результат")]
        public void Test9298case4()
        {
            double area = Lab02.task9298(-2);
        }

        [TestMethod]
        //[ExpectedException(typeof(ArgumentException),
        //    "Для неположительной боковой поверхности вычислился результат")]
        public void Test9298case5()
        {
            //На самом деле исключения быть не должно.
            //просто иллюстрация того, как студия реагирует когда исключение ждали, а его нет
            double area = Lab02.task9298(6);
        }
        #endregion

        #region task8428
        static double PRECISION = 0.0001;

        [TestMethod]
        public void Test8428case1()
        {
            //Когда нужна определенная точность вычислений
            Assert.AreEqual(0.7854, Lab02.task8428(45), PRECISION);
        }

        [TestMethod]
        public void Test8428case2()
        {
            Assert.AreEqual(19.6350, Lab02.task8428(1125), PRECISION);
        }

        [TestMethod]
        public void Test8228case3()
        {
            Assert.AreEqual(0, Lab02.task8428(0), PRECISION);
        }

        [TestMethod]
        public void Test8428case4()
        {
            Assert.AreEqual(6.2832, Lab02.task8428(360), PRECISION);
        }

        [TestMethod]
        public void Test8428case5()
        {
            Assert.AreEqual(1.5708, Lab02.task8428(90), PRECISION);
        }

        [TestMethod]
        public void Test8428case6()
        {
            Assert.AreEqual(34.9066, Lab02.task8428(2000), PRECISION);
        }
        #endregion
    }
}
