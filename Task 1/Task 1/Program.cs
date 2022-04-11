using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Xml;
using System.Xml.Serialization;
using Xml2CSharp;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync("https://www.cbar.az/currencies/08.04.2022.xml").Result;
            StringReader stringReader = new StringReader(response);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ValCurs));
            Valute valCurs = (Valute)xmlSerializer.Deserialize(stringReader);
            string Json = JsonConvert.SerializeObject(valCurs);
            StreamWriter Data = new StreamWriter(@"C:\Users\test\source\repos\Task 1\Task 1\Files\main.json");
            Data.Write(Json);
            Data.Close();

        }
    }
}
