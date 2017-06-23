using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses.Hash
{
    public static class SafeKeys
    {

        public static byte[] GetBytes(string data)
        {
            return Encoding.ASCII.GetBytes(data);
        }
        public static string GetString(byte[] bytdata)
        {
            return Encoding.ASCII.GetString(bytdata);
        }

        public static byte[] Sha512(byte[] data)
        {
            SHA512 sha = new SHA512Managed();
            return sha.ComputeHash(data);
        }

        public static byte[] Sha1(byte[] data)
        {
            SHA1 sha = new SHA1Managed();
            return sha.ComputeHash(data);
        }

        public static byte[] Sha256(byte[] data)
        {
            SHA256 sha = new SHA256Managed();
            return sha.ComputeHash(data);
        }

        public static byte[] Sha384(byte[] data)
        {
            SHA384 sha = new SHA384Managed();
            return sha.ComputeHash(data);
        }

        public static string CustomHash(this string data)
        {
            byte[] databyte = GetBytes(data);

            //databyte = Sha1(databyte);
            databyte = Sha256(databyte);
            return GetString(databyte);
        }



    }
}
