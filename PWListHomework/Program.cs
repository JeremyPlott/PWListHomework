using System;
using System.Collections.Generic;

namespace PWListHomework {
    class Program {
        static void Main(string[] args) {

            var PWDict = new Dictionary<string, string>(); //dictionary is good collection tool when you don't want to allow duplicates. Cannot duplicate Key values.
            PWDict.Add("YouTube.com", "password1");
            PWDict.Add("Yahoo.com", "password2");
            PWDict.Add("gmail.com", "password3");
            PWDict.Add("GitHub.com", "password4");
            PWDict.Add("Bank.com", "password5");
            PWDict.Add("Wikipedia.org", "password6");
            PWDict.Add("RuneScape.com", "password7");
            PWDict.Add("BDO.com", "password8");
            PWDict.Add("Maplestory.com", "password9");
            PWDict.Add("PassList.gov", "password10");
            PWDict.Add("Car.com", "password11");
            PWDict.Add("Glasses.net", "password12");

            var password = PWDict["Maplestory.com"];
            Console.WriteLine($"The password for Maplestory.com is {password}");

            foreach(var keyValpair in PWDict) {                          //keyvalpair has both the key and value added in the dictionary.
                Console.WriteLine($"The password for {keyValpair.Key} is {keyValpair.Value}");
            }

            var allkeys = PWDict.Keys;
            var allvalues = PWDict.Values;
            var exists = PWDict.ContainsKey("Bank.com");
        }
    }
}
