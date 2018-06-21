using SocoShop.Page;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject3
{
    
    
    /// <summary>
    ///这是 ProductCommentAjaxTest 的测试类，旨在
    ///包含所有 ProductCommentAjaxTest 单元测试
    ///</summary>
    [TestClass()]
    public class ProductCommentAjaxTest
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
        ///ProductCommentAjax 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void ProductCommentAjaxConstructorTest()
        {
            ProductCommentAjax target = new ProductCommentAjax();
            Assert.Inconclusive("TODO: 实现用来验证目标的代码");
        }

        /// <summary>
        ///AddProductComment 的测试
        ///</summary>
        [TestMethod()]
        public void AddProductCommentTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            string result = string.Empty; // TODO: 初始化为适当的值
            string resultExpected = string.Empty; // TODO: 初始化为适当的值
            target.AddProductComment(ref result);
            Assert.AreEqual(resultExpected, result);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///AddTags 的测试
        ///</summary>
        [TestMethod()]
        public void AddTagsTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            string result = string.Empty; // TODO: 初始化为适当的值
            string resultExpected = string.Empty; // TODO: 初始化为适当的值
            target.AddTags(ref result);
            Assert.AreEqual(resultExpected, result);
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///AgainstComment 的测试
        ///</summary>
        [TestMethod()]
        public void AgainstCommentTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            target.AgainstComment();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PageLoad 的测试
        ///</summary>
        [TestMethod()]
        [DeploymentItem("SocoShop.Page.dll")]
        public void PageLoadTest()
        {
            ProductCommentAjax_Accessor target = new ProductCommentAjax_Accessor(); // TODO: 初始化为适当的值
            target.PageLoad();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PostProductComment 的测试
        ///</summary>
        [TestMethod()]
        public void PostProductCommentTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            target.PostProductComment();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///PostTags 的测试
        ///</summary>
        [TestMethod()]
        public void PostTagsTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            target.PostTags();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///SupportComment 的测试
        ///</summary>
        [TestMethod()]
        public void SupportCommentTest()
        {
            ProductCommentAjax target = new ProductCommentAjax(); // TODO: 初始化为适当的值
            target.SupportComment();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }
    }
}
