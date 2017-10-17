using Newtonsoft.Json.Linq;

namespace PocMultipleEntities.Poco
{
    public class EnviromentalSettingsViewModel : JObject
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
