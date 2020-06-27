namespace ISoftData.Controllers.Helps
{
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Xml.Serialization;

    public static class XMLHelps
    {
        public static void SaveXML<ObjectType>(ObjectType clientes, string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite);
            using (var sw = new StreamWriter(fs))
            {
                new XmlSerializer(typeof(ObjectType)).Serialize(sw, clientes);
            }
        }
        public static string RemoveTypeTagFromXml(string xml)
        {
            if (!string.IsNullOrEmpty(xml) && xml.Contains("xsi:type"))
            {
                xml = Regex.Replace(xml, @"\s+xsi:type=""\w+""", "");
            }
            return xml;
        }
        public static ObjectType ReadXML<ObjectType>(string FileName)
        {
            FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            using (var sw = new StreamReader(fs))
            {
                return (ObjectType)new XmlSerializer(typeof(ObjectType)).Deserialize(sw);
            }
        }
        public static string SaveXMLSting<ObjectType>(ObjectType obj, string FileName)
        {
            using (var sw = new StringWriter())
            {
                new XmlSerializer(typeof(ObjectType)).Serialize(sw, obj);
                return sw.ToString();
            }
        }
        public static ObjectType ReadXMLString<ObjectType>(string FileName)
        {
            using (var sw = new StringReader(FileName))
            {
                return (ObjectType)new XmlSerializer(typeof(ObjectType)).Deserialize(sw);
            }
        }
    }
}
