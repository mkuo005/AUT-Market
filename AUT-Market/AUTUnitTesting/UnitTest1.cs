﻿using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using AUT_Market.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AUTUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        SellProductValidation valid = new SellProductValidation();

        int IsValidInput;

        string title = "SDP Book";
        string author = "AUT Market Team";
        string edition = "4";
        string courseCode = "COMP602";
        string price = "99999.00";
        string desc = "This book is very rare in the world";

        [TestMethod]
        public void TestMethod1()
        {
            this.PressButton();
        }

        private void PressButton()
        {
            IsValidInput = valid.CheckValidInput(title, author, edition, courseCode, price, desc);

            Assert.AreEqual(IsValidInput, -1);

        }



    }
}
