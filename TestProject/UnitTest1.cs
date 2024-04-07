using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace TestProject;

public class Tests
{
    IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
    }

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("https://www.saucedemo.com");

        Assert.IsTrue(driver.Url.Contains("saucedemo"));
        Assert.That(driver.Title, Is.EqualTo("Swag Labs"));
        //Assert.Pass();
    }

    [TearDown]
    public void TearDown() { driver.Quit(); }
}
