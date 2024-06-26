﻿using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace EStore.Extension
{
    public static class HashMD5
    {
        public static string ToMD5(this string str)
        {
            {
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

                byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
                StringBuilder sbHash = new StringBuilder();
                foreach (byte b in bHash)
                {
                    sbHash.Append(b.ToString("X2"));
                }
                return sbHash.ToString();
            }
        }

    }
}
