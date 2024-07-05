/*
Represents the home page, includes methods to open the page and navigate to other pages.
*/
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.NUnit.Attributes;

namespace miacademy;
public class HomePageObject(ChromeDriver driver) : BasePage(driver)
{
    string mainUrl = "https://miacademy.co/#/";
    private By LinkMiaPrepHighSchool = By.XPath("//*[@class=\"mia-announcementText\"]//a");

    
    [AllureStep("Open a #{mainUrl} page and navigate to MiaPrep Online High School")]
    public OnlineHighSchoolPageObject OpenHomePage()
    {
        driver.Navigate().GoToUrl(mainUrl);
        //navigate to MiaPrep Online High School through the link on banner
        driver.FindElement(LinkMiaPrepHighSchool).Click();
        return new OnlineHighSchoolPageObject(driver);
    }
}
