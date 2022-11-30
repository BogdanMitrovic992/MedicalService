using MedicalService.Driver;
using MedicalService.Page;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalService.Tests
{
    public class LogInTest
    {
        LogInPage loginPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialization();
            loginPage = new LogInPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUo();
        }
        [Test]
        public void TC01_EnterInvalidUserName()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "Bogdan");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.UserNotLogin.Text));
        }

        [Test]
        public void TC03_EnterInvalidUserName()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("", "");

            Assert.That("Login failed! Please ensure the username and password are valid.", Is.EqualTo(loginPage.UserNotLogin.Text));
        }


    }


}
