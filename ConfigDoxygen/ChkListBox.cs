using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConfigDoxygen {
    public partial class ChkListBox : Form {
        public String[] values { get; set; }
        public String[] checkedValues { get; set; }
        public String strRet { get; set; }

        public ChkListBox() {
            InitializeComponent();
        }

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

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ChkListBox_Load(object sender, EventArgs e) {
            chkElements.Items.AddRange(values);
            var intersect = values.Intersect(checkedValues, StringComparer.OrdinalIgnoreCase).ToArray();
            
            // Write intersection to screen.
            Int32 i = 0;
            foreach(var s in intersect){
### selezionare la vera
                if (chkElements.Items[i] == s.ToString())
                    chkElements.SetItemChecked(i, true);
                i++;
            }
        }


        private void setChkValues(Boolean f) {
            for (Int32 i = 0; i < chkElements.Items.Count; i++) {
                chkElements.SetItemChecked(i, f);
            }
        }

        private void rbSelectAll_Click(object sender, EventArgs e) {
            setChkValues(true);
        }

        private void rbUnselectAll_Click(object sender, EventArgs e) {
            setChkValues(false);
        }
    }
}
