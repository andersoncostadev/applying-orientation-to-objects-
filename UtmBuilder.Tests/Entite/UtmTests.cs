using UtmBuilder.Domain.Entities;
using UtmBuilder.Domain.ValueObjects;

namespace UtmBuilder.Tests.Entite
{
    [TestClass]
    public class UtmTests
    {
         private readonly Url _url = new ("https://balta.io/");
         private readonly Campaign _campaign = new ("src", "medium", "name", "id", "term", "content");

         private const string Result = "https://balta.io/" +
                "?utm_source=src" +
                "&utm_medium=medium" +
                "&utm_campaign=name" +
                "&utm_id=id" +
                "&utm_term=term" +
                "&utm_content=content";

        [TestMethod("Deve retornar URL do Utm")]
        public void ShouldReturnUrlFromUtm()
        {
            var utm = new Utm(_url, _campaign);

            Assert.AreEqual(Result, utm.ToString());
            Assert.AreEqual(Result, (string)utm);
        }

        [TestMethod("Deve retornar Utm do URL")]
        public void ShouldReturnUtmFromUrl()
        {
            Utm utm = Result;
            Assert.AreEqual("https://balta.io/", utm.Url.Address);
            Assert.AreEqual("src", utm.Campaign.Source);
            Assert.AreEqual("medium", utm.Campaign.Medium);
            Assert.AreEqual("name", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("term", utm.Campaign.Term);
            Assert.AreEqual("content", utm.Campaign.Content);
        }

    }
}
