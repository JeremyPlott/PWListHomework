using System;
using System.Collections.Generic;

namespace PWListHomework {
    class Program {
        static void Main(string[] args) {

            var PWDict = new Dictionary<string, string>();
            PWDict.Add("YouTube", "password1");
            PWDict.Add("Yahoo", "password2");
            PWDict.Add("gmail", "password3");
            PWDict.Add("GitHub", "password4");
            PWDict.Add("Bank", "password5");
            PWDict.Add("Wikipedia", "password6");
            PWDict.Add("RuneScape", "password7");
            PWDict.Add("BDO", "password8");
            PWDict.Add("Maplestory", "password9");
            PWDict.Add("PassList", "password10");
            PWDict.Add("Car", "password11");
            PWDict.Add("Glasses", "password12");

            foreach(var password in PWDict) {
                Console.WriteLine(password);
            }

        }
    }
}
