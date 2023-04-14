using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Inspire
{
    public class TakelotPages : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Brands Store')]")]
        public IWebElement BrandStore { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@class='list-nav-item  context-nav-link'][contains(.,'Books')]")]
        public IWebElement Booklnk { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[@class='cell small-3'])[1]")]
        public IWebElement Bookmark { get; set; }


        [FindsBy(How = How.XPath, Using = "(//button[contains(.,'Add to Cart')])[1]")]
        public IWebElement AddToCartbtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"shopfront-app\"]/div[2]/div/div/div[2]/div/div[2]/div/div/div/div/button")]
        public IWebElement ViewBag { get; set; }

        [FindsBy(How = How.XPath, Using = "(//span[@class='currency plus currency-module_currency_29IIm'])[2]")]
        public IWebElement ViewCart { get; set; }

        public static string ShoppingCart = "R 399";
        public TakelotPages ShppoingCart()
        {
            Assert.AreEqual(ViewCart.Text, ShoppingCart);
            return this;

        }

        public void TestAddViewProduct()
        {
            BrandStore.Click();
            Booklnk.Click();
            AddToCartbtn.Click();
            ViewBag.Click();
            ShppoingCart();
        }
    }
}
