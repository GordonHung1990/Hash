using Hash.Library;
using Hash.UnitTest.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hash.UnitTest
{
    /// <summary>
    /// 雜湊 - 簽名 - 助手 - 測試
    /// </summary>
    [TestClass]
    public class HashSignatureHelperTest
    {
        [TestMethod]
        public void Main()
        {
            string secretKey = "!QAZ2wsx#EDC";
            var source = new User()
            {
                Account = "Gordon",
                Password = "123456"
            };
            var dictionarys = DictionaryHelper.ToDictionary(source);
            string data = DictionaryHelper.ToUrlFormEncode(dictionarys);
            string md5 = HashSignatureHelper.MD5Signature(data, secretKey);
            string sha1 = HashSignatureHelper.SHA1Signature(data, secretKey);
            string sha256 = HashSignatureHelper.SHA256Signature(data, secretKey);
            string sha384 = HashSignatureHelper.SHA384Signature(data, secretKey);
            string sha512 = HashSignatureHelper.SHA512Signature(data, secretKey);

            var result = new
            {
                SecretKey = secretKey,
                Data = data,
                MD5 = new
                {
                    Hash = md5,
                    Length = md5.Length
                },
                SHA1 = new
                {
                    Hash = sha1,
                    Length = sha1.Length
                },
                SHA256 = new
                {
                    Hash = sha256,
                    Length = sha256.Length
                },
                SHA384 = new
                {
                    Hash = sha384,
                    Length = sha384.Length
                },
                SHA512 = new
                {
                    Hash = sha512,
                    Length = sha512.Length
                }
            };

            Console.Write(JsonConvert.SerializeObject(result, Formatting.Indented));
        }
    }
}
