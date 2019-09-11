using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Md5String
    {

        public static string Md5CreateName(Stream stream) {

            MD5 md5 = MD5.Create();
            byte[] btyes=  md5.ComputeHash(stream);
            StringBuilder sb = new StringBuilder();
            foreach (byte item in btyes)
            {
               sb.Append(item.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
