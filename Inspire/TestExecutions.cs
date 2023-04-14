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
            takelot.TestAddViewProduct();

        }

      
    }
}