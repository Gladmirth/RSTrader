using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;


class Main_Botter
{
    static void Main()
    {

        // Red text is for printing errors
        void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        // Green text is for printing successes
        void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        RedMessage("Red Message Initialized");
        GreenMessage("Green Message Initialized");




        string password = "wegonnaberich";
        string username = "thelibertyboy@uky.edu";
        IWebDriver driver = new ChromeDriver();
        IWebElement UserName_TextBox;
        IWebElement Password_TextBox;
        IWebElement No_Save_Password;
        IWebElement GrandExchangeButton;
        GreenMessage("Initial_Setup Variables Successfully Initialized");

        void Initial_Setup()
        {
            try
            {
                driver.Navigate().GoToUrl("http://www.runescape.com/companion/comapp.ws");
                GreenMessage("Navigation Complete");
                Thread.Sleep(10000);
                GreenMessage("Wait for page to load");
                driver.SwitchTo().Frame(0);
                UserName_TextBox = driver.FindElement(By.Name("username"));
                UserName_TextBox.Click();
                UserName_TextBox.SendKeys(username);
                GreenMessage("Found Username Text Box");
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(0);
                Password_TextBox = driver.FindElement(By.Name("password"));
                Password_TextBox.Click();
                Password_TextBox.SendKeys(password);
                Password_TextBox.Submit();
                GreenMessage("Found Password Text Box");
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(0);
                GreenMessage("Wait for RS Authenticator");
                Thread.Sleep(20000);
                No_Save_Password = driver.FindElement(By.CssSelector("#modal > div > div > div > div.pill-wrap.double > a:nth-child(1)"));
                No_Save_Password.Click();
                GreenMessage("Don't save password clicked");
                Thread.Sleep(5000);
                GrandExchangeButton = driver.FindElement(By.CssSelector("#main-menu > div > nav > ul > li.grand-exchange > a"));
                GrandExchangeButton.Click();
                GreenMessage("Found GE Button on Main Menu");
                Thread.Sleep(5000);
            }
            catch (NoSuchElementException)
            {
                RedMessage("Initial Setup Failed");
            }
        }
        Initial_Setup();




        IWebElement Buy;
        IWebElement New_SearchBar;
        IWebElement New_MagicLogsButton;
        GreenMessage("Set_Price Variables Successfully Initialized");
        void Set_Price()
        {
            try
            {
                
                Buy = driver.FindElement(By.CssSelector("body > div.sliding-wrapper > div.ng-scope > section > div > ul > li:nth-child(1) > div > div > div.details.with-buttons > div > a:nth-child(1)"));
                Buy.Click();
                New_SearchBar = driver.FindElement(By.XPath("//*[@id=\"search\"]"));
                New_SearchBar.Click();
                New_SearchBar.SendKeys("Magic");
                Thread.Sleep(2000);
                New_SearchBar.SendKeys(" Logs");
                New_MagicLogsButton = driver.FindElement(By.CssSelector("body > div.sliding-wrapper > div.ng-scope > section > div.content.push-top-double.push-bottom-tiny.ng-scope > ul > li > a > div.details > span"));
                New_MagicLogsButton.Click();
            }
            catch (NoSuchElementException)
            {
                RedMessage("Set_Price Failed");
            }
        }
        
        



        /*
        * -------------------
        * MAIN LOOP -- MAIN LOOP
        * MAIN LOOP -- MAIN LOOP
        * MAIN LOOP -- MAIN LOOP
        * -------------------
        */



        /*
        * -------------------
        * MAIN LOOP -- MAIN LOOP
        * MAIN LOOP -- MAIN LOOP
        * MAIN LOOP -- MAIN LOOP
        * -------------------
        */
    }
}


/*
class Botter
{
    static void Main()
    {
        string password = "wegonnaberich";
        string username = "thelibertyboy@uky.edu";



        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("http://www.runescape.com/companion/comapp.ws");



        IWebElement UserName_TextBox;
        IWebElement Password_TextBox;
        IWebElement Google_Textbox;
        IWebElement Buy;
        IWebElement No_Save_Password;
        Thread.Sleep(10000);
        IWebElement GE_SearchBar;
        IWebElement Magic_Log_Button;


        driver.SwitchTo().Frame(0);
        Find_Username_TextBox();
        Find_Password();
        Thread.Sleep(30000);
        No_Save_Pass_Button();
        Thread.Sleep(30000);
        IWebElement GrandExchangeButton;
        Find_GE_Button();
        Thread.Sleep(5000);
        Find_Buy_Button();
        Thread.Sleep(5000);
        Type_Magic_Logs();
        Thread.Sleep(1000);
        Select_Magic_Logs();




        
        void Type_Magic_Logs()
        {
            try
            {
                GE_SearchBar = driver.FindElement(By.CssSelector("#search"));
                if (GE_SearchBar.Displayed)
                {
                    GreenMessage("I can see the GE Search Bar!h");
                }
                GE_SearchBar.Click();
                GE_SearchBar.SendKeys("Magic Logs");
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the GE Search Bar!");
            }
        }
        void Find_Username_TextBox()
        {
            try
            {
                UserName_TextBox = driver.FindElement(By.Name("username"));
                if (UserName_TextBox.Displayed)
                {
                    GreenMessage("I can see the CSS Path Element!");
                }
                UserName_TextBox.Click();
                UserName_TextBox.SendKeys(username);
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the CSS Path Element!");
            }
        }
        void Find_Password()
        {
            try
            {
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(0);
                Password_TextBox = driver.FindElement(By.Name("password"));
                if (Password_TextBox.Displayed)
                {
                    GreenMessage("I can see the CSS Path Element!");
                    Password_TextBox.Click();
                    Password_TextBox.SendKeys(password);
                }

                Password_TextBox.Submit();
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the CSS Path Element!");
            }
        }
        void No_Save_Pass_Button()
        {
            try
            {
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(0);
                No_Save_Password = driver.FindElement(By.CssSelector("#modal > div > div > div > div.pill-wrap.double > a:nth-child(1)"));
                if (No_Save_Password.Displayed)
                {
                    GreenMessage("I can see the CSS Path Element!");
                    No_Save_Password.Click();
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the CSS Path Element!");
            }
        }
        void Find_GE_Button()
        {
            try
            {
                GrandExchangeButton = driver.FindElement(By.CssSelector("#main-menu > div > nav > ul > li.grand-exchange > a"));
                if (GrandExchangeButton.Displayed)
                {
                    GreenMessage("I can see the GE Button!");
                    GrandExchangeButton.Click();
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the GE Button!");
            }
        }
        void Find_Buy_Button()
        {
            try
            {
                driver.SwitchTo().DefaultContent();
                driver.SwitchTo().Frame(0);
                Buy = driver.FindElement(By.XPath("/html/body/div[3]/div[1]/section/div/ul/li[1]/div/div/div[2]/div/a[1]"));
                if (Buy.Displayed)
                {
                    GreenMessage("I can see the CSS Path ElementBuy Button!");
                    Buy.Click();
                }
            }
            catch (NoSuchElementException)
            {
                RedMessage("I can't see the Buy Button!");
            }
        }



    }
}
*/
