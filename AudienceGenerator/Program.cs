using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AudienceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientId = Guid.NewGuid().ToString("N");

            var key = new byte[32];
            RNGCryptoServiceProvider.Create().GetBytes(key);
            var base64Secret = System.Convert.ToBase64String(key);


            Console.WriteLine($"Id: {clientId}");
            Console.WriteLine($"Secret: {base64Secret}");
            Console.ReadLine();
        }

     
    }
}
