﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
           
        }


        [SetUp]
        public void Intialize()
        {
            // Create the reference for Browser
            PropertiesCollection.driver = new ChromeDriver();

            // Navigate to Google page
            PropertiesCollection.driver.Navigate().GoToUrl("executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {
            
            // Initialize page by calling its reference
            EAPageObject page = new EAPageObject();

            page.textInitial.SendKeys("executeautomation");
            page.btnSave.Click();



            //// Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Intial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Name);

            //Console.WriteLine("The value from my Title is: ", SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is:", SeleniumGetMethods.GetText("Initial", PropertyType.Name));

            //// Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void Cleanup()
        {
            // Quit
            PropertiesCollection.driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
