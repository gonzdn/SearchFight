using System.Web.Script.Serialization;

namespace FTN_Common.Helpers
{
    public static class JsonHelper
    {
        public static T Deserialize<T>(string json)
        {
            var deserializer = new JavaScriptSerializer();
            return deserializer.Deserialize<T>(json);
        }
    }
}