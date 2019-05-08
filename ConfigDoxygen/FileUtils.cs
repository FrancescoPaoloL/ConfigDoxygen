///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          FileUtils
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name          Date            Description
///   Me            25/04/19        Added preprocessor code
///-----------------------------------------------------------------
///

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace ConfigDoxygen {
    /// <summary>
    /// A static class which contains some useful utilities about file
    /// </summary>
    public static class FileUtils {
        /// <summary>
        /// Simple method which permits to open a particular folder
        /// </summary>
        /// <param name="selectedFolder">This parameter is "out" decorated; so returns
        ///                              a possibly string path.
        /// </param>
        /// <returns>It returns a boolean true/false and -- obviously -- a selected folder path</returns>
        public static Boolean OpenFolder(out String selectedFolder) {
            selectedFolder = String.Empty;
            using (var fbd = new FolderBrowserDialog()) {
                //TODO: center of screen?
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !String.IsNullOrWhiteSpace(fbd.SelectedPath)) {
                    selectedFolder = fbd.SelectedPath;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Simple method which permits to open a text file and returns an array of strings
        /// (which Represents every row read)
        /// </summary>
        /// <param name="textData">This parameter is "out" decorated; so returns
        ///                        a possibly array of String type if "DialogResult.OK"
        /// </param>
        /// <param name="fileName">This parameter is "out" decorated; so returns -- possibly --
        ///                        what file is opened (if it is not specified).
        /// </param>
        /// <param name="size">This parameter is "out" decorated; so returns -- possibly --
        ///                    the size of the opened file.
        /// </param>
        /// <param name="pathFile">Represents the doxygen configuration file path</param>
        /// <returns>Returns a boolean value</returns>
        public static Boolean OpenTextFile(out String[] textData, out Int32 size, ref String pathFile) {
            textData = null;
            size = 0;

            if (pathFile.Length > 0) {
                try {
                    textData = File.ReadAllLines(pathFile);
                    size = textData.Length;
                } catch (IOException) {
                    return false;
                }

                return true;
            }


            if (pathFile.Length == 0) {
                OpenFileDialog Ofd = new OpenFileDialog();
#if DEBUG
                Ofd.InitialDirectory = @"E:\SORGENTI\APPs\ConfigDoxygen\src\ConfigDoxygen\docs";
#endif

                DialogResult result = Ofd.ShowDialog();

                if (result == DialogResult.OK) {
                    try {
                        pathFile = Path.GetDirectoryName(Ofd.FileName);
                        textData = File.ReadAllLines(Ofd.FileName);
                        size = textData.Length;
                    } catch (IOException) {
                        return false;
                    }

                    return true;
                }
            }



            return false;
        }

        /// <summary>
        /// This method represents a "custom mode" of writing a text file
        /// according to the doxygen config file schema.
        /// </summary>
        /// <param name="path">The path where this text file will write.</param>
        /// <param name="dict">Represents a public Dictionary<String, DefinitionTag>
        ///                    which Represents every read row
        /// </param>
        public static void SavingConfFile(String path, ref Dictionary<String, DefinitionTag> dict) {
            //TODO: save file -- move these statement rows
            //String s = General.GetTextResource("ConfigDoxygen.header.txt");
            StringBuilder sb = new StringBuilder();
            Boolean f = false;

            sb = sb.AppendLine("#This configuration file is modified with ");
            sb = sb.Append("#");
            sb = sb.Append(AppDomain.CurrentDomain.FriendlyName);
            sb = sb.Append(" (v. ");
            sb = sb.Append(Assembly.GetExecutingAssembly().GetName().Version.ToString());
            sb = sb.AppendLine(")");
            sb = sb.AppendLine();

            foreach (KeyValuePair<String, DefinitionTag> entry in dict) {
                String[] stringSeparators = new String[] { "\r\n" };
                String paddedParam = entry.Value.Description.PadLeft(entry.Value.Description.Length + 1); ;
                paddedParam = paddedParam.PadLeft(10);

                String[] lines = paddedParam.Split(stringSeparators, StringSplitOptions.None);

                foreach (String s in lines) {
                    sb = sb.Append("#");
                    sb = sb.Append(s);
                    sb = sb.Append(Environment.NewLine);
                }

                f = Trivia.TestingQuoteValue(entry.Key);
                sb = sb.Append(Environment.NewLine);
                sb = sb.Append(entry.Key);
                sb = sb.Append(" = ");
                if (f) sb = sb.Append("\"");
                sb = sb.Append(entry.Value.Value);
                if (f) sb = sb.Append("\"");
                sb = sb.Append(Environment.NewLine);
                sb = sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
            
        }
    }
}
