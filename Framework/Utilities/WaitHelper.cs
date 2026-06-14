using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

public class WaitHelper
{
    private IWebDriver driver;
    private WebDriverWait wait;

    public WaitHelper(IWebDriver driver)
    {
        this.driver = driver;
        wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    }

    public void WaitForElement(By locator)
    {
        wait.Until(d => d.FindElement(locator).Displayed);
    }
}