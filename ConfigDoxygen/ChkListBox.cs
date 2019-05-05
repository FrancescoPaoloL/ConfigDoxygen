using System;
using System.Windows.Forms;
using System.Linq;

namespace ConfigDoxygen {
    public partial class ChkListBox : Form {
        public String[] values { get; set; }
        public String[] checkedValues { get; set; }

        public ChkListBox() {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            //this.Validator = null;
            this.Close();
        }

        private void ChkListBox_Load(object sender, EventArgs e) {
            chkElements.Items.AddRange(values);

            //Array1.Intersect(Array2);
            //var results = array1.Intersect(array2, StringComparer.OrdinalIgnoreCase);

            var intersect = values.Intersect(checkedValues, StringComparer.OrdinalIgnoreCase).ToArray();
            // Write intersection to screen.
            Int32 i = 0;
            foreach(var s in intersect){
                chkElements.SetItemChecked(i++, true);
            }

           


            
            //for (Int32 i = 0; i < chkElements.Items.Count; i++) {
            //    if (checkedValues.Contains(value))
            //        checkedListBox1.SetItemChecked(i, true);
            //}
            //chkElements.SetItemChecked()
        }
       
    }
}
