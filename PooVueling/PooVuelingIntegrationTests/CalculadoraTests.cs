using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora calculator = new Calculadora();
        [TestMethod()]
        public void CloneTest()
        {
            Assert.Fail();
        }

        //[DataRow(2,2,1)]
        //[DataRow(4, 2, 2)]
        [DataRow(2, 0, 1)]
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException), "You can't divide for 0")]
        public void DivisionTest(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Division(a, b), result);
        }

        [DataRow(2, 3, 6)]
        [TestMethod()]
        public void MultiplicacionTest(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Multiplicacion(a, b), result);
        }

        [DataRow(20, 2, 18)]
        [TestMethod()]
        public void RestaTest(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Resta(a, b), result);
        }

        [DataRow(2, 2, 4)]
        [DataRow(4, 2, 6)]
        [DataRow(6, 2, 8)]
        [DataRow(8, 8, 16)]
        [TestMethod()]
        public void SumaTest(int a, int b, int result)
        {
            Assert.AreEqual(calculator.Suma(a, b), result);
        }
    }
}