using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;


namespace Day27IOAbook
{
    class ReadTXT_And_WriteJTXT
    {
        public static void ImplementTxtTotxt()
        {
            string importFilePath = @"C:\Users\Userr\source\repos\Day27IOAbook\Day27IOAbook\Utility\Address.txt";
            string exportFilePath = @"C:\Users\Userr\source\repos\Day27IOAbook\Day27IOAbook\Utility\export2.txt";
            using (var reader = new StreamReader(importFilePath))
            using (var txt = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = txt.GetRecords<AddressData>().ToList();
                Console.WriteLine("\nRead data successfully from addresses txt.\n");
                foreach (AddressData addressData in records)
                {
                    /*Console.Write("\t" + addressData.firstname);
                    Console.Write("\t" + addressData.lastname);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.code);*/

                     Console.Write("\n\t" + addressData.firstname + "|" +
                     addressData.lastname + "|" +
                     addressData.address + "|" +
                     addressData.city + "|" +
                     addressData.state + "|" +
                     addressData.code+"\n");


                }
                Console.WriteLine("\nReading from txt file and Write to txt file\n");

                //Writing txt file

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }

            }
        }
    }

}
