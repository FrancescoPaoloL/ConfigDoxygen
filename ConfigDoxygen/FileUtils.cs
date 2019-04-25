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
        ///                        what file is opened.
        /// </param>
        /// <param name="size">This parameter is "out" decorated; so returns -- possibly --
        ///                    the size of the opened file.
        /// </param>
        /// <returns></returns>
        public static Boolean OpenTextFile(out String[] textData, out String fileName, out Int32 size) {
            textData = null;
            fileName = String.Empty;
            size = 0;

            OpenFileDialog Ofd = new OpenFileDialog();
#if DEBUG
            Ofd.InitialDirectory = @"E:\SORGENTI\APPs\ConfigDoxygen\src\ConfigDoxygen\docs";
#endif

            DialogResult result = Ofd.ShowDialog();

            if (result == DialogResult.OK) {
                fileName = Ofd.FileName;
                try {
                    textData = File.ReadAllLines(fileName);
                    size = textData.Length;
                } catch (IOException) {
                    return false;
                }

                return true;
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

            foreach (KeyValuePair<String, DefinitionTag> entry in dict) {
                f = Trivia.TestingQuoteValue(entry.Key);
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
