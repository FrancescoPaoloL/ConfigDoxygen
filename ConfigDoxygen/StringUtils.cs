///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          StringUtils
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------
///

using System;
using System.Linq;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains some useful utilities about String objects
    /// </summary>
    public static class StringUtils {

        /// <summary>
        /// This method provides a simple and human readable output about object size.
        /// 1 KB, 3 MB, 2 TB and so on...
        /// </summary>
        /// <param name="byteCount"></param>
        /// <returns></returns>
        public static String BytesToString(Int64 byteCount) {
            String[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            Int64 bytes = Math.Abs(byteCount);
            Int32 place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            Double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }

        /// <summary>
        /// This method permits to create a string array by a min and max input.
        /// </summary>
        /// <param name="min">Represents the minimun value.</param>
        /// <param name="max">Represents the maximun value.</param>
        /// <returns></returns>
        public static String[] GetArrayStringValuesByRange(Int32 min, Int32 max) {
            Int32[] x = Enumerable.Range(min, max).ToArray();
            String[] s = new String[x.Length];
            for (Int32 i = 0; i < x.Length; i++) {
                s[i] = x[i].ToString();
            }

            return s;
        }
    }

    /// <summary>
    /// This class extends some string functionality, copying
    /// some old-fashioned vb6 or vb.net methods on string object like Left(), Right() and Mid().
    /// </summary>
    public static class StringExtensions {
        /// <summary>
        /// This method get a string object, STARTING LEFT, by defining a value and a max lenght.
        /// </summary>
        /// <param name="value">Represents a String where extrapolate a substring.</param>
        /// <param name="maxLength">Represents a numeric by which we can define a substring search limit.</param>
        /// <returns>Returns a string object.</returns>
        public static String Left(this String value, Int32 maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            maxLength = Math.Abs(maxLength);

            return (value.Length <= maxLength ? value : value.Substring(0, maxLength));
        }

        /// <summary>
        /// This method get a string object, STARTING RIGHT, by defining a value and a max lenght.
        /// </summary>
        /// <param name="value">Represents a String where extrapolate a substring.</param>
        /// <param name="maxLength">Represents a numeric by which we can define a substring search limit.</param>
        /// <returns>Returns a string object.</returns>
        public static String Right(this String value, Int32 length) {
            if (String.IsNullOrEmpty(value)) return string.Empty;

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        /// <summary>
        /// This method get a string object, STARTING IN THE MIDDLE, by defining a value and an interval of.
        /// </summary>
        /// <param name="s">Represents a String where extrapolate a substring.</param>
        /// <param name="a">Represents a numeric by which we can define a START search substring.</param>
        /// <param name="b">Represents a numeric by which we can define a STOP search substring.</param>
        /// <returns>Returns a string object.</param>
        public static String Mid(String s, Int32 a, Int32 b) {
            String temp = s.Substring(a - 1, b);
            return temp;
        }
    }

}
