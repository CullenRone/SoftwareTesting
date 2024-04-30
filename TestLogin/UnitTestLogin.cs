using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TestLogin;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace TestLogin
{
    [TestClass] //test đăng nhập 70_TriDuy_N1_Yody
    public class UnitTestLogin
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\DataLogin\TestDataLogin.csv", "TestDataLogin#csv", DataAccessMethod.Sequential)]

        public void TestDangNhap()
        {
            // lưu dữ liệu vào biến từ file csv
            var email = TestContext.DataRow[0].ToString();
            var pass = TestContext.DataRow[1].ToString();
            //ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            //chrome.HideCommandPromptWindow = true; //đóng cửa sổ Terminal
            IWebDriver Duy_70 = new ChromeDriver();
            Duy_70.Navigate().GoToUrl("https://yody.vn/account/login"); //đi tới trang đăng nhập
            Duy_70.FindElement(By.Id("customer_email")).SendKeys(email); //nhập thông tin email
            Duy_70.FindElement(By.Name("password")).SendKeys(pass); //nhập thông tin mật khẩu
            Duy_70.FindElement(By.XPath("//*[@id=\"customer_login\"]/button")).Click(); //bấm nút Đăng nhập
            Thread.Sleep(5000); //cho chương trình dừng lại 5s để lấy đúng Url
            string url = Duy_70.Url;
            Assert.AreEqual("https://yody.vn/account", url, "Đăng nhập thất bại"); // so sánh nếu URL của trang hiện tại giống với trang đăng nhập thành công tức là pass
        }
    }
}
