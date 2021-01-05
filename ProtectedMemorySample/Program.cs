using System;
using System.Security.Cryptography;
using System.Text;

namespace ProtectedMemorySample
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = "####Code4Sec####";
            Console.WriteLine("Original data: {0}",data);
            // Create the original data to be encrypted (The data length should be a multiple of 16).
            byte[] secret = Encoding.UTF8.GetBytes(data);
            Console.WriteLine("Before Protect: {0}", BitConverter.ToString(secret));          

            // Encrypt the data in memory. The result is stored in the same array as the original data.
            ProtectedMemory.Protect(secret, MemoryProtectionScope.SameLogon);
            Console.WriteLine("Protect: {0}", BitConverter.ToString(secret));

            // Decrypt the data in memory and store in the original array.
            ProtectedMemory.Unprotect(secret, MemoryProtectionScope.SameLogon);
            Console.WriteLine("Unprotect: {0}", BitConverter.ToString(secret));

            Console.ReadLine();
        }
    }
}
