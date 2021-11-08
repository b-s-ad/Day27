using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Day27IOAbook
{
    class TxtHandler
    {
        public static void ImplementtxtDataHandling()
        {
            string importFilePath = @"C:\Users\Userr\source\repos\Day27IOAbook\Day27IOAbook\Utility\Address.txt";
            string exportFilePath = @"C:\Users\Userr\source\repos\Day27IOAbook\Day27IOAbook\Utility\export.txt";

            //reading txt file
            using (var reader = new StreamReader(importFilePath))
            using (var txt = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = txt.GetRecords<AddressData>().ToList();
                Console.WriteLine("\nRead data successfully from addresses txt.\n");
                foreach (AddressData addressData in records)
                {
                     Console.Write("\n\t" + addressData.firstname +"|"+
                     addressData.lastname + "|" +
                     addressData.address + "|" +
                     addressData.city + "|" +
                     addressData.state + "|" +
                     addressData.code + "\n");

                    Console.WriteLine("\nReading from txt file and Write to txt file \n");
                    //Writing txt file

                    using (var writer = new StreamWriter(exportFilePath))
                    using (var txtExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        txtExport.WriteRecords(records);
                    }
                }
            }
        }


    }

}
