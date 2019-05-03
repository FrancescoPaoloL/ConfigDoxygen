///-----------------------------------------------------------------
///   Namespace:      ConfigDoxygen
///   Class:          FrmMain
///   Description:    <Description>
///   Author:         Francesco Paolo Lezza         Date: 08/08/2018
///   Notes:          <Notes>
///   
///   Revision History:
///   Name          Date            Description
///   Me            13/08/18        Fixed problem with Windows XP
///   Me            25/04/19        Modified layout
///   Me            29/04/19        Added about logic
///                                 Improved code
///-----------------------------------------------------------------
///

using AboutMe;
using InputBoxSample;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

[assembly: CLSCompliant(true)]
namespace ConfigDoxygen {
    public partial class FrmMain : Form {
        List<String> ListButton = new List<String>();
        List<String> ListCombo = new List<String>();

        List<String> ListOpenDialog = new List<String>();
        List<String> ListOpenTextBox = new List<String>();

        Dictionary<String, DefinitionTag> DictionaryAllRows = null;


        /// <summary>
        /// Initialize Component
        /// </summary>
        public FrmMain() {
            InitializeComponent();
        }

        /// <summary>
        /// call SetElementsInForm()
        /// </summary>
        /// <param name="sender">Object that is Form1</param>
        /// <param name="e">This contains event info about object</param>
        private void Form1_Load(object sender, EventArgs e) {
            var myDate = Assembly.GetExecutingAssembly().GetLinkerTime().ToShortDateString();
            lbInfoVersion.Text = "ConfigDoxyGen ver. " + Application.ProductVersion + " (" + myDate + ")";
            SetElementsInForm();
        }

        /// <summary>
        /// Call Trivia.SetListsInForm(), that is a static method which load elements (strings here) in
        /// public lists.
        /// Then set txtSearch to modify all in put character into UPPER char and subscribe an event handler
        /// which controls if Enter key is pressed.
        /// </summary>
        private void SetElementsInForm() {
            Trivia.SetListsInForm(ref ListButton, ref ListCombo, ref ListOpenDialog, ref ListOpenTextBox);

            gbConfFile.Text = "No Configuration file opened";
            gbConfFile.ForeColor = Color.DarkRed;
            lbPath.Text = "Please select a config file or create a new one!";
            gbProgressBar.Visible = false;

            txtSearch.CharacterCasing = CharacterCasing.Upper;
            txtSearch.KeyPress += new KeyPressEventHandler(CheckEnter);
        }

        /// <summary>
        /// This event handler manually raises the CellValueChanged event 
        /// by calling the CommitEdit method. 
        /// </summary>
        /// <param name="sender">Object that is a dataGridView type</param>
        /// <param name="e">This contains event info about object</param>
        void dataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e) {
            if (dgvConfig.IsCurrentCellDirty) {
                // This fires the cell value changed handler below
                dgvConfig.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        /// <summary>
        /// Determines if a cell change its value, through calling Trivia.CheckDataIntegrity() method,
        /// in order to determine if this value is congruent or not.
        /// </summary>
        /// <param name="sender">Object that is a dataGridView cell type</param>
        /// <param name="e">This contains event info about object</param>
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            //Make sure the clicked row/column is valid.
            Boolean validClick = (e.RowIndex != -1 && e.ColumnIndex != -1);
            if ((validClick) && (e.ColumnIndex == Constants.K_ColumnValue) && (Trivia.VerifyTypeCellCombo(dgvConfig[Constants.K_ColumnTag, e.RowIndex].Value.ToString(), ref ListCombo))) {
                dgvConfig.Refresh();

                String myTag = dgvConfig[Constants.K_ColumnTag, e.RowIndex].Value.ToString();
                String myValue = dgvConfig[Constants.K_ColumnValue, e.RowIndex].Value.ToString();
                String myDescription = dgvConfig[Constants.K_ColumnDescriptionHidden, e.RowIndex].Value.ToString();

                //TODO: determine cases
                if (!DictionaryUtils.CheckDataIntegrity(ref DictionaryAllRows, myTag, myValue)) return;
                DictionaryUtils.UpdateCustomValue(myTag, myValue, myDescription, ref DictionaryAllRows);
            }
        }

        /// <summary>
        /// This method open a file, it reads it through SplitTextDataDescription() method and
        /// loads info into a public dictionary.
        /// Furthermore, unscribes two events, where possible, then call GetQuery()
        /// calling SetDataGridView() method and finally subscribes these two events (because of 
        /// when we set datagridview these events immediately raise...)
        /// 
        /// For events see: https://stackoverflow.com/questions/5652957/what-event-catches-a-change-of-value-in-a-combobox-in-a-datagridviewcell
        /// </summary>
        /// 
        /// <param name="file">Represents </param>        
        private void ReadConfigFile(String pathFile = "") {
            Int32 size = 0;
            String[] TextData = null;
                        
            //https://stackoverflow.com/questions/5652957/what-event-catches-a-change-of-value-in-a-combobox-in-a-datagridviewcell
            dgvConfig.CurrentCellDirtyStateChanged -= new EventHandler(dataGridView_CurrentCellDirtyStateChanged);
            dgvConfig.CellValueChanged -= new DataGridViewCellEventHandler(dataGridView_CellValueChanged);

            Boolean f = FileUtils.OpenTextFile(out TextData, out size, ref pathFile);

            if (!f) return;

            DictionaryAllRows = DictionaryUtils.SplitDataInDictionary(TextData);

            //var DataArray = GetQuery(String.Empty, DictionaryAllRows);
            SetDataGridView(DictionaryAllRows);

            //https://stackoverflow.com/questions/5652957/what-event-catches-a-change-of-value-in-a-combobox-in-a-datagridviewcell
            dgvConfig.CellValueChanged += new DataGridViewCellEventHandler(dataGridView_CellValueChanged);
            dgvConfig.CurrentCellDirtyStateChanged += new EventHandler(dataGridView_CurrentCellDirtyStateChanged);
            dgvConfig.Rows[0].Selected = true;
            txtDescription.Text = dgvConfig.Rows[0].Cells[Constants.K_ColumnDescriptionHidden].Value.ToString().Replace("\r\n", "");

            lbPath.Text = pathFile + "      (" + StringUtils.BytesToString(size) + ")";

        }

        /// <summary>
        /// This method create a DataTable object which is loaded with a filtered dictionary.
        /// Then it creates two column.
        /// <list type="Column">
        ///     <item> It contains values and (depending on type of key/tag) it is modified into combo or button (invisible).</item>
        ///     <item> A column where store the original value read of config file (remember this method is called by ReadConfigFile()!).</item>
        /// </list>
        /// </summary>
        /// Finally set datagridview.
        /// <param name="DictionaryDataSource">This parameter is a dictionary (filtered if it is possible) as datagridview datasource.</param>
        private void SetDataGridView(Dictionary<String, DefinitionTag> DictionaryDataSource) {
            CloseConnection();

            dgvConfig.ColumnHeadersDefaultCellStyle.ForeColor = Color.Chocolate;
            dgvConfig.ColumnHeadersDefaultCellStyle.BackColor = Color.Lavender;
            dgvConfig.EnableHeadersVisualStyles = false;

            dgvConfig.Visible = false;

            gbConfFile.Text = "Reading Configuration file...";

            dgvConfig.AutoGenerateColumns = true;

            var filteredValues = DictionaryUtils.GetQuery(txtSearch.Text.Trim(), DictionaryAllRows);

            DataTable dt = new DataTable();
            dt.Columns.Add("TAG", typeof(String));
            dt.Columns.Add("Value", typeof(String));
            dt.Columns.Add("Description", typeof(String));
            dt.Columns.Add("OriginalValue", typeof(String));

            //http://robertgreiner.com/2010/05/iterating-through-a-dictionary-in-csharp/
            foreach (KeyValuePair<String, DefinitionTag> x in filteredValues) {
                dt.Rows.Add(x.Key, x.Value.Value, x.Value.Description);
            }

            dgvConfig.DataSource = dt;

            dgvConfig.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConfig.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvConfig.AllowUserToResizeRows = false;

            //progress bar...
            gbProgressBar.Visible = true;
            gbProgressBar.Maximum = dgvConfig.Rows.Count * 2;
            gbProgressBar.Step = 1;
            gbProgressBar.Value = 0;

            this.Refresh();
            Int32 q = 0;
            for (Int32 x = 0; x < dgvConfig.Rows.Count; x++) {
                String myTag = dgvConfig[Constants.K_ColumnTag, x].Value.ToString();
                String myValue = dgvConfig[Constants.K_ColumnValue, x].Value.ToString();

                if (Trivia.VerifyTypeCellButton(myTag, ref ListButton)) {
                    //DEPRECATED
                    //DataGridViewButtonCell bt = new DataGridViewButtonCell();
                    //bt.Value = kButtonText;
                    //dgvConfig[kColumnActions, x] = bt;                    
                    //DEPRECATED -- END

                    String tmp = dgvConfig[Constants.K_ColumnValue, x].Value.ToString().Replace("\"", "");
                    dgvConfig[Constants.K_ColumnValue, x].Value = tmp;
                    dgvConfig[Constants.K_ColumnOriginalValue, x].Value = tmp;
                    //if (txtSearch.Text.Length == 0) UpdateCustomValue(myTag, tmp);
                } else if (Trivia.VerifyTypeCellCombo(myTag, ref ListCombo)) {
                    DataGridViewComboBoxCell cb = new DataGridViewComboBoxCell();
                    cb.FlatStyle = FlatStyle.Flat;
                    Trivia.FillCombo(ref cb, myTag);
                    dgvConfig[Constants.K_ColumnValue, x] = cb;
                    dgvConfig.Refresh();

                    dgvConfig.Rows[x].Cells[Constants.K_ColumnValue].Value = myValue;
                    dgvConfig[Constants.K_ColumnOriginalValue, x].Value = myValue;
                    //if (txtSearch.Text.Length == 0) UpdateCustomValue(myTag, myValue);
                } else {
                    if (Trivia.TestingDotLineDescription(myTag)) {
                        //TODO: regex...
                        //(.*) etc
                        //####myValue= myValue.Replace(
                    }


                    //UpdateCustomValue(myTag, myValue);
                }
                q += 1;
                gbProgressBar.Value = q;
            }
            this.Refresh();

            dgvConfig.Columns[Constants.K_ColumnOriginalValue].Visible = false;
            dgvConfig.Columns[Constants.K_ColumnDescriptionHidden].Visible = true;

            //set autosize mode
            dgvConfig.Columns[Constants.K_ColumnTag].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvConfig.Columns[Constants.K_ColumnValue].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvConfig.Columns[Constants.K_ColumnTag].Width = Constants.K_ColWidthTag;
            dgvConfig.Columns[Constants.K_ColumnValue].Width = dgvConfig.Width - dgvConfig.Columns[Constants.K_ColumnTag].Width - Constants.K_ColWidthFillUp;


            dgvConfig.Visible = true;
            dgvConfig.Rows[0].Selected = true;
            txtDescription.Text = dgvConfig.Rows[0].Cells[Constants.K_ColumnDescriptionHidden].Value.ToString().Replace("\r\n", ""); ;

            gbConfFile.Text = "Configuration file: nr " + dgvConfig.Rows.Count.ToString() + " rows";
            gbConfFile.ForeColor = Color.GreenYellow;
            dgvConfig.Refresh();

            gbProgressBar.Value = 0;
            gbProgressBar.Visible = false;
        }
  
       
        /// <summary>
        /// This method performs actions AFTER data binding (in datagridview) is complete.
        /// These actions concerns resize column properly.
        /// </summary>
        /// <param name="sender">Object that is a dataGridView type</param>
        /// <param name="e">This contains event info about data binding complete</param>
        private void dgvConfig_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            dgvConfig.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvConfig.Columns[dgvConfig.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        /// <summary>
        /// This method permits, on user click, to perform two type of actions.
        /// <list type="On click">
        ///     <item> The user can iterate with a combo list full of all possible value for this tag.</item>
        ///     <item> It appears a open dialog form where you can specify which path you want indicate.</item>
        ///     <item> It appears an input box where you can insert custom value</item>
        /// </list>
        /// </summary>
        /// <param name="sender">Object that is a dataGridView type</param>
        /// <param name="e">This contains event info about data cell</param>
        private void dgvConfig_CellClick(object sender, DataGridViewCellEventArgs e) {
            Boolean validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            // Check to make sure the cell clicked is the cell containing the combobox 
            //if ((e.ColumnIndex == kColumnActions) && validClick) {
            String myTag = dgvConfig.Rows[e.RowIndex].Cells[Constants.K_ColumnTag].Value.ToString();
            String myValue = dgvConfig.Rows[e.RowIndex].Cells[Constants.K_ColumnValue].Value.ToString();
            String myDescription = dgvConfig.Rows[e.RowIndex].Cells[Constants.K_ColumnDescriptionHidden].Value.ToString();
            if ((e.ColumnIndex == Constants.K_ColumnValue) && validClick) {
                if (dgvConfig.CurrentCell is DataGridViewComboBoxCell) {
                    dgvConfig.ReadOnly = false;
                    dgvConfig.EditMode = DataGridViewEditMode.EditOnEnter;
                } else {
                    if (Trivia.IterateOverList(ListOpenDialog, myTag)) {
                        String Path = String.Empty;
                        Boolean f = FileUtils.OpenFolder(out Path);

                        if (!f) return;

                        if (myValue != Path) {
                            DictionaryUtils.UpdateCustomValue(myTag, Path, myDescription, ref DictionaryAllRows);
                            dgvConfig[Constants.K_ColumnValue, e.RowIndex].Value = Path;
                        }
                    } else if (Trivia.IterateOverList(ListOpenTextBox, myTag)) {
                        String prompt = "TAG --> " + myTag;
                        String title = "";
                        String content = dgvConfig[Constants.K_ColumnValue, e.RowIndex].Value.ToString();
                        String tip = String.Empty;
                        InputBoxResult result = InputBox.Show(prompt, title, content, tip, new InputBoxValidatingHandler(inputBox_Validating));
                        if ((result.OK) && (content != result.Text)) {
                            DictionaryUtils.UpdateCustomValue(myTag, result.Text, myDescription, ref DictionaryAllRows);
                            dgvConfig[Constants.K_ColumnValue, e.RowIndex].Value = result.Text;
                        }
                    }
                    dgvConfig.ReadOnly = true;
                }
            } else {
                dgvConfig.ReadOnly = true;
            }
            
            if(e.ColumnIndex < 2)
                txtDescription.Text = dgvConfig.Rows[e.RowIndex].Cells[Constants.K_ColumnDescriptionHidden].Value.ToString().Replace("\r\n", "");
        }


        /// <summary>
        /// This method permits to move the form by mouse moving.
        /// It calls some P/Inkove methods (see NativeMethods class).
        /// </summary>
        /// <param name="sender">Object that is a Form type</param>
        /// <param name="e">This contains event info about mouse</param>
        private void Form1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, Constants.WM_NCLBUTTONDOWN, Constants.HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// This method permits to minimize the active form.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// This method permits to exit of application.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        /// <summary>
        /// This method permits, on user click, to close data binding connection
        /// by calling CloseConnection() method and read a new config file.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btOpenFile_Click(object sender, EventArgs e) {
            //CloseConnection();
            ReadConfigFile();
        }

        /// <summary>
        /// This method permits set form for closing connection
        /// and actually close data connection on datagridview.
        /// </summary>
        private void CloseConnection() {
            gbConfFile.Text = "No Configuration file opened";
            lbPath.Text = "Please select a config file or create a new one!";
            txtDescription.Text = String.Empty;
            gbConfFile.Text = "No Configuration file opened";
            gbConfFile.ForeColor = Color.DarkRed;
            dgvConfig.DataSource = null;
            dgvConfig.Rows.Clear();
            dgvConfig.Columns.Clear();
            dgvConfig.Refresh();
        }

        /// <summary>
        /// This method permits to determine if input is valid or not.
        /// See dgvConfig_CellClick():
        /// <list type="">
        ///     <item>InputBoxResult result = InputBox.Show(prompt, title, content, tip, new InputBoxValidatingHandler(inputBox_Validating));</item>
        /// </list>
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about validating input object</param>
        private void inputBox_Validating(object sender, InputBoxValidatingArgs e) {
            if (e.Text.Trim().Length == 0) {
                e.Cancel = true;
                e.Message = "Required";
            }
        }

        /// <summary>
        /// This method permit to avoid that user can write into data grid cells.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about validating key pressed</param>
        private void dgvConfig_KeyPress(object sender, KeyPressEventArgs e) {
            dgvConfig.ReadOnly = true;
        }

        /// <summary>
        /// NOP!
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about data grid view errors</param>
        private void dgvConfig_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            //NOP
        }

        /// <summary>
        /// This method restore the original value stored in a dedicate DefinitionTag class property.
        /// Remember these original values is all about the first reading of config file.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about data grid view errors</param>
        private void btRestore_Click(object sender, EventArgs e) {
            //progress bar...
            gbProgressBar.Visible = true;
            gbProgressBar.Maximum = dgvConfig.Rows.Count;
            gbProgressBar.Step = 1;
            gbProgressBar.Value = 0;

            this.Refresh();
            Int32 q = 0;
            for (Int32 x = 0; x < dgvConfig.Rows.Count; x++) {
                String myTag = dgvConfig.Rows[x].Cells[Constants.K_ColumnTag].Value.ToString();
                String originalValue = dgvConfig[Constants.K_ColumnOriginalValue, x].Value.ToString();
                String myDescription = dgvConfig.Rows[x].Cells[Constants.K_ColumnDescriptionHidden].Value.ToString();

                DictionaryUtils.UpdateCustomValue(myTag, originalValue, myDescription, ref DictionaryAllRows);
                dgvConfig[Constants.K_ColumnValue, x].Value = originalValue;

                q += 1;
                gbProgressBar.Value = q;
            }

            
            gbProgressBar.Value = 0;
            gbProgressBar.Visible = false;
            this.Refresh();
        }


        /// <summary>
        /// This method close data binding source connection on datagridview
        /// trough calling CloseConnection() method.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btCloseConnection_Click(object sender, EventArgs e) {
            CloseConnection();
        }

        /// <summary>
        /// This method permits to filter data source based on user input string.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about key pressed</param>
        private void CheckEnter(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Constants.K_ButtonEnterPressed) {
                if (dgvConfig.DataSource == null) return;

                Dictionary<String, DefinitionTag> FilteredDictionary = null;

                FilteredDictionary = Helper.CopyDictionary(DictionaryAllRows);

                SetDataGridView(FilteredDictionary);
            }
        }

        /// <summary>
        /// This methods (with saveFileDialog1_FileOk) permits to choice
        /// the path and the name of file you want to create.
        /// Permits to modify some tags value to get a very basic output.
        /// TODO: check if these tags have a different value.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btSave_Click(object sender, EventArgs e) {
            //TODO: check if these tags have a different value.

            StringBuilder sb = new StringBuilder();

            sb = sb.Append("Do you want modify these tags value to get a very basic output?\n\n");
            sb = sb.Append("    - GENERATE_LATEX = NO\n");
            sb = sb.Append("    - EXTRACT_STATIC = YES\n");
            sb = sb.Append("    - CALLER_GRAPH = YES\n");
            sb = sb.Append("    - HAVE_DOT = YES\n");
            sb = sb.Append("    - CALL_GRAPH = YES\n");
            sb = sb.Append(@"    - DOT_PATH = 'C:\Program Files (x86)\Graphviz2.38\bin'");

            DialogResult dialogResult = MessageBox.Show(sb.ToString(), "Advices", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {

                foreach (DataGridViewRow row in dgvConfig.Rows) {
                    switch (row.Cells[Constants.K_ColumnTag].Value.ToString()) {
                        case Constants.K_GENERATE_LATEX:
                            row.Cells[Constants.K_ColumnValue].Value = "NO";
                            break;

                        case Constants.K_EXTRACT_STATIC:
                            row.Cells[Constants.K_ColumnValue].Value = "YES";
                            break;

                        case Constants.K_CALLER_GRAPH:
                            row.Cells[Constants.K_ColumnValue].Value = "YES";
                            break;

                        case Constants.K_HAVE_DOT:
                            row.Cells[Constants.K_ColumnValue].Value = "YES";
                            break;

                        case Constants.K_CALL_GRAPH:
                            row.Cells[Constants.K_ColumnValue].Value = "YES";
                            break;

                        case Constants.K_DOT_PATH:
                            row.Cells[Constants.K_ColumnValue].Value = @"C:\Program Files (x86)\Graphviz2.38\bin";
                            break;

                        default:
                            break;
                    }
                }
            } 

            saveFileDialog1.ShowDialog();          
        }

        /// <summary>
        /// This methods (with btSave_Click) permits to choice
        /// the path and the name of file you want to create.
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {
            // Get file name.
            String name = saveFileDialog1.FileName;
            FileUtils.SavingConfFile(name, ref DictionaryAllRows);
        }


        /// <summary>
        /// Create a temporaney doxygen configuration file
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btNewFile_Click(object sender, EventArgs e) {
            Parameters parameters = new Parameters();
            ReadConfigFile(parameters.pathDoxyFile);
        }

        /// <summary>
        /// Show about the humble author and other stuff
        /// </summary>
        internal static void showAbout() {
            try {
                frmAbout frm = new frmAbout();
                frm.programName = System.AppDomain.CurrentDomain.FriendlyName;
                frm.version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                frm.license = "GPLv3 License";

                frm.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Shows the about winform
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void lklbAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            showAbout();
        }


        /// <summary>
        /// This changes the mouse cursor in TextBox
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void txtDescription_MouseMove(object sender, MouseEventArgs e) {
            ((TextBox)sender).Cursor = Cursors.Arrow;
        }


        /// <summary>
        /// Loads a saved configuration file
        /// </summary>
        /// <param name="sender">Object that is an object type</param>
        /// <param name="e">This contains event info about object</param>
        private void btLoad_Click(object sender, EventArgs e) {
            ReadConfigFile();
        }

    }
}
