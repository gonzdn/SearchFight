namespace FNT_Contracts
{
    public class BingContract : ConfigContract
    {
        public static string Url => Configuration("BingUrl");
        public static string ApiKey => Configuration("BingKey");
    }
}
