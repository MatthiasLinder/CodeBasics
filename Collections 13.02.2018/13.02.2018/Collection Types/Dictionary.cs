using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2018.Collection_Types
{
    class Dictionary
    {

        public void Dictionaries()
        {
            #region Dictionary
            //Dictionary
            var OpenWith = new Dictionary<string, string>();

            //            Key    Value
            OpenWith.Add("txt", "notepad.exe");
            OpenWith.Add("bmp", "paint.exe");
            OpenWith.Add("jpeg", "paint.exe");
            OpenWith.Add("rtf", "wordpad.exe");

            OpenWith["rtf"] = "winword.exe";
            OpenWith["doc"] = "winword.exe";

            Console.WriteLine("For key = rtf, value = {0}", OpenWith["rtf"]);

            try
            {
                OpenWith.Add("txt", "word.exe");
            }
            catch (ArgumentException ex)
            {
                //Console.WriteLine(ex);
                Console.WriteLine("An element with key \"txt\" already exists.");
            }

            try
            {
                Console.WriteLine("For key = tif, value = {0}", OpenWith["tif"]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key \"Tif\" is not found.");
            }

            string value = "";
            if (OpenWith.TryGetValue("tif", out value))
            {
                Console.WriteLine("For key = \"tif\", value = {0}", value);
            }
            else
            {
                Console.WriteLine("For key = \"tif\" is not found.");
            }

            if (!OpenWith.ContainsKey("ht"))
            {
                OpenWith.Add("ht", "hypeterm.exe");
                Console.WriteLine("Value added for key ht: {0}", OpenWith["ht"]);
            }

            //Getting KEYS and VALUES by using ForEach cycle.
            foreach (KeyValuePair<string, string> kvp in OpenWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            //Getting VALUES
            Dictionary<string, string>.ValueCollection valueCollection = OpenWith.Values;
            foreach (string item in valueCollection)
            {
                Console.WriteLine("Value = {0}", item);
            }

            //Getting KEYS
            Dictionary<string, string>.KeyCollection keyCollection = OpenWith.Keys;
            foreach (var item in keyCollection)
            {
                Console.WriteLine("Key = {0}", item);
            }

            //Delete key/value
            OpenWith.Remove("doc");
            if (!OpenWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found");
            }

            #endregion
        }
    }
}
