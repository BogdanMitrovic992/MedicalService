using MedicalService.Driver;
using MedicalService.Page;

namespace MedicalService
{
    public class Tests
    {
        LogInPage loginPage;
        MedicalPage medicalPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialization();
            loginPage = new LogInPage();
            medicalPage = new MedicalPage();
        }
        [TearDown]
        public void Close()
        {
            WebDrivers.CleanUo();
        }

        [Test]
        public void TC01_MakeAppointment_ShouldAppointmentBeCompleted()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "ThisIsNotAPassword");
            medicalPage.SelectOption("Hongkong CURA Healthcare Center");
            medicalPage.CheckBox.Click();
            medicalPage.MedicID.Click();
            medicalPage.Date.SendKeys("25/12/2022");
            medicalPage.ButtonApp.Submit();

            Assert.That("Apointment Confirmation",is EqualTo(medicalPage.Confirm.Text));
           


        }
    }
}