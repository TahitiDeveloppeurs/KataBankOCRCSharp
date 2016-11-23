using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodingDojoBankOCR
{
    /* _     _  _     _  _  _  _  _ 
     *| |  | _| _||_||_ |_   ||_||_|
     *|_|  ||_  _|  | _||_|  ||_| _|
     *                             
     * */


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Bank_000000000_should_return_000000000()
        {
            var line1 = " _  _  _  _  _  _  _  _  _ ";
            var line2 = "| || || || || || || || || |";
            var line3 = "|_||_||_||_||_||_||_||_||_|";

            var bankMachine = new BankMachine();
            var result = bankMachine.ComputeInput(line1, line2, line3);

            Assert.AreEqual("000000000", result);
        }

        [TestMethod]
        public void Bank_000000001_should_return_000000001()
        {
            var line1 = " _  _  _  _  _  _  _  _    ";
            var line2 = "| || || || || || || || |  |";
            var line3 = "|_||_||_||_||_||_||_||_|  |";

            var bankMachine = new BankMachine();
            var result = bankMachine.ComputeInput(line1, line2, line3);

            Assert.AreEqual("000000001", result);
        }

        [TestMethod]
        public void Bank_123456789_should_return_123456789()
        {
            var line1 = "    _  _     _  _  _  _  _ ";
            var line2 = "  | _| _||_||_ |_   ||_||_|";
            var line3 = "  ||_  _|  | _||_|  ||_| _|";

            var bankMachine = new BankMachine();
            var result = bankMachine.ComputeInput(line1, line2, line3);

            Assert.AreEqual("123456789", result);
        }

        [TestMethod]
        public void BankAccountNumber_check_validity()
        {
            var bankMachine = new BankMachine();

            Assert.IsFalse(bankMachine.IsValid("345882866"));
            Assert.IsTrue(bankMachine.IsValid("345882865"));
        }
    }
}
