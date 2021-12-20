using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsFramework.Pages;
using NUnit.Framework;
using MarsFramework.Global;
using OpenQA.Selenium;

namespace MarsFramework
{
    class ShareSkillTest : Global.Base
    {
        [Test]
        [Obsolete]
        public void ShareSkill_TC_001_02()
        {
            test = extent.StartTest("Title displayed or not", "Click Share Skill button and check if it navigates to the form");
            ShareSkill shareSkill = new ShareSkill();
            GlobalDefinitions.wait(2000);
            shareSkill.ClickShareSkillButton();
            Assert.IsTrue(shareSkill.TitleDisplay().Displayed);
        }
        [Test]
        [Obsolete]
        public void ShareSkill_TC_016_01()
        {
            test = extent.StartTest("Form submission with invalid data", "Fill Title fields with invalid data and submit");
            ShareSkill shareSkill = new ShareSkill();

            GlobalDefinitions.wait(2000);
            shareSkill.ClickShareSkillButton();
            string sheetName = "EmptyTitle";
            shareSkill.EnterShareSkill(sheetName);
            Assert.IsTrue(shareSkill.ErrorMessage().Displayed);
        }
        [Test]
        [Obsolete]
        public void ShareSkill_01ValidData_TC_015_01()
        {
            test = extent.StartTest("Form submission with valid data", "Fill all form fields with valid data and submit");
            ShareSkill shareSkill = new ShareSkill();
            GlobalDefinitions.wait(2000);
            shareSkill.ClickShareSkillButton();
            string sheetName = "ShareSkillValidData";
            shareSkill.EnterShareSkill(sheetName);
            Assert.IsTrue(shareSkill.EnteredTitle().Displayed);
        }
        [Test]
       [Obsolete]
        public void ShareSkill_TC_002_02()
        {
            test = extent.StartTest("Form submission with special character", "Fill Title fields with special char string data and submit");
            ShareSkill shareSkill = new ShareSkill();
            GlobalDefinitions.wait(2000);
            shareSkill.ClickShareSkillButton();
            string sheetName = "SpecialChar";
            shareSkill.EnterShareSkill(sheetName);
            Assert.IsTrue(shareSkill.ErrorMessage().Displayed);
        }

    }
}
