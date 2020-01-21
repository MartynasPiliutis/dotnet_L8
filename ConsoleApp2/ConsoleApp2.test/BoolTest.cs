using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace ConsoleApp2.test
{
    [TestClass]
    public class BoolTest
    {
        [TestMethod]
        public void TikrinameArAtpazystaLyginiusSkaicius()
        {
            bool result = Program.PatikrintiArSkaiciusYraLyginis(2);
            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void TikrinameArAtpazystaNelyginiusSkaicius()
        {
            bool result = Program.PatikrintiArSkaiciusYraLyginis(3);
            Assert.AreEqual(result, false);
        }
    }
}
