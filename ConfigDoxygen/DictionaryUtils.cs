﻿/*
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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains some useful utilities about dictionary
    /// </summary>
    public static class DictionaryUtils {
        /// <summary>
        /// This method privides to load values into dictionary (specifically into 
        /// a String key and DefinitionTag object / value(s).
        /// This method ignores the first rows of config file and store:
        /// <list type="">
        /// <item>Key: that is the DefinitionTag class Tag property.</item>
        /// <item>Value: that is the DefinitionTag class Value property.</item>
        /// <item>Description: that is Description class property.</item>
        /// </list>
        /// </summary>
        /// <param name="TextData">Represents an array of strings</param>
        /// <returns>A dictionary loaded of array strings.</returns>
        public static Dictionary<String, DefinitionTag> SplitDataInDictionary(String[] TextData) {
            Dictionary<String, DefinitionTag> myRet = new Dictionary<String, DefinitionTag>();
            Int32 nrRow = 0;
            String myCh = String.Empty;
            StringBuilder sb = new StringBuilder();
            Int32 fistRow = Helper.getFirstRowReadable(TextData);
            foreach (String row in TextData) {
                if (nrRow > fistRow) {
                    myCh = StringExtensions.Left(row, Constants.K_ColumnDescriptionHidden).Trim();
                    if (myCh == Constants.K_CharDescription) {
                        sb = sb.AppendLine(Helper.replaceFirst(row, Constants.K_CharDescription, ""));
                    } else if (myCh == Constants.K_CharDescriptionAlt) {
                        //NOP
                    } else if (myCh.Length > 0) {
                        //kCharDivideKeyValue[0] --> from string to char
                        String[] tokens = row.Split(Constants.K_CharDivideKeyValue[0]).Select(x => x.Trim()).ToArray();
                        String myDescription = sb.ToString().Trim();

                        DefinitionTag def = new DefinitionTag();
                        
                        String tmpTag = tokens[0].ToString();

                        switch (tmpTag) {
                            case Constants.K_FILE_PATTERNS:
                                def.Value = makeMultiValuesString(Constants.K_FILE_PATTERNS, nrRow, TextData);
                                break;
                            case Constants.K_ABBREVIATE_BRIEF:
                                def.Value = makeMultiValuesString(Constants.K_ABBREVIATE_BRIEF, nrRow, TextData);
                                break;
                            default:
                                def.Value = tokens[1].ToString().Replace("\"", "");
                                break;
                        }

                        def.Description = myDescription;
                        myRet.Add(tokens[0], def);
                        sb.Clear();
                    } else {
                        //NOP
                    }
                }
                nrRow++;
            }

            return myRet;
        }


        /// <summary>
        /// This method makes multi values for specific tags.
        /// </summary>
        /// <param name="tag">Represents the tag</param>
        /// <param name="nrRow">Represents the row number</param>
        /// <param name="TextData">Represent a String array.</param>
        /// <returns></returns>
        private static String makeMultiValuesString(String tag, Int32 nrRow, String[] TextData){
            StringBuilder sbRow = new StringBuilder();
            for (Int32 x = nrRow; x <= TextData.Length; x++) {
                String tmp = TextData[x].Replace(tag, "")
                                        .Replace(Constants.K_CharDivideKeyValue, "").Trim();
                if (StringExtensions.Left(tmp, 1) == Constants.K_CharDescription) break;

                sbRow = sbRow.Append(tmp);
            }

            return sbRow.ToString();
        }

        /// <summary>
        /// This method does a linq query in a dictionary and returns a IEnumerable data source.
        /// </summary>
        /// <param name="tag">This parameter specifies a filter tag</param>
        /// <param name="dictionary">This parameter represents a dictionary over do a linq query</param>
        /// <returns>Returns a IEnumerable object</returns>
        public static IEnumerable GetQuery(String tag, Dictionary<String, DefinitionTag> dictionary) {
            if (tag.Length == 0) {
                return dictionary.ToList();
            } else {
                return dictionary.Where(k => k.Key.Contains(tag)).ToArray();
            }
        }


        /// <summary>
        /// This method make decision about a particular tag value, or how it fills with others.
        /// TODO!
        /// </summary>
        /// <param name="dic">This parameter provides a dictionary which is used in GetValueTags() method.</param>
        /// <param name="Tag">This parameter specifies a tag.</param>
        /// <param name="Value">This parameter specifies a tag value.</param>
        /// <returns>Return true/false if a tag value is permitted or not.</returns>
        public static Boolean CheckDataIntegrity(ref Dictionary<String, DefinitionTag> dic, String Tag, String Value) {
            switch (Tag) {
                case Constants.K_REPEAT_BRIEF:
                    List<String> ls = GetValueTags(ref dic, Constants.K_HIDE_UNDOC_MEMBERS, Constants.K_BRIEF_MEMBER_DESC);
                    //...
                    return true;
                //case k....
                //
                default:
                    return true;
            }
        }

        /// <summary>
        /// This method take some contant tag as input, with these iterate over a dictionary and return a List object
        /// where CheckDataIntegrity() method check if these are correct or not.
        /// </summary>
        /// <param name="dic">This parameter represents a reference dictionary over iterate.</param>
        /// <param name="Tags">This parameter Represents a specified tag.</param>
        /// <returns>Returns a list of string objects</returns>
        public static List<String> GetValueTags(ref Dictionary<String, DefinitionTag> dic, params String[] Tags) {
            List<String> ls = new List<String>();
            foreach (String tag in Tags) {
                foreach (KeyValuePair<String, DefinitionTag> entry in dic) {
                    if (entry.Key == tag) {
                        ls.Add(entry.Value.Value);
                        break;
                    }
                }
            }
            return ls;
        }
        //TODO: data integrity -- END

        /// <summary>
        /// This method update a custom tag value by creating a new DefinitionTag object.
        /// </summary>
        /// <param name="TAG">Represents a tag as key</param>
        /// <param name="NewValue">Represents a new value property.</param>
        /// <param name="Description">Represents a description property.</param>
        /// <param name="Dictionary">Represents a reference dictionary.</param>
        public static void UpdateCustomValue(String TAG, String NewValue, String Description, ref Dictionary<String, DefinitionTag> Dictionary) {
            DefinitionTag dd = new DefinitionTag();

            dd.Tag = TAG;
            dd.Value = NewValue;
            dd.Description = Description;

            Dictionary[TAG] = dd;
        }

        /// <summary>
        /// NOT USED!
        /// 
        /// This methods get value (in this case an DefinitionTag object) by a tag name.
        /// </summary>
        /// <param name="Tag"></param>
        /// <param name="Dictionary"></param>
        /// <returns></returns>
        //public static String GetValueXTag(String Tag, Dictionary<String, DefinitionTag> Dictionary) {
        //    foreach (KeyValuePair<String, DefinitionTag> entry in Dictionary) {
        //        if (entry.Key == Tag) {
        //            return entry.Value.Value.ToString(); ;
        //        }
        //    }
        //    return "";
        //}
    }
}
