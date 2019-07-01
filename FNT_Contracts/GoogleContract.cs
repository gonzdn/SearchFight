namespace FNT_Contracts
{
    public class GoogleContract : ConfigContract
    {
        public static string Url = Configuration("GoogleUrl");        
        public static string ContextId = Configuration("GoogleContext");
        public static string Key = Configuration("GoogleKey");
    }
}
