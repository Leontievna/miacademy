using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using AllureBeforeAttribute = Allure.NUnit.Attributes.AllureBeforeAttribute;
using AllureAfterAttribute = Allure.NUnit.Attributes.AllureAfterAttribute;


namespace techTask;

[AllureNUnit]
public class BaseTest
{
    public ChromeDriver driver;

    [SetUp]
    [AllureBefore("Setup session")]
    public void Setup()
    {
        var options = new ChromeOptions();
        options.AddArgument("--headless");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-dev-shm-usage");
        driver = new ChromeDriver(options);
        driver.Manage().Window.Maximize();
    }

    [TearDown]
    [AllureAfter("Dispose session")]
    public void Close()
    {
        driver.Close();
    }
}