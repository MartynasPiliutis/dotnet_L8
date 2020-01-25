using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PirkinysStruct.Test
{
    [TestClass]
    public class TestVisaKaina
    {
        [TestMethod]
        public void TikrinameArTeisingaiSkaiciuojaVisaKaina()
        {
            //Assign
            Pirkinys daiktas = new Pirkinys();
            daiktas.PrekesPavadinimas = "vardas";
            daiktas.PrekesKaina = 15;
            daiktas.PrekesKiekis = 3;
            //Act
            double VisaKaina = daiktas.KainaViso;
            //Assert
            Assert.AreEqual(VisaKaina, 45 );
        }
    }
}
