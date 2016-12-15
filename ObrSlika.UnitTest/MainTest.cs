using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObrSlika;

namespace ObrSlika.UnitTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestLogin()
        {
            login log = new login();
            Boolean test = log.LoginUser("admin", "admin");
            Assert.IsTrue(test);
        }
        [TestMethod]
        public void TestLogin1()
        {
            login log = new login();
            Boolean test1 = log.LoginUser("admin", "kosarkar");
            Assert.IsFalse(test1);
        }

        [TestMethod]
        public void TestLogin3()
        {
            login log = new login();
            Boolean test2 = log.LoginUser("student", "admin");
            Assert.IsFalse(test2);
        }

    }
}
