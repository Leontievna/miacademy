using NUnit.Framework.Internal;

namespace miacademy;

[TestFixture]
public class ParentFormTest : BaseTest
{
    Randomizer randomizer = new();
    string partialUrlApplicationForm = "miaplazahelp/form/MOHSInitialApplication";
    string firstName = "Name";
    string secondName = "Surname";
    string number = "151";
    string email = "test@test.com";
    string dateStudyStart = "01-Aug-2024";


    [Test]
    public void FillInParentFormViaMiacadamyAndMiaprepLinks()
    {
        //create opject for each page
        HomePageObject homePage = new HomePageObject(driver);
        OnlineHighSchoolPageObject highSchoolPage = new OnlineHighSchoolPageObject(driver);
        PerentDataPageObject parentPage = new PerentDataPageObject(driver);
        ChildDataPageObject childPage = new ChildDataPageObject(driver);

        //random german phone number of parent
        int randomNumber = randomizer.Next(10000000, 100000000);
        string randomDigits = randomNumber.ToString();

        //open https://miacademy.co/#/ and navigate to MiaPrep Online High School through the link on banner
        homePage.OpenHomePage();

        //apply to MOHS
        highSchoolPage.ApplyToMOHS();
        Assert.That(driver.Url, Does.Contain(partialUrlApplicationForm), $"URL has to contain '{partialUrlApplicationForm}'");

        //fill in the Parent Information 
        parentPage.FillInForms(firstName, secondName, number + randomDigits, email, dateStudyStart);

        //check that there is a Student Information page
        childPage.CheckChildFormPageIsOpen();
    }
}