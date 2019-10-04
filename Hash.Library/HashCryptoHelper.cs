using System;
using System.Security.Cryptography;
using System.Text;

namespace Hash.Library
{
    /// <summary>
    /// 雜湊 - 加密 - 助手
    /// </summary>
    public class HashCryptoHelper
    {
        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <returns>回傳雜湊</returns>
        public static string MD5(byte[] data)
        {
            MD5 cryptoService = new MD5CryptoServiceProvider();
            return HexStringFromBytes(cryptoService.ComputeHash(data));
        }

        /// <summary>
        /// MD5
        /// </summary>
        /// <param name="data">數據</param>
        /// <returns>回傳雜湊</returns>
        public static string MD5(string data)
        {
            return MD5(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// SHA1
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA1(byte[] data)
        {
            SHA1 cryptoService = new SHA1CryptoServiceProvider();
            return HexStringFromBytes(cryptoService.ComputeHash(data));
        }

        /// <summary>
        /// SHA1
        /// </summary>
        /// <param name="data">數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA1(string data)
        {
            return SHA1(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// SHA256
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA256(byte[] data)
        {
            SHA256 cryptoService = new SHA256CryptoServiceProvider();
            return HexStringFromBytes(cryptoService.ComputeHash(data));
        }

        /// <summary>
        /// SHA256
        /// </summary>
        /// <param name="data">數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA256(string data)
        {
            return SHA256(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// SHA384
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA384(byte[] data)
        {
            SHA384 cryptoService = new SHA384CryptoServiceProvider();
            return HexStringFromBytes(cryptoService.ComputeHash(data));
        }

        /// <summary>
        /// SHA384
        /// </summary>
        /// <param name="data">數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA384(string data)
        {
            return SHA384(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// SHA512
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA512(byte[] data)
        {
            SHA512 cryptoService = new SHA512CryptoServiceProvider();
            return HexStringFromBytes(cryptoService.ComputeHash(data));
        }

        /// <summary>
        /// SHA512
        /// </summary>
        /// <param name="data">數據</param>
        /// <returns>回傳雜湊</returns>
        public static string SHA512(string data)
        {
            return SHA512(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// 將字節數組轉換為十六進制數字字符串
        /// </summary>
        /// <param name="bytes">array of bytes</param>
        /// <returns>String of hex digits</returns>
        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
    }
}
