using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    class SignIn
    {
        [System.Obsolete]
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.driver.Url = "http://localhost:5000";
            SignIntab.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\sunda\OneDrive\Desktop\Internship_MVP\marsframework-master\marsframework-master\MarsFramework\Data\Mars.xlsx", "Credentials");
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "username"));
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "password"));
            LoginBtn.Click();
        }
    }


    }
