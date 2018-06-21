using SocoShop.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Web;
using System.Web.SessionState;

namespace TestProject3
{
    
    
    /// <summary>
    ///这是 BasePageTest 的测试类，旨在
    ///包含所有 BasePageTest 单元测试
    ///</summary>
    [TestClass()]
    public class BasePageTest
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
        ///BasePage 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void BasePageConstructorTest()
        {
            BasePage target = new BasePage();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///CheckUserLogin 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckUserLoginTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            target.CheckUserLogin();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PageInit 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PageInitTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            HttpContext context = null; // TODO: 初始化为适当的值
            target.PageInit(context);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PageLoad 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PageLoadTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            target.PageLoad();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PostBack 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PostBackTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            target.PostBack();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///ProcessRequest 的测试
        ///</summary>
        [TestMethod()]
        public void ProcessRequestTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpContext context = null; // TODO: 初始化为适当的值
            target.ProcessRequest(context);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///ReadUserCookies 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void ReadUserCookiesTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            target.ReadUserCookies();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///ShowPage 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void ShowPageTest()
        {
            BasePage_Accessor target = new BasePage_Accessor(); // TODO: 初始化为适当的值
            target.ShowPage();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Context 的测试
        ///</summary>
        [TestMethod()]
        public void ContextTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpContext actual;
            actual = target.Context;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///IsReusable 的测试
        ///</summary>
        [TestMethod()]
        public void IsReusableTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            bool actual;
            actual = target.IsReusable;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///NeedUserCookies 的测试
        ///</summary>
        [TestMethod()]
        public void NeedUserCookiesTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            bool expected = false; // TODO: 初始化为适当的值
            target.NeedUserCookies = expected;
            Assert.Inconclusive("无法验证只写属性。");
        }

        /// <summary>
        ///Request 的测试
        ///</summary>
        [TestMethod()]
        public void RequestTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpRequest actual;
            actual = target.Request;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Response 的测试
        ///</summary>
        [TestMethod()]
        public void ResponseTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpResponse actual;
            actual = target.Response;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Server 的测试
        ///</summary>
        [TestMethod()]
        public void ServerTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpServerUtility actual;
            actual = target.Server;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///Session 的测试
        ///</summary>
        [TestMethod()]
        public void SessionTest()
        {
            BasePage target = new BasePage(); // TODO: 初始化为适当的值
            HttpSessionState actual;
            actual = target.Session;
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
