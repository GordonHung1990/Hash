using System;
using System.Collections.Generic;
using System.Text;

namespace Hash.Library
{
    /// <summary>
    /// 密碼編譯雜湊演算法 - 類型
    /// 代表基底類別，密碼編譯雜湊演算法的所有實作必須從它衍生。
    /// </summary>
    public enum HashAlgorithmType
    {
        KeyedHashAlgorithm,
        MD5,
        RIPEMD160,
        SHA1,
        SHA256,
        SHA384,
        SHA512
    }
}
