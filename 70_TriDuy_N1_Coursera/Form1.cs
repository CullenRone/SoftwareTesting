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


        private void btTestCase1_1_Click(object sender, EventArgs e)
        {
            IWebDriver Duy_70 = new ChromeDriver();
            string email = "supertun819@hotmail.com";
            string pass = "123456@hihi";
            Duy_70.Navigate().GoToUrl("https://www.coursera.org/");
            Duy_70.FindElement(By.LinkText("Join for Free")).Click();
            Duy_70.FindElement(By.Id("email")).SendKeys(email);
            Duy_70.FindElement(By.Id("password")).SendKeys(pass);
            Duy_70.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(3000);
            //ChromeDriverService D70 = ChromeDriverService.CreateDefaultService();
            //D70.HideCommandPromptWindow = true;
            Duy_70.Quit();
        }
    }
}
