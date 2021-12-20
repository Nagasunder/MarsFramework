using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using System.IO;

namespace MarsFramework.Pages
{
    internal class ShareSkill
    {
        [System.Obsolete]
        public ShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.Name, Using = "description")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.Name, Using = "categoryId")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[contains(@class,'ui container')]/div[contains(@class,'listing')]/form[contains(@class,'ui form')]/div[contains(@class,'tooltip-target ui grid')]/div[contains(@class,'twelve wide column')]/div[contains(@class,'')]/div[contains(@class,'ReactTags__tags')]/div[contains(@class,'ReactTags__selected')]/div[contains(@class,'ReactTags__tagInput')]/input[1]")]
        private IWebElement Tags { get; set; }


        //Select the Service type
        [FindsBy(How = How.XPath, Using = "//form/div[5]/div[@class='twelve wide column']/div/div[@class='field']")]
        private IWebElement ServiceTypeOptions { get; set; }
        //Hourly
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement HourlyBasisService { get; set; }
        //One off
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement OneOffService { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "//form/div[6]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement LocationTypeOption { get; set; }
        //On-Site
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        private IWebElement LocationTypeOnSite { get; set; }
        //Online
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        private IWebElement LocationTypeOnline { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.Name, Using = "startDate")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.Name, Using = "endDate")]
        private IWebElement EndDateDropDown { get; set; }

        //Storing the table of available days
        [FindsBy(How = How.XPath, Using = "//body/div/div/div[@id='service-listing-section']/div[@class='ui container']/div[@class='listing']/form[@class='ui form']/div[7]/div[2]/div[1]")]
        private IWebElement Days { get; set; }


        //Storing the starttime
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTime { get; set; }

        //Click on StartTime dropdown   
        [FindsBy(How = How.XPath, Using = "//div[3]/div[2]/input[1]")]
        private IWebElement StartTimeDropDown { get; set; }
        //Start time on Sunday
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[7]/div[2]/div/div[2]/div[2]/input")]
        private IWebElement StartTimeDropDownField { get; set; }

        //
        //Click on EndTime dropdown
        [FindsBy(How = How.XPath, Using = "//div[3]/div[3]/input[1]")]
        private IWebElement EndTimeDropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[7]/div[2]/div/div[2]/div[3]/input")]
        private IWebElement EndTimeDropDownField { get; set; }
        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "//form/div[8]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement SkillTradeOption { get; set; }

        //Skill exchange radio button
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[8]/div[2]/div/div[1]/div/input")]
        private IWebElement SkillExchangeRadio { get; set; }

        //Credit radio button
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[8]/div[2]/div/div[2]/div/input")]
        private IWebElement CreditRadio { get; set; }
        //Enter Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active/Hidden option
        [FindsBy(How = How.XPath, Using = "//form/div[10]/div[@class='twelve wide column']/div/div[@class = 'field']")]
        private IWebElement ActiveOption { get; set; }
        //ActiveRadio
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[10]/div[2]/div/div[1]/div/input")]
        private IWebElement ActiveRadio { get; set; }
        //Hidden radio
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[10]/div[2]/div/div[2]/div/input")]
        private IWebElement HiddenRadio { get; set; }
        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
        //Work sample
        [FindsBy(How = How.XPath, Using = "//*[@id=\"selectFile\"]")]
        private IWebElement WorkSample { get; set; }
        //Tag 1
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[4]/div[2]/div/div/div/span/a")]
        private IWebElement Tag1 { get; set; }
        //Skill Exchange delete btn
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[8]/div[4]/div/div/div/div/span/a")]
        private IWebElement SkillExchageDelete { get; set; }
        //Work Sample delete
        [FindsBy(How = How.XPath, Using = "//div[2]/div/form/div[9]/div/div[2]/section/div/label/div/div/i[1]")]
        private IWebElement WorkSampleDelete { get; set; }

        //Edit success message
        [FindsBy(How = How.CssSelector, Using = "body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success > div")]
        private IWebElement EditSuccess { get; set; }

        internal string EditSuccessMessage()
        {
            return EditSuccess.Text;
        }

        internal void ClickShareSkillButton()
        {
            ShareSkillButton.Click();
        }
        internal IWebElement TitleDisplay()
        {
            return Title;
        }

        internal void FillAvailableDays(string day, string startTime, string EndTime)
        {
            Dictionary<string, int> daysList = new Dictionary<string, int>();
            daysList.Add("Sun", 2);
            daysList.Add("Mon", 3);
            daysList.Add("Tue", 4);
            daysList.Add("Wed", 5);
            daysList.Add("Thu", 6);
            daysList.Add("Fri", 7);
            daysList.Add("Sat", 8);

            IWebElement dayLocator = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[" + daysList[day] + "]/div[1]/div/input"));
            dayLocator.Click();
            IWebElement startTimeLocator = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[" + daysList[day] + "]/div[2]/input"));
            startTimeLocator.SendKeys(startTime);
            IWebElement endTimeLocator = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/form/div[7]/div[2]/div/div[" + daysList[day] + "]/div[3]/input"));
            endTimeLocator.SendKeys(EndTime);
        }
        internal void EnterShareSkill(string sheetName)
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\sunda\OneDrive\Desktop\Internship_MVP\marsframework-master\marsframework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", sheetName);
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            SelectElement categoryDropdown = new SelectElement(CategoryDropDown);
            categoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            SelectElement subCategoryDropdown = new SelectElement(SubCategoryDropDown);
            subCategoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
                OneOffService.Click();
            else
                HourlyBasisService.Click();

            if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "On-site")
                LocationTypeOnSite.Click();
            else
                LocationTypeOnline.Click();
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));

            //...........Available Day and Time...............
            string daySelected = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");
            string startTime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
            string endTime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            FillAvailableDays(daySelected, startTime, endTime); ;
            //..........................

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Skill-Exchange")
            {
                SkillExchangeRadio.Click();
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
            }
            else
            {
                CreditRadio.Click();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
            }
            //Work sample upload...................
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            WorkSample.SendKeys(@"C:\Users\sunda\OneDrive\Desktop\Internship_MVP\marsframework-master\marsframework-master\MarsFramework\Data\worksample.txt");

            //C: \Users\sunda\Source\repos\MarsFrameworkCompetitionTask\MarsFramework\Data\worksample.txt

            //....................
            if (GlobalDefinitions.ExcelLib.ReadData(2, "Active") == "Active")
                ActiveRadio.Click();
            else
                HiddenRadio.Click();

            Save.Click();
        }
        internal IWebElement EnteredTitle()
        {
            IWebElement actualTitle = GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"));
            return actualTitle;
        }
        internal IWebElement ErrorMessage()
        {
            return GlobalDefinitions.driver.FindElement(By.XPath("//div[2]/div/form/div[1]/div/div[2]/div/div[2]/div"));
        }


        //Edit share skill (separate test case needed for listings without work samples)..
        internal void EditShareSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(@"C:\Users\sunda\OneDrive\Desktop\Internship_MVP\marsframework-master\marsframework-master\MarsFramework\ExcelData\TestDataShareSkill.xlsx", "EditListing");
            Title.Clear();
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Description.Clear();
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            SelectElement categoryDropdown = new SelectElement(CategoryDropDown);
            categoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));
            SelectElement subCategoryDropdown = new SelectElement(SubCategoryDropDown);
            subCategoryDropdown.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "SubCategory"));
            Tag1.Click();
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Tags.SendKeys(Keys.Enter);

            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "One-off service")
                OneOffService.Click();
            else
                HourlyBasisService.Click();

            if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "On-site")
                LocationTypeOnSite.Click();
            else
                LocationTypeOnline.Click();
            StartDateDropDown.Clear();
            StartDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Startdate"));
            EndDateDropDown.Clear();
            EndDateDropDown.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Enddate"));

            //...........Available Day and Time...............
            string daySelected = GlobalDefinitions.ExcelLib.ReadData(2, "Selectday");
            string startTime = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
            string endTime = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            FillAvailableDays(daySelected, startTime, endTime); ;
            //..........................

            if (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Skill-Exchange")
            {
                SkillExchangeRadio.Click();
                SkillExchageDelete.Click();
                SkillExchange.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill-Exchange"));
                SkillExchange.SendKeys(Keys.Enter);
                GlobalDefinitions.wait(2000);

            }
            else
            {
                CreditRadio.Click();
                CreditAmount.Clear();
                CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));
            }
            //Work sample upload...................
            WorkSampleDelete.Click();
            GlobalDefinitions.wait(2000);
            string startupPath = System.IO.Directory.GetCurrentDirectory();
            WorkSample.SendKeys(startupPath + "\\MarsFramework\\Data\\worksample.txt");
            //....................
            if (GlobalDefinitions.ExcelLib.ReadData(2, "Active") == "Active")
                ActiveRadio.Click();
            else
                HiddenRadio.Click();

            Save.Click();

        }

    }
}
