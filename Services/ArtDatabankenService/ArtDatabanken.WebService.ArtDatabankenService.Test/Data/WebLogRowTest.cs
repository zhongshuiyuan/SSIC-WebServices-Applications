﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArtDatabanken.WebService.ArtDatabankenService.Data;

namespace ArtDatabanken.WebService.ArtDatabankenService.Test.Data
{
    [TestClass]
    public class WebLogRowTest : TestBase
    {
        private WebLogRow _logRow;

        public WebLogRowTest()
        {
            ApplicationIdentifier = Settings.Default.WebAdminstrationApplicationIdentifier;
            _logRow = null;
        }

        #region Additional test attributes
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Constructor()
        {
            WebLogRow logRow;

            logRow = GetLogRow(true);
            Assert.IsNotNull(logRow);
        }

        private WebLogRow GetLogRow()
        {
            return GetLogRow(false);
        }

        private WebLogRow GetLogRow(Boolean refresh)
        {
            if (_logRow.IsNull() || refresh)
            {
                _logRow = LogManagerTest.GetOneLogRow(GetContext());
            }
            return _logRow;
        }
    }
}