using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace _70_TriDuy_N1_Coursera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btTestCase1_1_Click(object sender, EventArgs e) //TestCase1: Nhập thiếu họ và tên người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            //Duy_70.FindElement(By.LinkText("Join for Free")).Click();
            Duy_70.FindElement(By.CssSelector("#rendered-content > div > header > div > div > div.cds-1.css-1cxrrkn.cds-2.cds-7 > div > div > div > div.context-header__child.context-header__child--right.css-1ha689c > ul > li.c-ph-right-nav-button.c-ph-sign-up.cta-color-exp.not-enterprise-cta.isLohpRebrand.frontpage.c-ph-right-nav-no-border > a")).Click();
            //Duy_70.FindElement(By.CssSelector("#rendered-content > div > main > section.rc-HeroBannerRedesign.css-rpf906 > div > div.css-je23cs > button > span")).Click(); // chuyển sang trang đăng ký
            //Duy_70.FindElement(By.Id("email")).SendKeys(email);
            Duy_70.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys(email); // nhập thông tin email
            Duy_70.FindElement(By.Id("password")).SendKeys(pass); // nhập thông tin password
            Duy_70.FindElement(By.CssSelector("button[type='submit']")).Click(); // ấn button Join for Free để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_2_Click(object sender, EventArgs e) //TestCase2: Nhập thiếu email người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Tri Duy";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.LinkText("Join for Free")).Click(); // chuyển sang trang đăng ký
            //Duy_70.FindElement(By.CssSelector("button[class^='cds-149']")).Click(); //chuyển sang trang đăng ky, tìm tag, attribute với kí tự đầu của chuỗi
            //Duy_70.FindElement(By.Id("name")).SendKeys(name);
            Duy_70.FindElement(By.CssSelector("[type='text'][placeholder='Enter your full name']")).SendKeys(name); //nhập thông tin họ và tên, sử dụng CssSelector kết hợp giữa thuộc tính type và placeholder
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.CssSelector("button[type='submit']")).Click(); // ấn button Join for Free để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_3_Click(object sender, EventArgs e) //TestCase3: Nhập thiếu mật khẩu người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Tri Duy";
            string email = "supertun819@hotmail.com";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.CssSelector("a[class ^= 'standard']")).Click(); //chuyển sang trang đăng ký, tìm tag, attribute với kí tự đầu của chuỗi
            Duy_70.FindElement(By.Name("name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys(email); // nhập email người dùng
            Duy_70.FindElement(By.CssSelector("button[class ^= '_6dgzsvq'")).Click(); // ấn button Join for Free để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_4_Click(object sender, EventArgs e) //TestCase4: Nhập mật khẩu thiếu độ dài quy định
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Tri Duy";
            string email = "supertun819@hotmail.com";
            string pass = "123456";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.CssSelector("a[class $= 'primary']")).Click(); //chuyển sang trang đăng ký, tìm tag, attribute với kí tự cuối của chuỗi
            Duy_70.FindElement(By.Id("name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys(email); // nhập email người dùng
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.CssSelector("button[class ^= '_6dgzsvq'")).Click(); // ấn button Join for Free để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_5_Click(object sender, EventArgs e) //TestCase5: Nhập đúng và đầy đủ các thông tin cần thiết
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Tri Duy";
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.CssSelector("a[class *= 'primary']")).Click(); //chuyển sang trang đăng ký, tìm tag, attribute có chứa kí tự bất kì của chuỗi
            Duy_70.FindElement(By.Id("name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.XPath("//*[@id=\"email\"]")).SendKeys(email); // nhập email người dùng
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.XPath("//*[@type=\"submit\"]")).Click(); // ấn button Join for Free để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }
    }
}
