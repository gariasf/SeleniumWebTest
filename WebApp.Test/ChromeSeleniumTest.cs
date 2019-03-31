using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebApp.Test
{
    [TestClass]
    public class ChromeSeleniumTest
    {
        private IWebDriver ChromeDriver;

        [TestInitialize]
        public void ClassInitialize(TestContext context)
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Url = "http://localhost:56873/factura/create";
        }

        [TestMethod]
        public void ChromeTest()
        {

            IWebElement FacturaElement = ChromeDriver.FindElement(By.Id("IdFactura"));
            IWebElement DescriptionElement = ChromeDriver.FindElement(By.Id("Descripcion"));
            IWebElement IvaElement = ChromeDriver.FindElement(By.Id("Iva"));
            IWebElement PrecioElement = ChromeDriver.FindElement(By.Id("Precio"));

            IWebElement SubmitButton = ChromeDriver.FindElement(By.Id("factura-submit-input"));

            FacturaElement.SendKeys("0");
            DescriptionElement.SendKeys("A description");
            IvaElement.SendKeys("21");
            PrecioElement.SendKeys("10");

            SubmitButton.Click();

            var currentURL = ChromeDriver.Url;

            Assert.AreEqual("http://localhost:56873/factura", currentURL);
        }
    }
}
