using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace WebApp.Test
{
    [TestClass]
    public class FirefoxSeleniumTest
    {
        private IWebDriver FirefoxDriver;

        [TestInitialize]
        public void ClassInitialize(TestContext context)
        {
            FirefoxDriver = new FirefoxDriver();
            FirefoxDriver.Url = "http://localhost:56873/factura/create";
        }

        [TestMethod]
        public void FirefoxTest()
        {

            IWebElement FacturaElement = FirefoxDriver.FindElement(By.Id("IdFactura"));
            IWebElement DescriptionElement = FirefoxDriver.FindElement(By.Id("Descripcion"));
            IWebElement IvaElement = FirefoxDriver.FindElement(By.Id("Iva"));
            IWebElement PrecioElement = FirefoxDriver.FindElement(By.Id("Precio"));

            IWebElement SubmitButton = FirefoxDriver.FindElement(By.Id("factura-submit-input"));

            FacturaElement.SendKeys("0");
            DescriptionElement.SendKeys("A description");
            IvaElement.SendKeys("21");
            PrecioElement.SendKeys("10");

            SubmitButton.Click();

            var currentURL = FirefoxDriver.Url;

            Assert.AreEqual("http://localhost:56873/factura", currentURL);
        }
    }
}
