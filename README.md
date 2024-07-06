# Selenium Tests Project

This project contains automated tests using Selenium and NUnit for testing the website.

The main test class is [here](https://github.com/Leontievna/miacademy/blob/main/Tests/ParentFormTest.cs)

**Allure report**

For generating the Allure report locally, follow the instructions below after cloning the project to your local machine:

1.Install Alllure Commandline 

```brew install allure```


2.Run tests

```dotnet test --logger:trx --results-directory allure-results```


3.Generate a report

```allure generate --clean allure-results```


4.Open a report

```allure open```


For checking the report after last push event to the allure-report brunch open [link](https://leontievna.github.io/miacademy/)