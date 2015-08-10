namespace CreateScratchCardNumbers
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxMinNumber = new System.Windows.Forms.TextBox();
            this.textBoxMaxNumber = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonGetNewName = new System.Windows.Forms.Button();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.buttonSelectFiles = new System.Windows.Forms.Button();
            this.labelListOfFilesSelecte = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mainMenu2 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mainMenu3 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.buttonOpenExclude = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonViewExcludeFile = new System.Windows.Forms.Button();
            this.checkBoxIncludeExcludeFile = new System.Windows.Forms.CheckBox();
            this.groupBoxNoOfDigits = new System.Windows.Forms.GroupBox();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.buttonViewFile = new System.Windows.Forms.Button();
            this.groupBoxNoOfDigits.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Enabled = false;
            this.buttonGenerate.Location = new System.Drawing.Point(256, 242);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(232, 108);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 1;
            this.textBoxQuantity.Text = "5000";
            this.textBoxQuantity.TextChanged += new System.EventHandler(this.textBoxQuantity_TextChanged);
            // 
            // textBoxMinNumber
            // 
            this.textBoxMinNumber.Location = new System.Drawing.Point(232, 142);
            this.textBoxMinNumber.Name = "textBoxMinNumber";
            this.textBoxMinNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinNumber.TabIndex = 2;
            this.textBoxMinNumber.Text = "0";
            this.textBoxMinNumber.TextChanged += new System.EventHandler(this.textBoxMinNumber_TextChanged);
            // 
            // textBoxMaxNumber
            // 
            this.textBoxMaxNumber.Location = new System.Drawing.Point(232, 175);
            this.textBoxMaxNumber.Name = "textBoxMaxNumber";
            this.textBoxMaxNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxNumber.TabIndex = 3;
            this.textBoxMaxNumber.Text = "999999999999";
            this.textBoxMaxNumber.TextChanged += new System.EventHandler(this.textBoxMaxNumber_TextChanged);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(151, 115);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(46, 13);
            this.labelQuantity.TabIndex = 5;
            this.labelQuantity.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Min number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max Number";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Control;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(12, 449);
            this.labelInfo.MinimumSize = new System.Drawing.Size(500, 50);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(500, 50);
            this.labelInfo.TabIndex = 8;
            this.labelInfo.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "File Name";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(232, 201);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(150, 20);
            this.textBoxFileName.TabIndex = 9;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged);
            // 
            // buttonGetNewName
            // 
            this.buttonGetNewName.Location = new System.Drawing.Point(389, 199);
            this.buttonGetNewName.Name = "buttonGetNewName";
            this.buttonGetNewName.Size = new System.Drawing.Size(97, 23);
            this.buttonGetNewName.TabIndex = 11;
            this.buttonGetNewName.Text = "Get New Name";
            this.buttonGetNewName.UseVisualStyleBackColor = true;
            this.buttonGetNewName.Click += new System.EventHandler(this.buttonGetNewName_Click);
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessing.ForeColor = System.Drawing.Color.Red;
            this.labelProcessing.Location = new System.Drawing.Point(174, 523);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(0, 23);
            this.labelProcessing.TabIndex = 12;
            this.labelProcessing.Click += new System.EventHandler(this.labelProcessing_Click);
            // 
            // buttonSelectFiles
            // 
            this.buttonSelectFiles.Location = new System.Drawing.Point(204, 315);
            this.buttonSelectFiles.Name = "buttonSelectFiles";
            this.buttonSelectFiles.Size = new System.Drawing.Size(151, 66);
            this.buttonSelectFiles.TabIndex = 13;
            this.buttonSelectFiles.Text = "Select multiple Files To Make Exclude File";
            this.buttonSelectFiles.UseVisualStyleBackColor = true;
            this.buttonSelectFiles.Click += new System.EventHandler(this.buttonSelectFiles_Click);
            // 
            // labelListOfFilesSelecte
            // 
            this.labelListOfFilesSelecte.AutoSize = true;
            this.labelListOfFilesSelecte.Location = new System.Drawing.Point(157, 399);
            this.labelListOfFilesSelecte.Name = "labelListOfFilesSelecte";
            this.labelListOfFilesSelecte.Size = new System.Drawing.Size(0, 13);
            this.labelListOfFilesSelecte.TabIndex = 14;
            this.labelListOfFilesSelecte.Click += new System.EventHandler(this.labelListOfFilesSelecte_Click);
            // 
            // mainMenu2
            // 
            this.mainMenu2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Test";
            // 
            // mainMenu3
            // 
            this.mainMenu3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Test";
            // 
            // buttonOpenExclude
            // 
            this.buttonOpenExclude.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenExclude.Name = "buttonOpenExclude";
            this.buttonOpenExclude.Size = new System.Drawing.Size(94, 38);
            this.buttonOpenExclude.TabIndex = 16;
            this.buttonOpenExclude.Text = "Open Exclude";
            this.buttonOpenExclude.UseVisualStyleBackColor = true;
            this.buttonOpenExclude.Click += new System.EventHandler(this.buttonOpenExclude_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(111, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 38);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonViewExcludeFile
            // 
            this.buttonViewExcludeFile.Location = new System.Drawing.Point(375, 321);
            this.buttonViewExcludeFile.Name = "buttonViewExcludeFile";
            this.buttonViewExcludeFile.Size = new System.Drawing.Size(75, 54);
            this.buttonViewExcludeFile.TabIndex = 18;
            this.buttonViewExcludeFile.Text = "View Exclude File";
            this.buttonViewExcludeFile.UseVisualStyleBackColor = true;
            this.buttonViewExcludeFile.Click += new System.EventHandler(this.buttonViewExcludeFile_Click);
            // 
            // checkBoxIncludeExcludeFile
            // 
            this.checkBoxIncludeExcludeFile.AutoSize = true;
            this.checkBoxIncludeExcludeFile.Checked = true;
            this.checkBoxIncludeExcludeFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeExcludeFile.Location = new System.Drawing.Point(261, 282);
            this.checkBoxIncludeExcludeFile.Name = "checkBoxIncludeExcludeFile";
            this.checkBoxIncludeExcludeFile.Size = new System.Drawing.Size(121, 17);
            this.checkBoxIncludeExcludeFile.TabIndex = 19;
            this.checkBoxIncludeExcludeFile.Text = "Include Exclude File";
            this.checkBoxIncludeExcludeFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxNoOfDigits
            // 
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton16);
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton15);
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton14);
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton13);
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton12);
            this.groupBoxNoOfDigits.Controls.Add(this.radioButton11);
            this.groupBoxNoOfDigits.Location = new System.Drawing.Point(12, 76);
            this.groupBoxNoOfDigits.Name = "groupBoxNoOfDigits";
            this.groupBoxNoOfDigits.Size = new System.Drawing.Size(128, 213);
            this.groupBoxNoOfDigits.TabIndex = 20;
            this.groupBoxNoOfDigits.TabStop = false;
            this.groupBoxNoOfDigits.Text = "No of Digit Scratch No";
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Checked = true;
            this.radioButton16.Location = new System.Drawing.Point(39, 145);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(66, 17);
            this.radioButton16.TabIndex = 5;
            this.radioButton16.TabStop = true;
            this.radioButton16.Text = "16 Digits";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(39, 122);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(66, 17);
            this.radioButton15.TabIndex = 4;
            this.radioButton15.Text = "15 Digits";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(39, 99);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(66, 17);
            this.radioButton14.TabIndex = 3;
            this.radioButton14.Text = "14 Digits";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(39, 76);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(66, 17);
            this.radioButton13.TabIndex = 2;
            this.radioButton13.Text = "13 Digits";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(39, 49);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(66, 17);
            this.radioButton12.TabIndex = 1;
            this.radioButton12.Text = "12 Digits";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(39, 26);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(66, 17);
            this.radioButton11.TabIndex = 0;
            this.radioButton11.Text = "11 Digits";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // buttonViewFile
            // 
            this.buttonViewFile.Location = new System.Drawing.Point(493, 199);
            this.buttonViewFile.Name = "buttonViewFile";
            this.buttonViewFile.Size = new System.Drawing.Size(29, 23);
            this.buttonViewFile.TabIndex = 21;
            this.buttonViewFile.Text = "V";
            this.buttonViewFile.UseVisualStyleBackColor = true;
            this.buttonViewFile.Click += new System.EventHandler(this.buttonViewFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 639);
            this.Controls.Add(this.buttonViewFile);
            this.Controls.Add(this.groupBoxNoOfDigits);
            this.Controls.Add(this.checkBoxIncludeExcludeFile);
            this.Controls.Add(this.buttonViewExcludeFile);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOpenExclude);
            this.Controls.Add(this.labelListOfFilesSelecte);
            this.Controls.Add(this.buttonSelectFiles);
            this.Controls.Add(this.labelProcessing);
            this.Controls.Add(this.buttonGetNewName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxMaxNumber);
            this.Controls.Add(this.textBoxMinNumber);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.buttonGenerate);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxNoOfDigits.ResumeLayout(false);
            this.groupBoxNoOfDigits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxMinNumber;
        private System.Windows.Forms.TextBox textBoxMaxNumber;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonGetNewName;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Button buttonSelectFiles;
        private System.Windows.Forms.Label labelListOfFilesSelecte;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MainMenu mainMenu3;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Button buttonOpenExclude;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonViewExcludeFile;
        private System.Windows.Forms.CheckBox checkBoxIncludeExcludeFile;
        private System.Windows.Forms.GroupBox groupBoxNoOfDigits;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.Button buttonViewFile;
    }
}

