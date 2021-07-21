using NUnit.Framework;
using PointOfSale;

namespace PointOfSaleTerminalTest
{
    public class Tests
    {
        PointOfSaleTerminal terminal;

        [SetUp]
        public void Setup()
        {
            terminal = new PointOfSaleTerminal();
            terminal.SetPricing();
        }

        [Test]
        public void Test_ABCDABA_Should_Result_13_25()
        {
            terminal.SetPricing();
            terminal.ScanProduct('A');
            terminal.ScanProduct('B');
            terminal.ScanProduct('C');
            terminal.ScanProduct('D');
            terminal.ScanProduct('A');
            terminal.ScanProduct('B');
            terminal.ScanProduct('A');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 13.25);
        }

        [Test]
        public void Test_7C_Should_Result_6()
        {
            terminal.SetPricing();
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 6.00);
        }

        [Test]
        public void Test_ABCD_Should_Result_7_25()
        {
            terminal.SetPricing();
            terminal.ScanProduct('A');
            terminal.ScanProduct('B');
            terminal.ScanProduct('C');
            terminal.ScanProduct('D');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 7.25);
        }

        [Test]
        public void Test_13C_Should_Result_11()
        {
            terminal.SetPricing();
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            terminal.ScanProduct('C');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 11.00);
        }

        [Test]
        public void Test_14E_Should_Result_29_75()
        {
            terminal.SetPricing();
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            terminal.ScanProduct('E');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 29.75);
        }

        [Test]
        public void Test_Invalid_Code_Not_Added_To_Cart()
        {
            terminal.SetPricing();
            terminal.ScanProduct('R');
            var result = terminal.CalculateTotal();
            Assert.AreEqual(result, 0);
        }
    }
}
