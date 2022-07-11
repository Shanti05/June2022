
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Open Chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();


//Launch the turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

//Identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//Identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//Check if the user has successfully logged in
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if (helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in successfully, test passed.");
}
else
{
    Console.WriteLine("Login failed, test failed.");
}
//Create a new time and material record//

//Click on administration tab
Thread.Sleep(1000);
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();

//Select time and material tab from dropdown list
IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
Thread.Sleep(1500);

//Click on create new
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createNewButton.Click();
Thread.Sleep(1500);

//Input code
IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
codeTextBox.SendKeys("June2022");

//Input description
IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
DescriptionTextbox.SendKeys("June2022");

//Input price tag interactable
IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceTag.Click();

//Input price 
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("20");


//Click on save button 
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

//go to last page button
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
goToLastPageButton.Click();

//Check if the material record has been created successfully
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "June2022")
{
    Console.WriteLine("New material record created successfully.");
}
else
{
    Console.WriteLine("New material record hasn't been created");
}