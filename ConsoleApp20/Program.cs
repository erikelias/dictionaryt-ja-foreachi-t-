using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        Dictionary<int, string> koolid = new Dictionary<int, string>();
        koolid.Add(1, "Tallinna Reaalkool");
        koolid.Add(2, "Tartu Ülikooli Loodus- ja Tehnoloogiateaduskond");
        koolid.Add(3, "Narva Kesklinna Gümnaasium");

        
        Console.WriteLine("Koolid:");
        foreach (KeyValuePair<int, string> kvp in koolid)
        {
            Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        }

       
        Console.WriteLine("Vajuta suvalist klahvi, et programm lõpetaks töö...");
        Console.ReadKey();
    }
}
