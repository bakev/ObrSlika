using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObrSlika;

namespace ObrSlika.UnitTest
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void TestSoVnesenKorisnik()
        {
            login log = new login();
            Boolean test = log.LoginUser("admin", "admin");
            Assert.IsTrue(test);
        }
      
        [TestMethod]
        public void TestSoGresenPass()
        {
            login log = new login();
            Boolean test1 = log.LoginUser("admin", "kosarkar");
            Assert.IsFalse(test1);
        }

        [TestMethod]
        public void TestSoGresenUserName()
        {
            login log = new login();
            Boolean test2 = log.LoginUser("student", "admin");
            Assert.IsFalse(test2);
        }
        [TestMethod]
        public void TestSoPrazniVrednosti()
        {
            login log = new login();
            Boolean test3 = log.LoginUser("", "");
            Assert.IsFalse(test3);
        }

        [TestMethod]
        public void TestSoDolgiVrednosti()
        {
            login log = new login();
            Boolean test4 = log.LoginUser("Testot so dolgi vrednosti", "Testot so dolgi vrednosti");
            Assert.IsFalse(test4);
        }
        [TestMethod]
        public void TestSoprazenPass()
        {
            login log = new login();
            Boolean test5 = log.LoginUser("Testot so dolgi vrednosti","");
            Assert.IsFalse(test5);
        }


    }
}
