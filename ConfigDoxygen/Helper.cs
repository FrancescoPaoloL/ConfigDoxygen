/*
ConfigDoxyGen - An humble GUI front-end for editing configure doxygen files.
Copyright (c) 2019 Francesco Paolo Lezza (francescoprogrammer.com)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains some useful utilities for general purpose
    /// </summary>
    public static class Helper {
        /// <summary>
        /// This static method displays the assembly build date
        /// 
        /// see: https://stackoverflow.com/questions/1600962/displaying-the-build-date
        /// 
        /// IMPORTANT!  
        /// The method was working for .Net Core 1.0, but stopped working after .Net Core 1.1 release 
        /// (gives random years in 1900-2020 range) 
        /// </summary>
        /// <param name="assembly">Represents an Assembly object</param>
        /// <param name="target">Represents the local time zone.</param>
        /// <returns></returns>
        public static DateTime GetLinkerTime(this Assembly assembly, TimeZoneInfo target = null) {
            var filePath = assembly.Location;
            const int c_PeHeaderOffset = 60;
            const int c_LinkerTimestampOffset = 8;

            var buffer = new byte[2048];

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                stream.Read(buffer, 0, 2048);

            var offset = BitConverter.ToInt32(buffer, c_PeHeaderOffset);
            var secondsSince1970 = BitConverter.ToInt32(buffer, offset + c_LinkerTimestampOffset);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var linkTimeUtc = epoch.AddSeconds(secondsSince1970);

            var tz = target ?? TimeZoneInfo.Local;
            var localTime = TimeZoneInfo.ConvertTimeFromUtc(linkTimeUtc, tz);

            return localTime;
        }


        /// <summary>
        /// This method takes a dictionary parameter and copy key/value pairs
        /// (value is a DefinitionTag object)
        /// </summary>
        /// <param name="original">It Represents the dicionary we want to clone</param>
        /// <returns>Returns a new copied dictionary</returns>
        public static Dictionary<String, DefinitionTag> CopyDictionary(Dictionary<String, DefinitionTag> original) {
            Dictionary<String, DefinitionTag> ret = new Dictionary<String, DefinitionTag>();
            foreach (KeyValuePair<String, DefinitionTag> entry in original) {
                DefinitionTag dd = new DefinitionTag();
                dd = entry.Value;
                ret.Add(entry.Key, dd);
            }
            return ret;
        }


        /// <summary>
        /// NOT USED!
        /// 
        /// This method list all project resources
        /// (from https://stackoverflow.com/questions/3314140/how-to-read-embedded-resource-text-file)
        /// </summary>
        /// <param name="resourceName">Represents a resouce name file</param>
        /// <returns></returns>
        public static String GetTextResource(String resourceName) {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream)) {
                    string result = reader.ReadToEnd();
                    return result;
                }
        }

        /// <summary>
        /// NOT USED!
        /// 
        /// This method get all resource name (sic!)
        /// </summary>
        /// <returns>Returns an array of strings</returns>
        public static String[] GetAllResourceName() {
            return Assembly.GetExecutingAssembly().GetManifestResourceNames(); ;
        }

        /// <summary>
        /// NOT USED!
        /// 
        /// This method get an objecy and returns all its properties
        /// into a DataTable
        /// </summary>
        /// <returns>Returns a DatgaTable of object properties.</returns>
        public static DataTable ObjectToData(Object objValue) {
            DataTable dt = new DataTable("OutputData");

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            objValue.GetType().GetProperties().ToList().ForEach(f => {
                try {
                    f.GetValue(objValue, null);
                    dt.Columns.Add(f.Name, f.PropertyType);
                    dt.Rows[0][f.Name] = f.GetValue(objValue, null);
                } catch (Exception Ex) {
                    //MessageBox.Show(Ex.Message, "Exception!", MessageBoxButtons.OK,
                    //                      MessageBoxIcon.Information,
                    //                      MessageBoxDefaultButton.Button1,
                    //                      MessageBoxOptions.RtlReading);
                    MessageBox.Show(Ex.Message);
                }
            });
            return dt;
        }

        /// <summary>
        /// This method iterate over the first lines of configuration file
        /// and returns the first row readable index.
        /// </summary>
        /// <param name="allText">Represents an array of strings</param>
        /// <returns>Returns an int which represent the first row readable index</returns>
        public static Int32 getFirstRowReadable(String[] allText) {
            String crtlS = "# This tag specifies the encoding used for all characters in the configuration";
            Int32 i = 0;

            foreach(String s in allText){
                i++;
                if (s == crtlS) break;
            }

            return i - 2;
        }


        /// <summary>
        /// This method replaces first occurrence of pattern in a string
        /// </summary>
        /// <param name="text">Represents where find and replace.</param>
        /// <param name="search">Represents what search.</param>
        /// <param name="replace">Represents what replace</param>
        /// <returns></returns>
        public static String replaceFirst(String text, String search, String replace) {
            Int32 pos = text.IndexOf(search);
            if (pos < 0) {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

    }
}
