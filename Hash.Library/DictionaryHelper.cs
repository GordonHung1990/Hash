using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Hash.Library
{
    /// <summary>
    /// Dictionary 助手
    /// </summary>
    public static class DictionaryHelper
    {
        /// <summary>
        /// 物件轉換成Dictionary
        /// </summary>
        /// <param name="values">鍵值對</param>
        /// <returns>Dictionary</returns>
        public static IDictionary<string, string> ToDictionary(this object values)
        {
            if (values == null) ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, string>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(values))
            {
                object value = property.GetValue(values);
                if (value != null)
                {
                    if (!string.IsNullOrEmpty(value.ToString()))
                    {
                        dictionary.Add(property.Name, value.ToString());
                    }
                }
            }
            return dictionary;
        }
        /// <summary>
        /// 物件轉換成Dictionary
        /// </summary>
        /// <param name="values">鍵值對</param>
        /// <returns>Dictionary</returns>
        public static IDictionary<string, T> ToDictionary<T>(this object values)
        {
            if (values == null) ThrowExceptionWhenSourceArgumentIsNull();

            var dictionary = new Dictionary<string, T>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(values))
            {
                object value = property.GetValue(values);
                if (IsOfType<T>(value))
                {
                    dictionary.Add(property.Name, (T)value);
                }
            }
            return dictionary;
        }
        /// <summary>
        /// URL鍵值對編碼
        /// </summary>
        /// <param name="values">鍵值對</param>
        /// <returns>URL編碼的鍵值對數據</returns>
        public static string ToUrlFormEncode(IDictionary<string, string> values)
        {
            StringBuilder urlValuesBuilder = new StringBuilder();

            foreach (KeyValuePair<string, string> kvp in values)
            {
                urlValuesBuilder.AppendFormat("{0}={1}&", Uri.EscapeDataString(kvp.Key), Uri.EscapeDataString(kvp.Value));
            }
            string encodedStr = urlValuesBuilder.ToString();
            return encodedStr.Substring(0, encodedStr.Length - 1);
        }
        /// <summary>
        /// URL鍵值對編碼
        /// </summary>
        /// <param name="values">鍵值對</param>
        /// <returns>URL編碼的鍵值對數據</returns>
        public static string ToUrlFormEncode(Dictionary<string, string> values)
        {
            StringBuilder urlValuesBuilder = new StringBuilder();

            foreach (KeyValuePair<string, string> kvp in values)
            {
                urlValuesBuilder.AppendFormat("{0}={1}&", Uri.EscapeDataString(kvp.Key), Uri.EscapeDataString(kvp.Value));
            }
            string encodedStr = urlValuesBuilder.ToString();
            return encodedStr.Substring(0, encodedStr.Length - 1);
        }

        private static bool IsOfType<T>(object value)
        {
            return value is T;
        }

        private static void ThrowExceptionWhenSourceArgumentIsNull()
        {
            throw new NullReferenceException("Unable to convert anonymous object to a dictionary. The values anonymous object is null.");
        }
    }
}
