﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//go to CPP
driver.Navigate().GoToUrl("https://test-payoutportal.liquidpay.com/login");
Thread.Sleep(3000);

//key in with valid username
IWebElement username = driver.FindElement(By.XPath("/html/body/app-root/div/app-auth/div[1]/div/div[3]/owl-carousel-o/div/div[1]/owl-stage/div/div/div[3]/form/div[1]/input"));
username.Click();
username.SendKeys("ceo@mailinator.com");

//key in with valid password
IWebElement password = driver.FindElement(By.Id("login-password-input"));
password.Click();
password.SendKeys("P@ss1234");

//press login
IWebElement loggin = driver.FindElement(By.XPath("/html/body/app-root/div/app-auth/div[1]/div/div[3]/owl-carousel-o/div/div[1]/owl-stage/div/div/div[3]/div/button"));
loggin.Click();
Thread.Sleep(1000);

//check if user is redirected to 2fa
IWebElement verificationPage = driver.FindElement(By.XPath("/html/body/app-root/div/app-auth/div[1]/div/div[3]/owl-carousel-o/div/div[1]/owl-stage/div/div/div[4]/form/div/label"));
if (verificationPage.Displayed)
    Console.WriteLine("User verificaton needed");
else Console.WriteLine("User NOT able to get to verification page");
