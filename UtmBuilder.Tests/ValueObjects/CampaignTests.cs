using UtmBuilder.Domain.ValueObjects;
using UtmBuilder.Domain.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("src", "", "", true)]
        [DataRow("src", "medium", "", true)]
        [DataRow("src", "medium", "name", false)]
        public void TestCampaing(string source, string medium, string name, bool expectException)
        {
            if(expectException)
            {
                try
                {
                    new Campaign(source, medium, name);
                    Assert.Fail();
                }
                catch (InvalidCampaignException ex)
                    when(ex.Message == "source is invalid" || ex.Message == "medium is invalid" || ex.Message == "name is invalid")

                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
        

    }
}
