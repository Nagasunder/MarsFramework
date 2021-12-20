using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    class ManageListingTest : Global.Base
    {
        [Test]
        [Obsolete]
        public void ManageListing_1_View_TC_004_02()
        {
            test = extent.StartTest("Check if the user is able to view the service details");
            ManageListings manageListings = new ManageListings();
            GlobalDefinitions.wait(5000);
            manageListings.ClickManageListing();
            manageListings.ClickViewIcon();
            Assert.IsTrue(manageListings.TitleDisplayed().Displayed);
        }
        [Test]
        [Obsolete]
        public void ManageListing_3_Delete_TC_006_04()
        {
            test = extent.StartTest("Check if the user is able to click on YES button and delete the listing");
            ManageListings manageListings = new ManageListings();
            GlobalDefinitions.wait(2000);
            manageListings.ClickManageListing();
            int numberOfListings = manageListings.CountRows();
            manageListings.ClickDeleteIcon();
            manageListings.DeleteClickYes();
            Thread.Sleep(1000);
            int numberOfListingsAfterDelete = manageListings.CountRows();
            Assert.AreEqual(numberOfListingsAfterDelete, numberOfListings - 1);
        }
        [Test]
        [Obsolete]
        public void ManageListing_2_Edit_TC_005_01()
        {
            test = extent.StartTest("Check if the user is able to edit the service");
            ManageListings manageListings = new ManageListings();
            ShareSkill shareskill = new ShareSkill();
            GlobalDefinitions.wait(2000);
            manageListings.ClickManageListing();
            manageListings.ClickEditIcon();
            shareskill.EditShareSkill();
            Assert.AreEqual(manageListings.TitleFirstRowValue(), "JAVA");

        }

    }
}
