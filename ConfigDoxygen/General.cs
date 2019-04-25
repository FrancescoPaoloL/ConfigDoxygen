///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          General
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------
///

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
    public class General {
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
    }
}
