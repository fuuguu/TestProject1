using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        private WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.sports.ru/");

            Assert.AreEqual(driver.Title, "Спорт: футбол, хоккей, баскетбол, теннис, бокс, биатлон, Формула-1 — все новости спорта на Sports.ru");

            driver.Quit();
        }

        [Test]
        public void Test2()
        {
            driver.Navigate().GoToUrl("https://www.sports.ru/");

            IWebElement element = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div/div[1]/div[3]/button[1]/span"));
            bool status = element.Displayed;
            Assert.IsTrue(status);

            driver.Quit();
        }

        [Test]
        public void Test3()
        {
            driver.Navigate().GoToUrl("https://www.sports.ru/");

            var button = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div/div[1]/nav/ul/li[1]/a/span"));
            button.Click();

            driver.Quit();
        }

        [Test]
        public void Test4()
        {
            driver.Navigate().GoToUrl("https://www.sports.ru/");

            driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div/div[1]/div[3]/button[1]/span")).Click();

            driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div/div[1]/div[3]/div/input")).SendKeys("Donda");

            driver.Quit();
        }

        [Test]
        public void Test5()
        {
            driver.Navigate().GoToUrl("https://www.sports.ru/");

            var button = driver.FindElement(By.XPath("/html/body/div[3]/header/div[2]/div/div[2]/button/div[1]"));
            button.Click();

            driver.Quit();
        }

    }
}