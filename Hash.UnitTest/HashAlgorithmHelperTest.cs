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
    /// 雜湊 - Algorithm - 助手 - 測試
    /// </summary>
    [TestClass]
    public class HashAlgorithmHelperTest
    {
        [TestMethod]
        public void Main()
        {
            var source = new User()
            {
                Account = "Gordon",
                Password = "123456"
            };
            var dictionarys = DictionaryHelper.ToDictionary(source);
            string data = DictionaryHelper.ToUrlFormEncode(dictionarys);
            string md5 = HashAlgorithmHelper.MD5(data);
            string sha1 = HashAlgorithmHelper.SHA1(data);
            string sha256 = HashAlgorithmHelper.SHA256(data);
            string sha384 = HashAlgorithmHelper.SHA384(data);
            string sha512 = HashAlgorithmHelper.SHA512(data);

            var result = new
            {
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
