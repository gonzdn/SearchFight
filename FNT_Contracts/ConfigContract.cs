using System.Configuration;

namespace FNT_Contracts
{
    public class ConfigContract
    {        
        public static string Configuration(string key)
        {
            string value = ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(value))
                throw new ConfigurationErrorsException(string.Format("Missing key: {0}", key));
            else
                return value;
        }
    }
}
