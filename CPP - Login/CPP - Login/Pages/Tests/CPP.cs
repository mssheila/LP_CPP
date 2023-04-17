using CPP___Login.Pages.LoginPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//go to CPP
driver.Navigate().GoToUrl("https://test-payoutportal.liquidpay.com/login");
Thread.Sleep(3000);

//initialize and enter credentials
LoginPage loginPageObj = new LoginPage();
loginPageObj.EnterCredential(driver);
