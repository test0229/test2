using SocoShop.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SkyCES.EntLib;
using System.Web.UI.WebControls;
using SocoShop.Entity;
using System.Collections;

namespace TestProject3
{
    
    
    /// <summary>
    ///这是 AdminBasePageTest 的测试类，旨在
    ///包含所有 AdminBasePageTest 单元测试
    ///</summary>
    [TestClass()]
    public class AdminBasePageTest
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
        ///AdminBasePage 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void AdminBasePageConstructorTest()
        {
            AdminBasePage target = new AdminBasePage();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///Alert 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void AlertTest()
        {
            string alertMessage = string.Empty; // TODO: 初始化为适当的值
            string url = string.Empty; // TODO: 初始化为适当的值
            AdminBasePage_Accessor.Alert(alertMessage, url);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///BindControl 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void BindControlTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            CommonPager commonPager = null; // TODO: 初始化为适当的值
            target.BindControl(commonPager);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///BindControl 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void BindControlTest1()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            object dataSource = null; // TODO: 初始化为适当的值
            Repeater repeater = null; // TODO: 初始化为适当的值
            CommonPager commonPager = null; // TODO: 初始化为适当的值
            target.BindControl(dataSource, repeater, commonPager);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///BindControl 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void BindControlTest2()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            object dataSource = null; // TODO: 初始化为适当的值
            Repeater repeater = null; // TODO: 初始化为适当的值
            target.BindControl(dataSource, repeater);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckAdminLogin 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckAdminLoginTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            target.CheckAdminLogin();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckAdminPower 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckAdminPowerTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            string powerString = string.Empty; // TODO: 初始化为适当的值
            PowerCheckType powerCheckType = new PowerCheckType(); // TODO: 初始化为适当的值
            target.CheckAdminPower(powerString, powerCheckType);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckAdminPower 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckAdminPowerTest1()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            string powerKey = string.Empty; // TODO: 初始化为适当的值
            string powerString = string.Empty; // TODO: 初始化为适当的值
            PowerCheckType powerCheckType = new PowerCheckType(); // TODO: 初始化为适当的值
            int adminID = 0; // TODO: 初始化为适当的值
            int adminIDExpected = 0; // TODO: 初始化为适当的值
            target.CheckAdminPower(powerKey, powerString, powerCheckType, ref adminID);
            Assert.AreEqual(adminIDExpected, adminID);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///ClearCache 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void ClearCacheTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            target.ClearCache();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///GetAddUpdate 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void GetAddUpdateTest()
        {
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = AdminBasePage_Accessor.GetAddUpdate();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///OnInit 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void OnInitTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            EventArgs e = null; // TODO: 初始化为适当的值
            target.OnInit(e);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///ReadAllNeedOther 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void ReadAllNeedOtherTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            Hashtable expected = null; // TODO: 初始化为适当的值
            Hashtable actual;
            actual = target.ReadAllNeedOther();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///CurrentPage 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CurrentPageTest()
        {
            AdminBasePage_Accessor target = new AdminBasePage_Accessor(); // TODO: 初始化为适当的值
            int actual;
            actual = target.CurrentPage;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
