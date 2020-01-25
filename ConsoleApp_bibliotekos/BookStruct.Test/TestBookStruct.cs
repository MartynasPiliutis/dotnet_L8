using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BookStruct;

namespace BookStruct.Test
{
    [TestClass]
    public class TestBookStruct
    {
        [TestMethod]
        public void BookLocalIdShouldBeName_Id()
        {
            //Assign
            Book knyga;
            knyga.Name = "name";
            knyga.Id = "1";
            //Act
            string locId = knyga.LocalID;
            //Assert
            Assert.AreEqual(locId, "name_1");
        }
    }
}
