using UtmBuilder.Domain.ValueObjects;
using UtmBuilder.Domain.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObjects;

[TestClass]
public class UrlTests
{
    private const string InvalidUrl = "banana";
    private const string ValidUrl = "https://balta.io";

    [TestMethod("Deve retornar uma exce��o quando a URL for inv�lida")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldReturnExceptionWhenUrlIsInvalid()
    {
        new Url("InvalidUrl");
    }

    [TestMethod("N�o deve retornar uma exce��o quando a URL for valida")]
    public void ShouldNotReturnExceptionWhenUrlIsValid()
    {
        new Url(ValidUrl);
        Assert.IsTrue(true);
    }

    [TestMethod("Testando URL")]
    [DataRow(" ", true)]
    [DataRow("http ", true)]
    [DataRow("banana ", true)]
    [DataRow("https://balta.io", false)]
    public void TestUrl(string link, bool expectException)
    {
        if(expectException)
        {
            try
            {
                var url = new Url(link);
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }
        else
        {
            new Url(link);
            Assert.IsTrue(true);
        }
    }
}