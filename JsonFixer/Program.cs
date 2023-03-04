using Newtonsoft.Json;
using System.Runtime;
using static System.Net.Mime.MediaTypeNames;

namespace JsonFixer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter bad ID:");
            string id = Console.ReadLine();
            string path = System.AppDomain.CurrentDomain.BaseDirectory + "Vault";
            List<string> fileEntries = Directory.GetFiles(path).ToList();
            foreach(string fileEntry in fileEntries)
            {
                string json = File.ReadAllText(fileEntry);
                ValutFile valutFile = JsonConvert.DeserializeObject<ValutFile>(json); 
                // Loop through all objects
                foreach(ValutFile.Object o in valutFile.Objects)
                {
                    int index = 0;
                    // Loop through all elements
                    List<ValutFile.Element> elements = new List<ValutFile.Element>();
                    foreach(ValutFile.Element element in o.Elements)
                    {
                        if (element.ObjectID != id)
                        {
                            element.Index = index;
                            elements.Add(element);
                            index++;
                        }
                    }
                    o.Elements = elements;
                }
                string fileName = fileEntry.Replace(".json","FIXED.json");
                string jsonFixed = JsonConvert.SerializeObject(valutFile, Formatting.Indented);
                File.WriteAllText(fileName, jsonFixed);
            }
        }
    }
}