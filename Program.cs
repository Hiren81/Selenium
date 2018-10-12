using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    class Program
    {
        //Create the webdriver reference
        //Global variable so we can access
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            
        }
        [SetUp]

        public void Initialize()
        {
            //Navigate to site

            driver.Navigate().GoToUrl("https://demo.guru99.com/v4/");
            Console.WriteLine("Sucessfully navigated to site");
            driver.Manage().Window.Maximize();
        }
        [Test]

        public void CreateNewAccount()
        {
            //username
            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            //mngr156510

            //Password
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");
            //nydEmup
            //submit
            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //click on new customer
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[2]/a")).Click();
            //Add nw customer details
            driver.FindElement(By.XPath("//input[@name='name']")).SendKeys("Hiren");
            driver.FindElement(By.Name("rad1")).Click();
            driver.FindElement(By.XPath("//input[@id='dob']")).SendKeys("18/11/1981");
            driver.FindElement(By.XPath("//textarea[@name='addr']")).SendKeys("Test");
            driver.FindElement(By.XPath("//input[@name='city']")).SendKeys("Test");
            driver.FindElement(By.XPath("//input[@name='state']")).SendKeys("Sussex");
            driver.FindElement(By.XPath("//input[@name='pinno']")).SendKeys("454558");
            driver.FindElement(By.XPath("//input[@name='telephoneno']")).SendKeys("544454541");
            driver.FindElement(By.XPath("//input[@name='emailid']")).SendKeys("hirenmoghe@gmail.com");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("hiren123");
            driver.FindElement(By.XPath("//input[@name='sub']")).Click();

        }
        [Test]

        public void AddNewAccountForm()
        {
            //username
            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            //mngr156510

            //Password
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");
            //nydEmup
            //submit
            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //Click on new account and follow operations
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[5]/a")).Click();




            driver.FindElement(By.Name("cusid")).SendKeys("1825");

            //Noz select multiple dropdown

            //Method 1 for dropdown
            //IWebElement element = driver.FindElement(By.Name("selaccount"));
            //SelectElement S1 = new SelectElement(element);
            //S1.SelectByIndex(1);

            //OR
            //Method 2 for dropdown
            SelectElement s1 = new SelectElement(driver.FindElement(By.Name("selaccount")));
            s1.SelectByIndex(0);
            System.Threading.Thread.Sleep(3000);

            driver.FindElement(By.Name("inideposit")).SendKeys("200");
            driver.FindElement(By.Name("button2")).Click();
            Console.WriteLine("Sucessfully Added new account");



        }

        [Test]

        public void PayDeposit()
        {
            //username
            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            //mngr156510

            //Password
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");
            //nydEmup
            //submit
            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //Click on deposit and follow operations
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[8]/a")).Click();
            driver.FindElement(By.XPath("//input[@name='accountno']")).SendKeys("1825");
            driver.FindElement(By.XPath("//input[@name='ammount']")).SendKeys("200");
            driver.FindElement(By.XPath("//input[@name='desc']")).SendKeys("Rent");
            driver.FindElement(By.Name("AccSubmit")).Click();



        }
        [Test]
        public void Withdraw ()
        {
          
            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");
            
            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //Click on deposit and follow operations
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[9]/a")).Click();

            driver.FindElement(By.XPath("//input[@name='accountno']")).SendKeys("1825");
            driver.FindElement(By.XPath("//input[@name='ammount']")).SendKeys("200");
            driver.FindElement(By.XPath("//input[@name='desc']")).SendKeys("Expenses");
            driver.FindElement(By.Name("AccSubmit")).Click();



        }
        [Test]
        public void FundTransfer ()
        {

            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");

            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //Click on fundtransfer and follow operations
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[10]/a")).Click();

            driver.FindElement(By.Name("payersaccount")).SendKeys("1825589");
            driver.FindElement(By.Name("payeeaccount")).SendKeys("1825");
            driver.FindElement(By.XPath("//input[@name='ammount']")).SendKeys("50");
            driver.FindElement(By.XPath("//input[@name='desc']")).SendKeys("help");
            driver.FindElement(By.Name("AccSubmit")).Click();



        }
        [Test]
        public void RegesterInsurance ()
        {

            driver.FindElement(By.XPath("//input[@name='uid']")).SendKeys("mngr156510");
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("nydEmup");

            driver.FindElement(By.XPath("//input[@name='btnLogin']")).Click();

            //Click on fundtransfer and follow operations
            driver.FindElement(By.XPath("/html/body/div[3]/div/ul/li[10]/a")).Click();

            driver.FindElement(By.Name("payersaccount")).SendKeys("1825589");
            driver.FindElement(By.Name("payeeaccount")).SendKeys("1825");
            driver.FindElement(By.XPath("//input[@name='ammount']")).SendKeys("50");
            driver.FindElement(By.XPath("//input[@name='desc']")).SendKeys("help");
            driver.FindElement(By.Name("AccSubmit")).Click();



        }
        [TearDown]

        public void TearDown ()
        {
            //driver.Quit();
            //driver.Close();
        }
    }
}
