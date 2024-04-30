using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TestTimKiem;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestTimKiem
{
    [TestClass] //test tìm kiếm 70_TriDuy_N1_Yody
    public class UnitTestTimKiem
    {
        public TestContext TestContext { get; set; }
        

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\DataTimKiem\TestDataTimKiem.csv", "TestDataTimKiem#csv", DataAccessMethod.Sequential)]

        public void TestTimKiem()
        {
            // lưu dữ liệu vào biến từ file csv
            var sp = TestContext.DataRow[0].ToString();
            //ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            //chrome.HideCommandPromptWindow = true; //đóng cửa sổ Terminal
            IWebDriver Duy_70 = new ChromeDriver();
            Duy_70.Navigate().GoToUrl("https://yody.vn/"); //đi tới trang chủ
            Duy_70.FindElement(By.CssSelector("[type='text'][placeholder='Tìm kiếm']")).SendKeys(sp); // nhập thông tin sản phẩm mong muốn
            Duy_70.FindElement(By.CssSelector("button[class *= 'icon-fallback-text']")).Click(); //bấm nút Tìm kiếm
            Thread.Sleep(10000); //cho chương trình dừng lại 10s 
            int dem = Duy_70.FindElements(By.XPath("/html/body/section[2]/div/div/div/div[2]/p[1]")).Count;
            Assert.AreNotEqual(1, dem, "Không có sản phẩm phù hợp");
            
        }
    }
}
