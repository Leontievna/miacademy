using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;

namespace miacademy;

[TestFixture]
public class BaseTest
{
    public ChromeDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();
    }

    [TearDown]
    public void Close()
    {
        driver.Close();
    }
}