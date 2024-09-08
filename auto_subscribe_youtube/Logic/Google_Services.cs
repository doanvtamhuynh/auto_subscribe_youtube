using auto_subscribe_youtube.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_subscribe_youtube.Logic
{
    internal static class Google_Services
    {
        private static IWebDriver _driver;
        private static WebDriverWait _wait;
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
            if (_driver != null)
            {
                _driver.Close();
                _driver.Dispose();
                _driver = null;
            }
        }
        public static bool LoginGoogle(EmailAccount emailAccount)
        {
            try
            {
                _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                IWebElement emailInput = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                                                    ElementExists(By.XPath("//input[@type='email']")));
                if(emailInput != null)
                {
                    emailInput.SendKeys(emailAccount.email);
                    emailInput.SendKeys(OpenQA.Selenium.Keys.Enter);
                }


                _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                IWebElement passwordInput = _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                                                    ElementExists(By.XPath("//input[@type='password'][@name='Passwd']")));
                if(passwordInput != null)
                {
                    passwordInput.SendKeys(emailAccount.password);
                    passwordInput.SendKeys(OpenQA.Selenium.Keys.Enter);
                }
                return true;
            }
            catch (Exception ex)
            {
                CloseGoogle();
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
        }

        public static void Subscribe(List<Youtube> youtubes, CancellationToken token)
        {
            try
            {
                foreach (var item in youtubes)
                {
                    if (!token.IsCancellationRequested 
                        && _driver != null)
                    {

                        _driver.Navigate().GoToUrl(item.link);
                        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
                        IWebElement emailInput;

                        try
                        {
                            emailInput = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.
                                         ElementExists(By.XPath("//button[@aria-label='Subscribe']")));
                        }
                        catch
                        {
                            continue;
                        }
                        emailInput.Click();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                CloseGoogle();
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                CloseGoogle();
            }
        }
    }
}
