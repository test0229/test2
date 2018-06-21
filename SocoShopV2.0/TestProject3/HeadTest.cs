﻿using SocoShop.Page.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject3
{
    
    
    /// <summary>
    ///这是 HeadTest 的测试类，旨在
    ///包含所有 HeadTest 单元测试
    ///</summary>
    [TestClass()]
    public class HeadTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
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

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Head 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void HeadConstructorTest()
        {
            Head target = new Head();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Author 的测试
        ///</summary>
        [TestMethod()]
        public void AuthorTest()
        {
            Head target = new Head(); // TODO: 初始化为适当的值
            string actual;
            actual = target.Author;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Copyright 的测试
        ///</summary>
        [TestMethod()]
        public void CopyrightTest()
        {
            Head target = new Head(); // TODO: 初始化为适当的值
            string actual;
            actual = target.Copyright;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Description 的测试
        ///</summary>
        [TestMethod()]
        public void DescriptionTest()
        {
            Head target = new Head(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Keywords 的测试
        ///</summary>
        [TestMethod()]
        public void KeywordsTest()
        {
            Head target = new Head(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Keywords = expected;
            actual = target.Keywords;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Title 的测试
        ///</summary>
        [TestMethod()]
        public void TitleTest()
        {
            Head target = new Head(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            target.Title = expected;
            actual = target.Title;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
