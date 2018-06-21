using SocoShop.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject3
{
    
    
    /// <summary>
    ///这是 AjaxTest 的测试类，旨在
    ///包含所有 AjaxTest 单元测试
    ///</summary>
    [TestClass()]
    public class AjaxTest
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
        ///Ajax 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void AjaxConstructorTest()
        {
            Ajax target = new Ajax();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///AddFriend 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void AddFriendTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.AddFriend();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///AddGiftPack 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void AddGiftPackTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.AddGiftPack();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///AddGiftPackToCart 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void AddGiftPackToCartTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.AddGiftPackToCart();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///AddToCart 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void AddToCartTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.AddToCart();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckEmail 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckEmailTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.CheckEmail();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckUserCoupon 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckUserCouponTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.CheckUserCoupon();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///CheckUserName 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void CheckUserNameTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.CheckUserName();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Collect 的测试
        ///</summary>
        [TestMethod()]
        public void CollectTest()
        {
            Ajax target = new Ajax(); // TODO: 初始化为适当的值
            target.Collect();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///DeleteGiftPack 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void DeleteGiftPackTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.DeleteGiftPack();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PageLoad 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PageLoadTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.PageLoad();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///SelectShipping 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void SelectShippingTest()
        {
            Ajax_Accessor target = new Ajax_Accessor(); // TODO: 初始化为适当的值
            target.SelectShipping();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
