﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BorodulinMS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BorodulinMS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid ()
        {
            var name = "Матвей";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет..., Матвей", res);
        }
    }
}
