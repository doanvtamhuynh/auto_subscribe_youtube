using auto_subscribe_youtube.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_subscribe_youtube.Logic
{
    internal static class Google_Services
    {
        private static IWebDriver _driver;
        public static void OpenGoogle()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            options.AddArgument(@"--start-maximized");

            _driver = new ChromeDriver(driverService, options);
            _driver.Navigate().GoToUrl("https://accounts.google.com");
        }

        public static void CloseGoogle()
        {
            _driver.Close();
        }
        public static void LoginGoogle(EmailAccount emailAccount)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

                IWebElement emailInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                                                    ElementExists(By.XPath("//input[@type='email']")));
                emailInput.SendKeys(emailAccount.email);
                emailInput.SendKeys(OpenQA.Selenium.Keys.Enter);

                IWebElement passwordInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                                                    ElementExists(By.XPath("//input[@type='password']")));
                passwordInput.SendKeys(emailAccount.password);
                passwordInput.SendKeys(OpenQA.Selenium.Keys.Enter);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                CloseGoogle();
            }
        }
    }
}
