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



namespace _70_TriDuy_N1_Yody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //Chức năng đăng ký người dùng ( 6 TestCase ) 70_PhanDuy_N1_Yody

        private void btTestCase1_1_Click(object sender, EventArgs e) //TestCase1: Nhập thiếu họ và tên người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string sdt = "0983293706";
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.LinkText("ĐĂNG KÝ")).Click(); //chuyển sang trang đăng ký 
            Duy_70.FindElement(By.XPath("//*[@id=\"phone\"]")).SendKeys(sdt); // nhập thông tin sđt
            Duy_70.FindElement(By.Id("iptEmail")).SendKeys(email); // nhập thông tin email
            Duy_70.FindElement(By.Id("password")).SendKeys(pass); // nhập thông tin password
            Duy_70.FindElement(By.CssSelector("#btnSubmit")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký 
            //Duy_70.FindElement(By.CssSelector("button[type='submit']")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(5000); // cho chương trình dừng lại 5s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_2_Click(object sender, EventArgs e) //TestCase2: Nhập thiếu số điện thoại người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Duy";
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            //Duy_70.FindElement(By.LinkText("ĐĂNG KÝ")).Click(); //chuyển sang trang đăng ký
            Duy_70.FindElement(By.CssSelector("a[class ^='regis']")).Click(); //chuyển sang trang đăng ky, tìm tag, attribute với kí tự đầu của chuỗi
            Duy_70.FindElement(By.Name("first_name")).SendKeys(name); //nhập thông tin họ và tên 
            Duy_70.FindElement(By.CssSelector("[type='text'][placeholder='Địa chỉ email']")).SendKeys(email); //nhập thông tin email, sử dụng CssSelector kết hợp giữa thuộc tính type và placeholder
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.XPath("//*[@id=\"btnSubmit\"]")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(5000); // cho chương trình dừng lại 5s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_3_Click(object sender, EventArgs e) //TestCase3: Nhập thiếu email người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Duy";
            string sdt = "0983293706";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.CssSelector("a[class ^='regis']")).Click(); //chuyển sang trang đăng ky, tìm tag, attribute với kí tự đầu của chuỗi
            Duy_70.FindElement(By.Name("first_name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.Id("phone")).SendKeys(sdt); // nhập số điện thoại người dùng
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.XPath("//*[@id=\"btnSubmit\"]")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_4_Click(object sender, EventArgs e) //TestCase4: Nhập thiếu mật khẩu người dùng khi đăng ký thành viên
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Duy";
            string sdt = "0983293706";
            string email = "supertun819@hotmail.com";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.LinkText("ĐĂNG KÝ")).Click(); //chuyển sang trang đăng ký
            Duy_70.FindElement(By.Name("first_name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.XPath("//*[@id=\"phone\"]")).SendKeys(sdt); // nhập thông tin sđt
            Duy_70.FindElement(By.CssSelector("input#iptEmail")).SendKeys(email); //nhập email, sử dụng CssSelector Tag và ID 
            Duy_70.FindElement(By.CssSelector("button[class ^= 'btn-login'")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(5000); // cho chương trình dừng lại 5s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_5_Click(object sender, EventArgs e) //TestCase5: Mật khẩu không đủ độ dài kí tự 
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Duy";
            string sdt = "0983293706";
            string email = "supertun819@hotmail.com";
            string pass = "1234";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.PartialLinkText("ĐĂNG")).Click(); //chuyển sang trang đăng ký
            Duy_70.FindElement(By.Id("first_name")).SendKeys(name); // nhập họ và tên người dùng
            Duy_70.FindElement(By.CssSelector("[type='text'][placeholder='Số điện thoại']")).SendKeys(sdt); // nhập số điện thoại người dùng
            Duy_70.FindElement(By.Id("iptEmail")).SendKeys(email); // nhập thông tin email
            Duy_70.FindElement(By.CssSelector("input#password")).SendKeys(pass); //nhập mật khẩu, sử dụng CssSelector Tag và ID
            Duy_70.FindElement(By.XPath("//*[@id=\"btnSubmit\"]")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(5000); // cho chương trình dừng lại 5s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase1_6_Click(object sender, EventArgs e)
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string name = "Phan Duy";
            string sdt = "0983293706";
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div/div[2]/div[2]/div[3]/div[1]/div/a[1]")).Click(); //chuyển sang trang đăng ký
            Duy_70.FindElement(By.CssSelector("input[name=first_name]")).SendKeys(name); //nhập họ và tên, sử dụng CssSelector Tag, Attribute và Value
            Duy_70.FindElement(By.CssSelector("input[class *= 'form-control-comment']")).SendKeys(sdt); //nhập số điện thoại người dùng
            Duy_70.FindElement(By.Id("iptEmail")).SendKeys(email); // nhập thông tin email
            Duy_70.FindElement(By.Id("password")).SendKeys(pass); // nhập thông tin password
            Duy_70.FindElement(By.XPath("//*[@type ='submit' and @id = 'btnSubmit']")).Click(); // ấn button Đăng ký để hoàn thành việc đăng ký
            Thread.Sleep(5000); // cho chương trình dừng lại 5s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }



        //Chức năng đăng nhập người dùng ( 4 TestCase ) 70_PhanDuy_N1_Yody
        private void btTestCase2_1_Click(object sender, EventArgs e) // TestCase 1: Nhập sai tài khoản và mật khẩu
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string email = "superjoonior@gmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://yody.vn/");
            Duy_70.FindElement(By.LinkText("ĐĂNG NHẬP")).Click();
            Duy_70.FindElement(By.Id("customer_email")).SendKeys(email);
            Duy_70.FindElement(By.Id("customer_password")).SendKeys(pass);
            Duy_70.FindElement(By.XPath("//*[@id=\"customer_login\"]/button")).Click();
            //Duy_70.FindElement(By.LinkText("Log In")).Click(); // chuyển sang trang đăng nhập
            //Duy_70.FindElement(By.CssSelector("[type='email'][placeholder='name@email.com']")).SendKeys(email); //nhập thông tin email, sử dụng CssSelector kết hợp giữa thuộc tính type và placeholder
            //Duy_70.FindElement(By.Id("password")).SendKeys(pass); //nhập password
            //Duy_70.FindElement(By.XPath("//*[@type=\"submit\"]")).Click(); // ấn button Login để hoàn thành việc đăng nhập
            Thread.Sleep(10000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        private void btTestCase2_2_Click(object sender, EventArgs e) // TestCase 2: Nhập đúng tài khoản nhưng sai mật khẩu
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string email = "supertun819@hotmail.com";
            string pass = "123456789";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.PartialLinkText("Log")).Click(); // chuyển sang trang đăng nhập
            Duy_70.FindElement(By.Name("email")).SendKeys(email); // nhập email
            Duy_70.FindElement(By.Id("password")).SendKeys(pass); // nhập password
            Duy_70.FindElement(By.CssSelector("button[class ^= '_6dgzsvq']")).Click(); // ấn button Login để hoàn thành việc đăng nhập
            Thread.Sleep(3000); // cho chương trình dừng lại 3s 
            Duy_70.Quit(); //đóng hết các trình duyệt đang mở khi hoàn thành chương trình
        }

        
    }
}
