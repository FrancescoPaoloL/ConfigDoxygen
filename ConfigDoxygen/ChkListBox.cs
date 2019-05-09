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
using System.Text;
using System.Windows.Forms;

namespace ConfigDoxygen {
    public partial class ChkListBox : Form {
        //public String[] values { get; set; }
        public String[] checkedValues { get; set; }
        public String strRet { get; set; }
        public String prompt { get; set; }

        /// <summary>
        /// Initialize Components
        /// </summary>
        public ChkListBox() {
            InitializeComponent();
        }


        /// <summary>
        /// This returns all selected values.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void buttonOK_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            for (Int32 i = 0; i < chkElements.Items.Count; i++) {
                CheckState st = chkElements.GetItemCheckState(i);
                if (st == CheckState.Checked) {
                    sb = sb.Append(chkElements.Items[i]);
                    sb = sb.Append("\\");
                }
            }
  
            strRet = sb.ToString();
            this.Close();
        }


        /// <summary>
        /// This simply close the (modal) winform.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }


        /// <summary>
        /// This sets the values properly 
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void ChkListBox_Load(object sender, EventArgs e) {
            lbPrompt.Text = prompt;
            //chkElements.Items.AddRange(values);
            chkElements.Items.AddRange(checkedValues);
            
            //List<String> intersect = values.Intersect(checkedValues, StringComparer.OrdinalIgnoreCase).ToList();
            
            // Write intersection to screen.
            for (Int32 count = 0; count < chkElements.Items.Count; count++) {
                //if (intersect.Contains(chkElements.Items[count].ToString())) {
                    chkElements.SetItemChecked(count, true);
                //}
            } 
        }

        /// <summary>
        /// This sets the checkbox items on true/false (obviously depends on parameter :) )
        /// </summary>
        /// <param name="f">Represents a boolean value</param>
        private void setChkValues(Boolean f) {
            for (Int32 i = 0; i < chkElements.Items.Count; i++) {
                chkElements.SetItemChecked(i, f);
            }
        }

        /// <summary>
        /// This modify layout and select/deselect all items
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void chkSelectAll_Click(object sender, EventArgs e) {
            if (chkSelectAll.Checked) {
                chkSelectAll.Text = "Deselect all";
                setChkValues(true);
            } else {
                chkSelectAll.Text = "Select all";
                setChkValues(false);
            }
        }


        /// <summary>
        /// Add new tag in cheked list
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btAdd_Click(object sender, EventArgs e) {
            String s = txtNewTAG.Text.Trim();

            DialogResult dialogResult = MessageBox.Show("Do you want to add this tag?" , "New tag to insert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                chkElements.Items.Insert(chkElements.Items.Count, s);
            }
        }
    }
}
