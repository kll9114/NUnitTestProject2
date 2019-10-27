using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace ToolsQA.Selenium_Basics
{
    class FindElementCommands
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Utilisateur\Documents\Visual Studio 2015\Projects\Onlystore\packages\WebDriver.ChromeDriver.win32.76.0.3809.68\content");

        [Test]
        public void Test()
        {

            // Launch the ToolsQA WebSite
            driver.Url = ("https://www.amazon.fr/");
            driver.Manage().Window.Maximize();

            // Type Name in the FirstName text box      
            // Type Name in the FirstName text box      

            driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("playstation 4");

            //Type LastName in the LastName text box

            // Click on the Submit button
            driver.FindElement(By.XPath("(//*[contains(@value,'Go')])[1]")).Click();

            //   driver.FindElement(By.XPath("(//*[contains(text(),'Livraison gratuite')])[1]")).Click();
            Thread.Sleep(100);
            driver.FindElement(By.XPath("(//*[contains(text(),'Call of Duty: Modern Warfare - Edition Exclusive Amazon (PS4)')])[1]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("(//*[contains(@title,'Ajouter au panier')])[1]")).Click();
           
             Thread.Sleep(1000);
             driver.FindElement(By.XPath("(//*[contains(text(),'Passer la commande (1 article)')])[1]")).Click();

            Thread.Sleep(1000);

            driver.FindElement(By.XPath("(//*[contains(@name,'email')])[1]")).SendKeys("mohammedkoulal@yahoo.fr");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("(//*[contains(@id,'continue')])[1]")).Click();




        }
    }
}