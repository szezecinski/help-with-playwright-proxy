using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace sample;

public class TestWithRemoteWebDriver
{
    [Test]
    public void TestRemote()
    {
        var opt = new ChromeOptions();
        // Uncomment to add proxy:
        // opt.Proxy = new Proxy();
        // opt.Proxy.SslProxy = "https://add_an_existent_proxy_address:port";

        var containerHubSeleniumGrid = "http://localhost:4444/";

        var driver = new RemoteWebDriver(new Uri(containerHubSeleniumGrid), opt);
        driver.Navigate().GoToUrl("https://playwright.dev/");
        Thread.Sleep(5000);
        driver.Quit();
    }
}