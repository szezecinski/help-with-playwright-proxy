using System;
using System.Threading;
using NUnit.Framework;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace sample;

public class TestWithPlaywright
{
    [Test]
    public async Task TestPW()
    {
        var opt = new BrowserTypeLaunchOptions(){
            Headless = false,
            // uncomment to add proxy:
            // Proxy = new Proxy(){
            //     Server = "https://add_an_existent_proxy_address:port"
            // },
            // Args = new List<string>() {"--proxy-server=https://add_an_existent_proxy_address:port"}
        };

        using var pw = await Playwright.CreateAsync();
        await using var browser = await pw.Chromium.LaunchAsync(opt);
        
        var page = await browser.NewPageAsync();
        await page.GotoAsync("https://playwright.dev/");
        Thread.Sleep(5000);
    }
}