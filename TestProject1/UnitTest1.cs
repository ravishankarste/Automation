using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestProject1;

public class Tests
{
    IWebDriver driver;
    [SetUp]
    public void Setup()
    {
        driver.Navigate().GoToUrl("https://wwww.saucedome.com/");
    }

    [Test]
    public void Test1()
    {
        Assert.IsTrue(driver.Url.Contains("saucedmoe"));
        Assert.That( ("saucedmoe"));
        //Assert.Pass();
        //dadadfadfadfadfadf
    }
}
