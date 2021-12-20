using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        [System.Obsolete]
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        private IWebElement yesButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[1]")]
        private IWebElement noButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[1]/div[1]/div[2]/h1/span")]
        private IWebElement titleDisplayed { get; set; }

        //Edit Icon
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        private IWebElement EditIcon { get; set; }
        //Title first row
        [FindsBy(How = How.XPath, Using = " //div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        private IWebElement TitleFirstRow { get; set; }



        internal void Listings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
        }
        internal void ClickManageListing()
        {
            manageListingsLink.Click();
        }
        internal void ClickViewIcon()
        {
            view.Click();
        }
        internal void ClickDeleteIcon()
        {
            delete.Click();
        }
        internal IWebElement TitleDisplayed()
        {
            return titleDisplayed;
        }

        internal void DeleteClickYes()
        {
            yesButton.Click();
        }

        internal void DeleteClickNo()
        {
            noButton.Click();
        }
        internal void ClickEditIcon()
        {
            EditIcon.Click();
        }
        internal string TitleFirstRowValue()
        {
            return TitleFirstRow.Text;
        }
        internal int CountRows()
        {
            ReadOnlyCollection<IWebElement> tableRows = GlobalDefinitions.driver.FindElements(By.CssSelector("#listing-management-section> div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody >tr"));
            int rows = tableRows.Count;
            return rows;

        }

    }
}
