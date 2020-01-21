using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1.test
{
    [TestClass]
    public class StringTest
    {
        [TestMethod]
        public void PatikrinameArProgramaTeisingaiGrazinaApverstaSkaiciuStringa()
        {
            string result = Program.ApverciaStringa("qwertyQWERTY1234567890!@#$%^&*()_+|{}");
            Assert.AreEqual(result, "}{|+_)(*&^%$#@!0987654321YTREWQytrewq");
        }

        [TestMethod]
        public void PatikrinameArProgramaTeisingaiGrazinaStringaIsVienoSimbolio()
        {
            string result = Program.ApverciaStringa("A");
            Assert.AreEqual(result, "A");
        }

        [TestMethod]
        public void PatikrinameArProgramaTeisingaiGrazinaTusciaStringa()
        {
            string result = Program.ApverciaStringa("");
            Assert.AreEqual(result, "");
        }
    }
}
