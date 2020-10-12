using CalculatorLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Clalcuatortesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethodWithTwoPostiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();

            string a = "+";
            double x = 1.0;
            double y = 1.0;
            double awnser = x + y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestAddMethodWithTwoNegtiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "+";
            double x = -1.0;
            double y = -3.0;
            double awnser = x + y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestAddMethodWithonePostiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "+";
            double x = -1.0;
            double y = 2.0;
            double awnser = x + y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestSubtractMethodWithTwoPostiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "-";
            double x = 1.0;
            double y = 1.0;
            double awnser = x - y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestSubtractMethodWithTwoNegtiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "-";
            double x = -1.0;
            double y = -3.0;
            double awnser = x - y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestSubtractMethodWithonePostiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "-";
            double x = -1.0;
            double y = 2.0;
            double awnser = x - y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }

        [TestMethod]
        public void TestMultiplyeMethodWithTwoPostiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "*";
            double x = 1.0;
            double y = 3.0;
            double awnser = x * y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestMultiplyeMethodWithTwoNegativeNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "*";
            double x = -1.0;
            double y = -3.0;
            double awnser = x * y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestDivideMethodWithTwoPostivetiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "/";
            double x = 1.0;
            double y = 3.0;
            double awnser = x / y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestDivideMethodWithTwoNegtivetiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "/";
            double x = -4.0;
            double y = -2.0;
            double awnser = x / y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
        [TestMethod]
        public void TestDivideMethodWithoneNegtivetiveNumber()
        {
            CalculatorLibrary1.Calculator cal = new CalculatorLibrary1.Calculator();
            string a = "/";
            double x = -4.0;
            double y = 2.0;
            double awnser = x / y;
            double actual = cal.DoOperation(x, y, a);
            Assert.AreEqual(awnser, actual);

        }
    }
}
