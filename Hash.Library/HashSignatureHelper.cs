using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Hash.Library
{
    /// <summary>
    /// 雜湊 - 簽名 - 助手
    /// </summary>
    public class HashSignatureHelper
    {
        /// <summary>
        /// MD5 -加密簽名
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string MD5Signature(byte[] data, string secretKey, bool isHex = false)
        {
            HMACMD5 hmac = new HMACMD5(Encoding.UTF8.GetBytes(secretKey));
            byte[] digest = hmac.ComputeHash(data);
            byte[] signature = hmac.ComputeHash(data);
            if (!isHex)
            {
                return Convert.ToBase64String(signature);
            }
            else
            {
                return HexStringFromBytes(signature);
            }
        }

        /// <summary>
        /// MD5 -加密簽名
        /// </summary>
        /// <param name="data">數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string MD5Signature(string data, string secretKey, bool isHex = false)
        {
            return MD5Signature(Encoding.UTF8.GetBytes(data), secretKey, isHex);
        }

        /// <summary>
        /// SHA1 -加密簽名
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA1Signature(byte[] data, string secretKey, bool isHex = false)
        {
            HMACSHA1 hmac = new HMACSHA1(Encoding.UTF8.GetBytes(secretKey));
            byte[] digest = hmac.ComputeHash(data);
            byte[] signature = hmac.ComputeHash(data);
            if (!isHex)
            {
                return Convert.ToBase64String(signature);
            }
            else
            {
                return HexStringFromBytes(signature);
            }
        }

        /// <summary>
        /// SHA1 -加密簽名
        /// </summary>
        /// <param name="data">數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA1Signature(string data, string secretKey, bool isHex = false)
        {
            return SHA1Signature(Encoding.UTF8.GetBytes(data), secretKey, isHex);
        }

        /// <summary>
        /// SHA256 -加密簽名
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA256Signature(byte[] data, string secretKey, bool isHex = false)
        {
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey));
            byte[] digest = hmac.ComputeHash(data);
            byte[] signature = hmac.ComputeHash(data);
            if (!isHex)
            {
                return Convert.ToBase64String(signature);
            }
            else
            {
                return HexStringFromBytes(signature);
            }
        }

        /// <summary>
        /// SHA256 -加密簽名
        /// </summary>
        /// <param name="data">數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA256Signature(string data, string secretKey, bool isHex = false)
        {
            return SHA256Signature(Encoding.UTF8.GetBytes(data), secretKey, isHex);
        }

        /// <summary>
        /// SHA384 -加密簽名
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA384Signature(byte[] data, string secretKey, bool isHex = false)
        {
            HMACSHA384 hmac = new HMACSHA384(Encoding.UTF8.GetBytes(secretKey));
            byte[] digest = hmac.ComputeHash(data);
            byte[] signature = hmac.ComputeHash(data);
            if (!isHex)
            {
                return Convert.ToBase64String(signature);
            }
            else
            {
                return HexStringFromBytes(signature);
            }
        }

        /// <summary>
        /// SHA384 -加密簽名
        /// </summary>
        /// <param name="data">數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA384Signature(string data, string secretKey, bool isHex = false)
        {
            return SHA384Signature(Encoding.UTF8.GetBytes(data), secretKey, isHex);
        }

        /// <summary>
        /// SHA512 -加密簽名
        /// </summary>
        /// <param name="data">字節數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA512Signature(byte[] data, string secretKey, bool isHex = false)
        {
            HMACSHA512 hmac = new HMACSHA512(Encoding.UTF8.GetBytes(secretKey));
            byte[] digest = hmac.ComputeHash(data);
            byte[] signature = hmac.ComputeHash(data);
            if (!isHex)
            {
                return Convert.ToBase64String(signature);
            }
            else
            {
                return HexStringFromBytes(signature);
            }
        }

        /// <summary>
        /// SHA512 -加密簽名
        /// </summary>
        /// <param name="data">數據</param>
        /// <param name="secretKey">金鑰</param>
        /// <param name="isHex">輸出轉16進制，預設:false</param>
        /// <returns>回傳簽名</returns>
        public static string SHA512Signature(string data, string secretKey, bool isHex = false)
        {
            return SHA512Signature(Encoding.UTF8.GetBytes(data), secretKey, isHex);
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
