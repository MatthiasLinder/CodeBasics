using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Xml_Basics___03._05._2018
{
    class Program
    {
        static void Main(string[] args)
        {

            ////XmlDocument xmldoc = new XmlDocument();
            ////XmlNode rootNode = xmldoc.CreateElement("users");
            ////xmldoc.AppendChild(rootNode);

            ////XmlNode userNode = xmldoc.CreateElement("user");
            ////XmlAttribute attribute = xmldoc.CreateAttribute("age");
            ////attribute.Value = "42";
            ////userNode.Attributes.Append(attribute);
            ////userNode.InnerText = "John Doe";
            ////rootNode.AppendChild(userNode);

            ////userNode = xmldoc.CreateElement("user");
            ////attribute = xmldoc.CreateAttribute("age");
            ////attribute.Value = "39";
            ////userNode.Attributes.Append(attribute);
            ////userNode.InnerText = "Jane Doe";
            ////rootNode.AppendChild(userNode);

            ////xmldoc.Save("test-doc.xml");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load("test-doc.xml");
            //XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            //foreach(XmlNode userNode in userNodes)
            //{
            //    int age = int.Parse(userNode.Attributes["age"].Value);
            //    userNode.Attributes["age"].Value = (age + 1).ToString();
            //}
            //xmlDoc.Save("test-doc.xml");

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ///
            ///XmlSerializer [KIRJUTAMINE]
            ///

            //var Tooteid = new List<Toode>();
            //var toode1 = new Toode() { Nimi = "Banaan", Hind = "3" };
            //var toode2 = new Toode() { Nimi = "Liha", Hind = "6" };
            //var toode3 = new Toode() { Nimi = "Ananass", Hind = "8" };
            //var toode4 = new Toode() { Nimi = "Pirn", Hind = "5" };
            //var toode5 = new Toode() { Nimi = "Granaat", Hind = "30" };

            //Tooteid.Add(toode1);
            //Tooteid.Add(toode2);
            //Tooteid.Add(toode3);
            //Tooteid.Add(toode4);
            //Tooteid.Add(toode5);

            //var serializer = new XmlSerializer(Tooteid.GetType());
            //using (var writer = XmlWriter.Create("tooted.xml"))
            //{
            //    serializer.Serialize(writer, Tooteid);
            //}

            // LUGEMINE //
            var tooted = new List<Toode>();
            var serializer = new XmlSerializer(typeof(List<Toode>));
            using (var reader = XmlReader.Create("tooted.xml"))
            {
                tooted = (List<Toode>)serializer.Deserialize(reader);
            }

            foreach(var toode in tooted)
            {
                Console.WriteLine(toode.Nimi + " " + toode.Hind);
            }

            Console.ReadLine();

        }
    }
}
