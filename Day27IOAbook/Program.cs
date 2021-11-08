using System;

namespace Day27IOAbook
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("\n# Read data from Address txt & Write data in export txt\n");
           TxtHandler.ImplementtxtDataHandling();
           ReadTXT_And_WriteJTXT.ImplementTxtTotxt();

            Console.ReadKey();
        }
    }
}
