namespace ConfigDoxygen {
    partial class FrmMain {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.dgvConfig = new System.Windows.Forms.DataGridView();
            this.gboxDescription = new System.Windows.Forms.GroupBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.gbConfFile = new System.Windows.Forms.GroupBox();
            this.gbProgressBar = new System.Windows.Forms.ProgressBar();
            this.lbPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.btCloseConnection = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).BeginInit();
            this.gboxDescription.SuspendLayout();
            this.gbConfFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConfig
            // 
            this.dgvConfig.AllowUserToAddRows = false;
            this.dgvConfig.AllowUserToDeleteRows = false;
            this.dgvConfig.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConfig.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConfig.GridColor = System.Drawing.Color.Tan;
            this.dgvConfig.Location = new System.Drawing.Point(6, 26);
            this.dgvConfig.Name = "dgvConfig";
            this.dgvConfig.ReadOnly = true;
            this.dgvConfig.RowHeadersVisible = false;
            this.dgvConfig.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Honeydew;
            this.dgvConfig.Size = new System.Drawing.Size(696, 475);
            this.dgvConfig.TabIndex = 0;
            this.dgvConfig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfig_CellClick);
            this.dgvConfig.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvConfig_DataBindingComplete);
            this.dgvConfig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvConfig_DataError);
            this.dgvConfig.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvConfig_KeyPress);
            // 
            // gboxDescription
            // 
            this.gboxDescription.Controls.Add(this.txtDescription);
            this.gboxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxDescription.ForeColor = System.Drawing.Color.Honeydew;
            this.gboxDescription.Location = new System.Drawing.Point(725, 52);
            this.gboxDescription.Name = "gboxDescription";
            this.gboxDescription.Size = new System.Drawing.Size(517, 506);
            this.gboxDescription.TabIndex = 1;
            this.gboxDescription.TabStop = false;
            this.gboxDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.SteelBlue;
            this.txtDescription.Font = new System.Drawing.Font("Courier New", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Honeydew;
            this.txtDescription.Location = new System.Drawing.Point(6, 22);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(511, 478);
            this.txtDescription.TabIndex = 0;
            // 
            // gbConfFile
            // 
            this.gbConfFile.Controls.Add(this.dgvConfig);
            this.gbConfFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfFile.ForeColor = System.Drawing.Color.Honeydew;
            this.gbConfFile.Location = new System.Drawing.Point(12, 51);
            this.gbConfFile.Name = "gbConfFile";
            this.gbConfFile.Size = new System.Drawing.Size(708, 507);
            this.gbConfFile.TabIndex = 2;
            this.gbConfFile.TabStop = false;
            this.gbConfFile.Text = "Configuration File";
            // 
            // gbProgressBar
            // 
            this.gbProgressBar.Location = new System.Drawing.Point(1, 600);
            this.gbProgressBar.Name = "gbProgressBar";
            this.gbProgressBar.Size = new System.Drawing.Size(1244, 14);
            this.gbProgressBar.TabIndex = 7;
            // 
            // lbPath
            // 
            this.lbPath.BackColor = System.Drawing.Color.Transparent;
            this.lbPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbPath.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.Color.White;
            this.lbPath.Location = new System.Drawing.Point(67, 571);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(1175, 23);
            this.lbPath.TabIndex = 5;
            this.lbPath.Text = "lbPath";
            this.lbPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btOpenFile.Image")));
            this.btOpenFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btOpenFile.Location = new System.Drawing.Point(14, 564);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(47, 39);
            this.btOpenFile.TabIndex = 6;
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.Image = global::ConfigDoxygen.Properties.Resources.minus;
            this.btMinimize.Location = new System.Drawing.Point(1203, 3);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(42, 39);
            this.btMinimize.TabIndex = 4;
            this.btMinimize.UseVisualStyleBackColor = true;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // btExit
            // 
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(864, 7);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(50, 39);
            this.btExit.TabIndex = 3;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Ivory;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(76, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(638, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btRestore
            // 
            this.btRestore.Image = ((System.Drawing.Image)(resources.GetObject("btRestore.Image")));
            this.btRestore.Location = new System.Drawing.Point(771, 7);
            this.btRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(42, 39);
            this.btRestore.TabIndex = 8;
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btCloseConnection
            // 
            this.btCloseConnection.Image = ((System.Drawing.Image)(resources.GetObject("btCloseConnection.Image")));
            this.btCloseConnection.Location = new System.Drawing.Point(725, 7);
            this.btCloseConnection.Margin = new System.Windows.Forms.Padding(2);
            this.btCloseConnection.Name = "btCloseConnection";
            this.btCloseConnection.Size = new System.Drawing.Size(42, 39);
            this.btCloseConnection.TabIndex = 9;
            this.btCloseConnection.UseVisualStyleBackColor = true;
            this.btCloseConnection.Click += new System.EventHandler(this.btCloseConnection_Click);
            // 
            // btSave
            // 
            this.btSave.Image = ((System.Drawing.Image)(resources.GetObject("btSave.Image")));
            this.btSave.Location = new System.Drawing.Point(817, 7);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(42, 39);
            this.btSave.TabIndex = 10;
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1249, 615);
            this.ControlBox = false;
            this.Controls.Add(this.gbProgressBar);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCloseConnection);
            this.Controls.Add(this.btRestore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.gboxDescription);
            this.Controls.Add(this.gbConfFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xxx";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfig)).EndInit();
            this.gboxDescription.ResumeLayout(false);
            this.gboxDescription.PerformLayout();
            this.gbConfFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConfig;
        private System.Windows.Forms.GroupBox gboxDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox gbConfFile;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btMinimize;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.ProgressBar gbProgressBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btCloseConnection;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

