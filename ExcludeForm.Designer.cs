namespace CreateScratchCardNumbers
{
    partial class ExcludeForm
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
            this.labelListOfFilesSelecte = new System.Windows.Forms.Label();
            this.buttonSelectFiles = new System.Windows.Forms.Button();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.buttonOpenGenerateScratchCardNumbers = new System.Windows.Forms.Button();
            this.groupBoxActions = new System.Windows.Forms.GroupBox();
            this.RadioButtonNewDataLessExcludedData = new System.Windows.Forms.RadioButton();
            this.RadioButtonExcludedDataLessNewData = new System.Windows.Forms.RadioButton();
            this.radioButtonAdd = new System.Windows.Forms.RadioButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.groupBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelListOfFilesSelecte
            // 
            this.labelListOfFilesSelecte.AutoSize = true;
            this.labelListOfFilesSelecte.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelListOfFilesSelecte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelListOfFilesSelecte.Location = new System.Drawing.Point(12, 362);
            this.labelListOfFilesSelecte.Name = "labelListOfFilesSelecte";
            this.labelListOfFilesSelecte.Size = new System.Drawing.Size(2, 15);
            this.labelListOfFilesSelecte.TabIndex = 17;
            // 
            // buttonSelectFiles
            // 
            this.buttonSelectFiles.Location = new System.Drawing.Point(278, 80);
            this.buttonSelectFiles.Name = "buttonSelectFiles";
            this.buttonSelectFiles.Size = new System.Drawing.Size(169, 66);
            this.buttonSelectFiles.TabIndex = 16;
            this.buttonSelectFiles.Text = "Select multiple Files ";
            this.buttonSelectFiles.UseVisualStyleBackColor = true;
            this.buttonSelectFiles.Click += new System.EventHandler(this.buttonSelectFiles_Click);
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelProcessing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProcessing.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessing.ForeColor = System.Drawing.Color.Red;
            this.labelProcessing.Location = new System.Drawing.Point(161, 272);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(2, 25);
            this.labelProcessing.TabIndex = 15;
            // 
            // buttonOpenGenerateScratchCardNumbers
            // 
            this.buttonOpenGenerateScratchCardNumbers.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenGenerateScratchCardNumbers.Name = "buttonOpenGenerateScratchCardNumbers";
            this.buttonOpenGenerateScratchCardNumbers.Size = new System.Drawing.Size(151, 66);
            this.buttonOpenGenerateScratchCardNumbers.TabIndex = 18;
            this.buttonOpenGenerateScratchCardNumbers.Text = "Generate ScratchCard Numbers";
            this.buttonOpenGenerateScratchCardNumbers.UseVisualStyleBackColor = true;
            this.buttonOpenGenerateScratchCardNumbers.Click += new System.EventHandler(this.buttonOpenGenerateScratchCardNumbers_Click);
            // 
            // groupBoxActions
            // 
            this.groupBoxActions.Controls.Add(this.RadioButtonNewDataLessExcludedData);
            this.groupBoxActions.Controls.Add(this.RadioButtonExcludedDataLessNewData);
            this.groupBoxActions.Controls.Add(this.radioButtonAdd);
            this.groupBoxActions.Location = new System.Drawing.Point(75, 139);
            this.groupBoxActions.Name = "groupBoxActions";
            this.groupBoxActions.Size = new System.Drawing.Size(210, 84);
            this.groupBoxActions.TabIndex = 19;
            this.groupBoxActions.TabStop = false;
            this.groupBoxActions.Text = "Exclude File";
            // 
            // RadioButtonNewDataLessExcludedData
            // 
            this.RadioButtonNewDataLessExcludedData.AutoSize = true;
            this.RadioButtonNewDataLessExcludedData.Location = new System.Drawing.Point(30, 37);
            this.RadioButtonNewDataLessExcludedData.Name = "RadioButtonNewDataLessExcludedData";
            this.RadioButtonNewDataLessExcludedData.Size = new System.Drawing.Size(164, 17);
            this.RadioButtonNewDataLessExcludedData.TabIndex = 2;
            this.RadioButtonNewDataLessExcludedData.Text = "(New Data) - (Excluded Data)";
            this.RadioButtonNewDataLessExcludedData.UseVisualStyleBackColor = true;
            // 
            // RadioButtonExcludedDataLessNewData
            // 
            this.RadioButtonExcludedDataLessNewData.AutoSize = true;
            this.RadioButtonExcludedDataLessNewData.Location = new System.Drawing.Point(30, 54);
            this.RadioButtonExcludedDataLessNewData.Name = "RadioButtonExcludedDataLessNewData";
            this.RadioButtonExcludedDataLessNewData.Size = new System.Drawing.Size(158, 17);
            this.RadioButtonExcludedDataLessNewData.TabIndex = 1;
            this.RadioButtonExcludedDataLessNewData.Text = "(Excluded Data)-(New Data)";
             // 
            // radioButtonAdd
            // 
            this.radioButtonAdd.AutoSize = true;
            this.radioButtonAdd.Checked = true;
            this.radioButtonAdd.Location = new System.Drawing.Point(30, 20);
            this.radioButtonAdd.Name = "radioButtonAdd";
            this.radioButtonAdd.Size = new System.Drawing.Size(150, 17);
            this.radioButtonAdd.TabIndex = 0;
            this.radioButtonAdd.TabStop = true;
            this.radioButtonAdd.Text = "Add File(s) To Exclude File";
            this.radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.Color.Red;
            this.buttonClose.Location = new System.Drawing.Point(200, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(94, 38);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(12, 338);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(2, 15);
            this.labelInfo.TabIndex = 21;
            // 
            // ExcludeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 630);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxActions);
            this.Controls.Add(this.buttonOpenGenerateScratchCardNumbers);
            this.Controls.Add(this.labelListOfFilesSelecte);
            this.Controls.Add(this.buttonSelectFiles);
            this.Controls.Add(this.labelProcessing);
            this.Name = "ExcludeForm";
            this.Text = "ExcludeForm";
            this.groupBoxActions.ResumeLayout(false);
            this.groupBoxActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListOfFilesSelecte;
        private System.Windows.Forms.Button buttonSelectFiles;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Button buttonOpenGenerateScratchCardNumbers;
        private System.Windows.Forms.GroupBox groupBoxActions;
        private System.Windows.Forms.RadioButton RadioButtonExcludedDataLessNewData;
        private System.Windows.Forms.RadioButton radioButtonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.RadioButton RadioButtonNewDataLessExcludedData;
        private System.Windows.Forms.Label labelInfo;

    }
}