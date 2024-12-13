using System;
using System.Security.Cryptography;
using System.Text;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hash:");

        string sSourceData_1;
        string sSourceData_2;

        byte[] tmpSource_1;
        byte[] tmpSource_2;

        byte[] tmpHash_1;
        byte[] tmpHash_2;

        sSourceData_1 = "Hello";
        sSourceData_2 = "Hello1";

        tmpSource_1 = ASCIIEncoding.ASCII.GetBytes(sSourceData_1);
        tmpSource_2 = ASCIIEncoding.ASCII.GetBytes(sSourceData_2);

        tmpHash_1 = new MDSCryptoserviceProvider().ComputeHash(tmpsource_1);
        tmpHash_2 = new MD5CryptoserviceProvider().ComputeHash(tmpsource_2);

        int count = 0;
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                Console.WriteLine($"{ByteArrayToString(tmpHash_1)}");
                Console.WriteLine($"Word: {sSourceData_1}");
            }
            if (i == 1)
            {
                Console.WriteLine($"{ByteArrayTostring(tmpHash_2)}");
                Console.WriteLine($"Word: {sSourceData_2}");
            }

            //Console. WriteLine(ByteArrayTostring(tmpHash_1));
            static string ByteArrayTostring(byte[] arrInput)
            {
                int i; 
                StringBuilder sOutput = new StringBuilder(arrInput.Length);
                for (i = 0; i < arrInput.Length; i++)
                    sOutput.Append(arrInput[i].Tostring("X2"));
                return sOutput.ToString();
            }
        }
    }
}