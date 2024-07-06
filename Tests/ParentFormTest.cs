using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework.Internal;

namespace miacademy;

[AllureNUnit]
[TestFixture]
public class ParentFormTest : BaseTest
{
    Randomizer randomizer = new();
    string firstName = "Name";
    string secondName = "Surname";
    string number = "151";
    string email = "test@test.com";
    string dateStudyStart = "01-Aug-2024";


    [Test]
    [AllureEpic("Parent Form Feature")]
    public void FillInParentFormViaMiacadamyAndMiaprepLinks()
    {
        //create opject for the first page page
        HomePageObject homePage = new HomePageObject(driver);

        //random german phone number of parent
        int randomNumber = randomizer.Next(10000000, 100000000);
        string randomDigits = randomNumber.ToString();
        
        
        homePage
        //open https://miacademy.co/#/ and navigate to MiaPrepOnlineHighSchool through the link on banner |
        .OpenHomePage()
        //apply to MOHS
        .ApplyToMOHS()
        //fill in the Parent Information | parentPage
        .FillInForms(firstName, secondName, number + randomDigits, email, dateStudyStart)
        //check that there is a Student Information page | childPage
        .CheckChildFormPageIsOpen();
    }
}