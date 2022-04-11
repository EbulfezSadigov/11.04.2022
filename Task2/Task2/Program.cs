using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using Task2.Models;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            string str = httpClient.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;
            List<Posts> posts = JsonConvert.DeserializeObject<List<Posts>>(str);
            foreach (Posts item in posts)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
