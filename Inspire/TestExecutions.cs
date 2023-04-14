namespace Inspire
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Actions.InitializeDriver();
            TestDriver.Driver.Manage().Window.Maximize();
        }

        [TearDown]

        public void TearDowner()
        {
            if(TestDriver.Driver != null)
            {
                TestDriver.Driver.Quit();
            }
        }
        [Test]
        public void Test1()
        {
            TakelotPages  takelot= new TakelotPages();
            takelot.BrandStore.Click();
            takelot.Booklnk.Click();
           takelot.AddToCartbtn.Click();
           takelot.ViewBag.Click();
            takelot.ShppoingCart();
        }

        [Test]
        public void Test2()
        {
            TakelotPages takelot = new TakelotPages();
            takelot.ShppoingCart();
        }
    }
}