namespace UtmBuilder.Domain.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string DefaultErrorMEssage = "Invalid UTM parameters";
        public InvalidCampaignException(string message = DefaultErrorMEssage) : base(message) { }

        public static void TrowIfNull(string? item, string message = DefaultErrorMEssage)
        {
            if (string.IsNullOrWhiteSpace(item))
                throw new InvalidCampaignException(message);
        }
    }
}
