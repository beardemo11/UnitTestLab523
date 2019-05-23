using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace UnitTestLab1.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void ValidateMemberTest驗證admin帳號密碼正確()
        {
            FakeDataBase fakeDataBase = new FakeDataBase();
            //dt.Columns.Add("Account");
            //dt.Columns.Add("Password");
            //var newrow= dt.NewRow();
            //newrow["Account"] = "admin";
            //newrow["Password"] = "admin123";
            //dt.Rows.Add(newrow);


            Service service = new Service(fakeDataBase);
            string actual = "";
            string result = "Success!";
            actual = service.ValidateMember("admin", "admin123");
            Assert.AreEqual( result, actual);
        }

        [TestMethod()]
        public void ValidateMemberTest驗證admin帳號不存在()
        {
            NoneDataBase noneDataBase = new NoneDataBase();

            Service service = new Service(noneDataBase);
            string actual = "";
            string result = "No Account!";
            actual = service.ValidateMember("admin", "admin123");
            Assert.AreEqual(result, actual);
        }

        [TestMethod()]
        public void ValidateMemberTest驗證admin帳號密碼錯誤()
        {
            FakeDataBase fakeDataBase = new FakeDataBase();


            Service service = new Service(fakeDataBase);
            string actual = "";
            string result = "Password Error!";
            actual = service.ValidateMember("admin", "admin789");
            Assert.AreEqual(result, actual);
        }

    }
}