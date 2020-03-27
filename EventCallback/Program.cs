using System;
using System.Collections.Generic;

namespace EventCallback
{
    class Program
    {
        static void Main(string[] args)
        {
            StringSearcher entitySearcher = new StringSearcher(@"\d+");

            entitySearcher.Request += OnEntitySearcherRequest;
            entitySearcher.Request += OnEntitySearcherRequest2;

            var searchList = new List<string> {"Вася", "Петя", "45", "95", "Собака", "33" };
            entitySearcher.Search(searchList);

            Console.Read();
        }

        private static void OnEntitySearcherRequest(object sender, StringSearcherArgs e)
        {
            Console.WriteLine(e.FoundEntity);
            if (e.FoundEntity == "95")
                e.CancelRequest = true;
        }

        private static void OnEntitySearcherRequest2(object sender, StringSearcherArgs e)
        {
            Console.WriteLine(e.FoundEntity);
            //e.CancelRequest = true;
        }
    }
}
