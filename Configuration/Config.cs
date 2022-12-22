using System.Xml.Serialization;

namespace TabbyViewer.Configuration
{
    public class Config
    {
        public string Url { get; set; }
        public string Token { get; set; }
        public string TournamentSlug { get; set; }
        public string FormsCSVPath { get; set; }
    }
    public class ImportConfig
    {
        public static Config FromFile(string path = "./Configuration/config.xml")
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (StreamReader reader = new StreamReader(path))
                {
                    return (Config)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public static Config FromString(string xml)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (StringReader reader = new StringReader(xml))
                {
                    return (Config)serializer.Deserialize(reader);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    } 
}
