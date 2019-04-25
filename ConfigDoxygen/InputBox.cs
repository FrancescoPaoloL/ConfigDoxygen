using System;
using System.Windows.Forms;

namespace InputBoxSample {
    /// <summary>
    /// The InputBox class is used to show a prompt in a dialog box using the static method Show().
    /// </summary>
    /// <remarks>
    /// Copyright © 2003 Reflection IT
    /// 
    /// This software is provided 'as-is', without any express or implied warranty.
    /// In no event will the authors be held liable for any damages arising from the
    /// use of this software.
    /// 
    /// Permission is granted to anyone to use this software for any purpose,
    /// including commercial applications, subject to the following restrictions:
    /// 
    /// 1. The origin of this software must not be misrepresented; you must not claim
    /// that you wrote the original software. 
    /// 
    /// 2. No substantial portion of the source code of this library may be redistributed
    /// without the express written permission of the copyright holders, where
    /// "substantial" is defined as enough code to be recognizably from this library. 
    /// 
    /// </remarks>
    public class InputBox : System.Windows.Forms.Form {
        protected System.Windows.Forms.Button buttonOK;
        protected System.Windows.Forms.Button buttonCancel;
        protected System.Windows.Forms.Label labelPrompt;
        protected System.Windows.Forms.TextBox textBoxText;
        protected System.Windows.Forms.ErrorProvider errorProviderText;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Delegate used to validate the object
        /// </summary>
        private InputBoxValidatingHandler _validator;

        private InputBox() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.labelPrompt = new System.Windows.Forms.Label();
            this.errorProviderText = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderText)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonOK.Location = new System.Drawing.Point(363, 83);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(90, 27);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.CausesValidation = false;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonCancel.Location = new System.Drawing.Point(459, 83);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(90, 27);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxText
            // 
            this.textBoxText.AllowDrop = true;
            this.textBoxText.BackColor = System.Drawing.Color.SteelBlue;
            this.textBoxText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxText.ForeColor = System.Drawing.Color.White;
            this.textBoxText.Location = new System.Drawing.Point(2, 35);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(547, 30);
            this.textBoxText.TabIndex = 1;
            this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
            this.textBoxText.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxText_DragOver);
            this.textBoxText.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxText_Validating);
            // 
            // labelPrompt
            // 
            this.labelPrompt.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrompt.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelPrompt.Location = new System.Drawing.Point(-2, 9);
            this.labelPrompt.Name = "labelPrompt";
            this.labelPrompt.Size = new System.Drawing.Size(551, 22);
            this.labelPrompt.TabIndex = 0;
            this.labelPrompt.Text = "prompt";
            // 
            // errorProviderText
            // 
            this.errorProviderText.ContainerControl = this;
            this.errorProviderText.DataMember = "";
            // 
            // InputBox
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(561, 115);
            this.ControlBox = false;
            this.Controls.Add(this.labelPrompt);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void buttonCancel_Click(object sender, System.EventArgs e) {
            this.Validator = null;
            this.Close();
        }

        private void buttonOK_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Displays a prompt in a dialog box, waits for the user to input text or click a button.
        /// </summary>
        /// <param name="prompt">String expression displayed as the message in the dialog box</param>
        /// <param name="title">String expression displayed in the title bar of the dialog box</param>
        /// <param name="defaultResponse">String expression displayed in the text box as the default response</param>
        /// <param name="validator">Delegate used to validate the text</param>
        /// <param name="xpos">Numeric expression that specifies the distance of the left edge of the dialog box from the left edge of the screen.</param>
        /// <param name="ypos">Numeric expression that specifies the distance of the upper edge of the dialog box from the top of the screen</param>
        /// <returns>An InputBoxResult object with the Text and the OK property set to true when OK was clicked.</returns>
        public static InputBoxResult Show(String prompt, String title, String tip,
                                          String defaultResponse, InputBoxValidatingHandler validator,
                                          Int32 xpos, Int32 ypos) {
            using (InputBox form = new InputBox()) {
                form.labelPrompt.Text = prompt;
                form.Text = title;
                form.textBoxText.Text = defaultResponse;

                //201807 -- custom code
                ToolTip buttonToolTip = new ToolTip();
                buttonToolTip.ToolTipTitle = "Remember...";
                buttonToolTip.UseFading = true;
                buttonToolTip.UseAnimation = true;
                buttonToolTip.IsBalloon = false;
                buttonToolTip.ShowAlways = true;
                buttonToolTip.AutoPopDelay = 5000;
                buttonToolTip.InitialDelay = 1000;
                buttonToolTip.ReshowDelay = 500;
                buttonToolTip.SetToolTip(form.textBoxText, tip);                
                //custom code -- end


                if (xpos >= 0 && ypos >= 0) {
                    form.StartPosition = FormStartPosition.Manual;
                    form.Left = xpos;
                    form.Top = ypos;
                }
                form.Validator = validator;

                DialogResult result = form.ShowDialog();

                InputBoxResult retval = new InputBoxResult();
                if (result == DialogResult.OK) {
                    retval.Text = form.textBoxText.Text;
                    retval.OK = true;
                }
                return retval;
            }
        }

        /// <summary>
        /// Displays a prompt in a dialog box, waits for the user to input text or click a button.
        /// </summary>
        /// <param name="prompt">String expression displayed as the message in the dialog box</param>
        /// <param name="title">String expression displayed in the title bar of the dialog box</param>
        /// <param name="defaultResponse">String expression displayed in the text box as the default response</param>
        /// <param name="validator">Delegate used to validate the text</param>
        /// <returns>An InputBoxResult object with the Text and the OK property set to true when OK was clicked.</returns>
        public static InputBoxResult Show(String prompt, String title, String defaultText, String tip, InputBoxValidatingHandler validator) {
            return Show(prompt, title, tip, defaultText, validator, -1, -1);
        }


        /// <summary>
        /// Reset the ErrorProvider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_TextChanged(object sender, System.EventArgs e) {
            errorProviderText.SetError(textBoxText, "");
        }

        /// <summary>
        /// Validate the Text using the Validator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (Validator != null) {
                InputBoxValidatingArgs args = new InputBoxValidatingArgs();
                args.Text = textBoxText.Text;
                Validator(this, args);
                if (args.Cancel) {
                    e.Cancel = true;
                    errorProviderText.SetError(textBoxText, args.Message);
                }
            }
        }

        //protected InputBoxValidatingHandler Validator {
        protected InputBoxValidatingHandler Validator {
            get {
                return (this._validator);
            }
            set {
                this._validator = value;
            }
        }

        //201808 - CUSTOM CODE
        private void textBoxText_DragOver(object sender, DragEventArgs e) {
            String[] files = (String[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0) {
                textBoxText.Text = files[0];
            }
        }
        //201808 - CUSTOM CODE -- END
    }

    /// <summary>
    /// Class used to store the result of an InputBox.Show message.
    /// </summary>
    public class InputBoxResult {
        public bool OK;
        public string Text;
    }

    /// <summary>
    /// EventArgs used to Validate an InputBox
    /// </summary>
    public class InputBoxValidatingArgs : EventArgs {
        public string Text;
        public string Message;
        public bool Cancel;
    }

    /// <summary>
    /// Delegate used to Validate an InputBox
    /// </summary>
    public delegate void InputBoxValidatingHandler(object sender, InputBoxValidatingArgs e);
}
