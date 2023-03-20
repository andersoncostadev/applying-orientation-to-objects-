using UtmBuilder.Domain.ValueObjects.Exceptions;

namespace UtmBuilder.Domain.ValueObjects
{
    public class Url : IValueObjects
    {
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address"> Adress of URL (Website link)</param>
    public Url(string address)
    {
       Address = address;
       InvalidUrlException.ThrowIfInvalid(address);
    }

        /// <summary>
        /// Adress of URL (Website link)
        /// </summary>
        public string Address { get; } // como não queremos que a url seja alterada então deixamos sem o set assim o adsress fica privado.
    }
}
