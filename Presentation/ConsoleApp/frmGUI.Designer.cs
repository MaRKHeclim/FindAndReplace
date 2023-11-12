namespace FindAndReplace
{
    partial class frmGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            thxFind = new TextBox();
            tbxReplace = new TextBox();
            tbxSearchIn = new TextBox();
            lbxCSVs = new ListBox();
            lbxSearchIn = new ListBox();
            rbnSearchIn_Directories = new RadioButton();
            rbnSearchInFiles = new RadioButton();
            rbnSearchInText = new RadioButton();
            gbxSearchIn = new GroupBox();
            gbxFindWithin = new GroupBox();
            cbxFindWithin_FileContents = new CheckBox();
            cbxFindWithin_DirectoryName = new CheckBox();
            cbxFindWithin_FileName = new CheckBox();
            cbxCreateBackups = new CheckBox();
            rbnFindMode_Normal = new RadioButton();
            rbnFindMode_Extended = new RadioButton();
            rbnFindMode_RegEx = new RadioButton();
            gbxFindMode = new GroupBox();
            cbxMatchWholeWordsOnly = new CheckBox();
            cbxCaseSensitiveMatching = new CheckBox();
            sbrStatusBar = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            pbrProgressBar = new ToolStripProgressBar();
            lblProgress = new ToolStripStatusLabel();
            btnCSV_Browse = new Button();
            btnSearchIn_Browse = new Button();
            btnCSV_Clear = new Button();
            btnSearchIn_Clear = new Button();
            btnCSV_New = new Button();
            gbxSearchWith = new GroupBox();
            rbnSearchWith_ManualEntry = new RadioButton();
            rbnSearchWith_CSVs = new RadioButton();
            btnReplace = new Button();
            btnUndo = new Button();
            cbxSaveSearchesToCSV = new CheckBox();
            btnManualEntry_Switch = new Button();
            gbxSearchIn.SuspendLayout();
            gbxFindWithin.SuspendLayout();
            gbxFindMode.SuspendLayout();
            sbrStatusBar.SuspendLayout();
            gbxSearchWith.SuspendLayout();
            SuspendLayout();
            // 
            // thxFind
            // 
            thxFind.Location = new Point(204, 56);
            thxFind.Name = "thxFind";
            thxFind.Size = new Size(232, 23);
            thxFind.TabIndex = 0;
            // 
            // tbxReplace
            // 
            tbxReplace.Location = new Point(204, 85);
            tbxReplace.Name = "tbxReplace";
            tbxReplace.Size = new Size(232, 23);
            tbxReplace.TabIndex = 1;
            tbxReplace.TextChanged += textBox2_TextChanged;
            // 
            // tbxSearchIn
            // 
            tbxSearchIn.Location = new Point(204, 163);
            tbxSearchIn.Multiline = true;
            tbxSearchIn.Name = "tbxSearchIn";
            tbxSearchIn.ScrollBars = ScrollBars.Both;
            tbxSearchIn.Size = new Size(232, 188);
            tbxSearchIn.TabIndex = 2;
            tbxSearchIn.TextChanged += textBox3_TextChanged;
            // 
            // lbxCSVs
            // 
            lbxCSVs.FormattingEnabled = true;
            lbxCSVs.HorizontalScrollbar = true;
            lbxCSVs.ItemHeight = 15;
            lbxCSVs.Location = new Point(204, 56);
            lbxCSVs.Name = "lbxCSVs";
            lbxCSVs.Size = new Size(232, 49);
            lbxCSVs.TabIndex = 3;
            lbxCSVs.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lbxSearchIn
            // 
            lbxSearchIn.FormattingEnabled = true;
            lbxSearchIn.HorizontalScrollbar = true;
            lbxSearchIn.ItemHeight = 15;
            lbxSearchIn.Location = new Point(204, 163);
            lbxSearchIn.Name = "lbxSearchIn";
            lbxSearchIn.Size = new Size(232, 184);
            lbxSearchIn.TabIndex = 4;
            lbxSearchIn.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // rbnSearchIn_Directories
            // 
            rbnSearchIn_Directories.AutoSize = true;
            rbnSearchIn_Directories.Location = new Point(6, 13);
            rbnSearchIn_Directories.Name = "rbnSearchIn_Directories";
            rbnSearchIn_Directories.Size = new Size(81, 19);
            rbnSearchIn_Directories.TabIndex = 5;
            rbnSearchIn_Directories.TabStop = true;
            rbnSearchIn_Directories.Text = "Directories";
            rbnSearchIn_Directories.UseVisualStyleBackColor = true;
            // 
            // rbnSearchInFiles
            // 
            rbnSearchInFiles.AutoSize = true;
            rbnSearchInFiles.Checked = true;
            rbnSearchInFiles.Location = new Point(98, 13);
            rbnSearchInFiles.Name = "rbnSearchInFiles";
            rbnSearchInFiles.Size = new Size(48, 19);
            rbnSearchInFiles.TabIndex = 6;
            rbnSearchInFiles.TabStop = true;
            rbnSearchInFiles.Text = "Files";
            rbnSearchInFiles.UseVisualStyleBackColor = true;
            // 
            // rbnSearchInText
            // 
            rbnSearchInText.AutoSize = true;
            rbnSearchInText.Location = new Point(152, 13);
            rbnSearchInText.Name = "rbnSearchInText";
            rbnSearchInText.Size = new Size(46, 19);
            rbnSearchInText.TabIndex = 7;
            rbnSearchInText.TabStop = true;
            rbnSearchInText.Text = "Text";
            rbnSearchInText.UseVisualStyleBackColor = true;
            // 
            // gbxSearchIn
            // 
            gbxSearchIn.Controls.Add(rbnSearchInFiles);
            gbxSearchIn.Controls.Add(rbnSearchInText);
            gbxSearchIn.Controls.Add(rbnSearchIn_Directories);
            gbxSearchIn.Location = new Point(204, 116);
            gbxSearchIn.Name = "gbxSearchIn";
            gbxSearchIn.Size = new Size(232, 38);
            gbxSearchIn.TabIndex = 8;
            gbxSearchIn.TabStop = false;
            gbxSearchIn.Text = "Search In";
            // 
            // gbxFindWithin
            // 
            gbxFindWithin.Controls.Add(cbxFindWithin_FileContents);
            gbxFindWithin.Controls.Add(cbxFindWithin_DirectoryName);
            gbxFindWithin.Controls.Add(cbxFindWithin_FileName);
            gbxFindWithin.Location = new Point(12, 12);
            gbxFindWithin.Name = "gbxFindWithin";
            gbxFindWithin.Size = new Size(183, 98);
            gbxFindWithin.TabIndex = 9;
            gbxFindWithin.TabStop = false;
            gbxFindWithin.Text = "Find Within";
            gbxFindWithin.Enter += groupBox2_Enter;
            // 
            // cbxFindWithin_FileContents
            // 
            cbxFindWithin_FileContents.AutoSize = true;
            cbxFindWithin_FileContents.Checked = true;
            cbxFindWithin_FileContents.CheckState = CheckState.Checked;
            cbxFindWithin_FileContents.Location = new Point(6, 72);
            cbxFindWithin_FileContents.Name = "cbxFindWithin_FileContents";
            cbxFindWithin_FileContents.Size = new Size(95, 19);
            cbxFindWithin_FileContents.TabIndex = 2;
            cbxFindWithin_FileContents.Text = "File Contents";
            cbxFindWithin_FileContents.UseVisualStyleBackColor = true;
            // 
            // cbxFindWithin_DirectoryName
            // 
            cbxFindWithin_DirectoryName.AutoSize = true;
            cbxFindWithin_DirectoryName.Location = new Point(6, 22);
            cbxFindWithin_DirectoryName.Name = "cbxFindWithin_DirectoryName";
            cbxFindWithin_DirectoryName.Size = new Size(109, 19);
            cbxFindWithin_DirectoryName.TabIndex = 1;
            cbxFindWithin_DirectoryName.Text = "Directory Name";
            cbxFindWithin_DirectoryName.UseVisualStyleBackColor = true;
            // 
            // cbxFindWithin_FileName
            // 
            cbxFindWithin_FileName.AutoSize = true;
            cbxFindWithin_FileName.Location = new Point(6, 47);
            cbxFindWithin_FileName.Name = "cbxFindWithin_FileName";
            cbxFindWithin_FileName.Size = new Size(79, 19);
            cbxFindWithin_FileName.TabIndex = 0;
            cbxFindWithin_FileName.Text = "File Name";
            cbxFindWithin_FileName.UseVisualStyleBackColor = true;
            // 
            // cbxCreateBackups
            // 
            cbxCreateBackups.AutoSize = true;
            cbxCreateBackups.Location = new Point(18, 267);
            cbxCreateBackups.Name = "cbxCreateBackups";
            cbxCreateBackups.Size = new Size(107, 19);
            cbxCreateBackups.TabIndex = 3;
            cbxCreateBackups.Text = "Create Backups";
            cbxCreateBackups.UseVisualStyleBackColor = true;
            // 
            // rbnFindMode_Normal
            // 
            rbnFindMode_Normal.AutoSize = true;
            rbnFindMode_Normal.Location = new Point(6, 22);
            rbnFindMode_Normal.Name = "rbnFindMode_Normal";
            rbnFindMode_Normal.Size = new Size(65, 19);
            rbnFindMode_Normal.TabIndex = 10;
            rbnFindMode_Normal.TabStop = true;
            rbnFindMode_Normal.Text = "Normal";
            rbnFindMode_Normal.UseVisualStyleBackColor = true;
            // 
            // rbnFindMode_Extended
            // 
            rbnFindMode_Extended.AutoSize = true;
            rbnFindMode_Extended.Checked = true;
            rbnFindMode_Extended.Location = new Point(6, 47);
            rbnFindMode_Extended.Name = "rbnFindMode_Extended";
            rbnFindMode_Extended.Size = new Size(257, 19);
            rbnFindMode_Extended.TabIndex = 11;
            rbnFindMode_Extended.TabStop = true;
            rbnFindMode_Extended.Text = "Extended (\\n, \\r, \\t, \\', \\\", \\\\, \\0, \\a, \\b, \\f, \\v)";
            rbnFindMode_Extended.UseVisualStyleBackColor = true;
            // 
            // rbnFindMode_RegEx
            // 
            rbnFindMode_RegEx.AutoSize = true;
            rbnFindMode_RegEx.Location = new Point(6, 72);
            rbnFindMode_RegEx.Name = "rbnFindMode_RegEx";
            rbnFindMode_RegEx.Size = new Size(124, 19);
            rbnFindMode_RegEx.TabIndex = 12;
            rbnFindMode_RegEx.TabStop = true;
            rbnFindMode_RegEx.Text = "Regular Expression";
            rbnFindMode_RegEx.UseVisualStyleBackColor = true;
            // 
            // gbxFindMode
            // 
            gbxFindMode.Controls.Add(rbnFindMode_RegEx);
            gbxFindMode.Controls.Add(rbnFindMode_Extended);
            gbxFindMode.Controls.Add(rbnFindMode_Normal);
            gbxFindMode.Location = new Point(12, 116);
            gbxFindMode.Name = "gbxFindMode";
            gbxFindMode.Size = new Size(183, 95);
            gbxFindMode.TabIndex = 13;
            gbxFindMode.TabStop = false;
            gbxFindMode.Text = "Find Mode";
            gbxFindMode.Enter += groupBox3_Enter;
            // 
            // cbxMatchWholeWordsOnly
            // 
            cbxMatchWholeWordsOnly.AutoSize = true;
            cbxMatchWholeWordsOnly.Location = new Point(18, 217);
            cbxMatchWholeWordsOnly.Name = "cbxMatchWholeWordsOnly";
            cbxMatchWholeWordsOnly.Size = new Size(162, 19);
            cbxMatchWholeWordsOnly.TabIndex = 14;
            cbxMatchWholeWordsOnly.Text = "Match Whole Words Only";
            cbxMatchWholeWordsOnly.UseVisualStyleBackColor = true;
            cbxMatchWholeWordsOnly.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // cbxCaseSensitiveMatching
            // 
            cbxCaseSensitiveMatching.AutoSize = true;
            cbxCaseSensitiveMatching.Location = new Point(18, 242);
            cbxCaseSensitiveMatching.Name = "cbxCaseSensitiveMatching";
            cbxCaseSensitiveMatching.Size = new Size(154, 19);
            cbxCaseSensitiveMatching.TabIndex = 15;
            cbxCaseSensitiveMatching.Text = "Case Sensitive Matching";
            cbxCaseSensitiveMatching.UseVisualStyleBackColor = true;
            // 
            // sbrStatusBar
            // 
            sbrStatusBar.Items.AddRange(new ToolStripItem[] { lblStatus, pbrProgressBar, lblProgress });
            sbrStatusBar.Location = new Point(0, 397);
            sbrStatusBar.Name = "sbrStatusBar";
            sbrStatusBar.RightToLeft = RightToLeft.No;
            sbrStatusBar.Size = new Size(619, 22);
            sbrStatusBar.TabIndex = 16;
            sbrStatusBar.Text = "sbrStatusBar";
            // 
            // lblStatus
            // 
            lblStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(118, 17);
            lblStatus.Text = "toolStripStatusLabel1";
            // 
            // pbrProgressBar
            // 
            pbrProgressBar.Name = "pbrProgressBar";
            pbrProgressBar.Size = new Size(100, 16);
            // 
            // lblProgress
            // 
            lblProgress.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(118, 17);
            lblProgress.Text = "toolStripStatusLabel2";
            // 
            // btnCSV_Browse
            // 
            btnCSV_Browse.Location = new Point(442, 56);
            btnCSV_Browse.Name = "btnCSV_Browse";
            btnCSV_Browse.Size = new Size(80, 30);
            btnCSV_Browse.TabIndex = 17;
            btnCSV_Browse.Text = "Browse...";
            btnCSV_Browse.UseVisualStyleBackColor = true;
            // 
            // btnSearchIn_Browse
            // 
            btnSearchIn_Browse.Location = new Point(443, 163);
            btnSearchIn_Browse.Name = "btnSearchIn_Browse";
            btnSearchIn_Browse.Size = new Size(80, 30);
            btnSearchIn_Browse.TabIndex = 18;
            btnSearchIn_Browse.Text = "Browse...";
            btnSearchIn_Browse.UseVisualStyleBackColor = true;
            btnSearchIn_Browse.Click += button2_Click;
            // 
            // btnCSV_Clear
            // 
            btnCSV_Clear.Location = new Point(528, 56);
            btnCSV_Clear.Name = "btnCSV_Clear";
            btnCSV_Clear.Size = new Size(80, 30);
            btnCSV_Clear.TabIndex = 19;
            btnCSV_Clear.Text = "Clear";
            btnCSV_Clear.UseVisualStyleBackColor = true;
            // 
            // btnSearchIn_Clear
            // 
            btnSearchIn_Clear.Location = new Point(529, 163);
            btnSearchIn_Clear.Name = "btnSearchIn_Clear";
            btnSearchIn_Clear.Size = new Size(80, 30);
            btnSearchIn_Clear.TabIndex = 20;
            btnSearchIn_Clear.Text = "Clear";
            btnSearchIn_Clear.UseVisualStyleBackColor = true;
            btnSearchIn_Clear.Click += button4_Click;
            // 
            // btnCSV_New
            // 
            btnCSV_New.Location = new Point(442, 92);
            btnCSV_New.Name = "btnCSV_New";
            btnCSV_New.Size = new Size(80, 30);
            btnCSV_New.TabIndex = 21;
            btnCSV_New.Text = "New";
            btnCSV_New.UseVisualStyleBackColor = true;
            // 
            // gbxSearchWith
            // 
            gbxSearchWith.Controls.Add(rbnSearchWith_CSVs);
            gbxSearchWith.Controls.Add(rbnSearchWith_ManualEntry);
            gbxSearchWith.Location = new Point(204, 12);
            gbxSearchWith.Name = "gbxSearchWith";
            gbxSearchWith.Size = new Size(232, 38);
            gbxSearchWith.TabIndex = 9;
            gbxSearchWith.TabStop = false;
            gbxSearchWith.Text = "Search With";
            // 
            // rbnSearchWith_ManualEntry
            // 
            rbnSearchWith_ManualEntry.AutoSize = true;
            rbnSearchWith_ManualEntry.Checked = true;
            rbnSearchWith_ManualEntry.Location = new Point(98, 13);
            rbnSearchWith_ManualEntry.Name = "rbnSearchWith_ManualEntry";
            rbnSearchWith_ManualEntry.Size = new Size(95, 19);
            rbnSearchWith_ManualEntry.TabIndex = 6;
            rbnSearchWith_ManualEntry.TabStop = true;
            rbnSearchWith_ManualEntry.Text = "Manual Entry";
            rbnSearchWith_ManualEntry.UseVisualStyleBackColor = true;
            // 
            // rbnSearchWith_CSVs
            // 
            rbnSearchWith_CSVs.AutoSize = true;
            rbnSearchWith_CSVs.Location = new Point(6, 13);
            rbnSearchWith_CSVs.Name = "rbnSearchWith_CSVs";
            rbnSearchWith_CSVs.Size = new Size(59, 19);
            rbnSearchWith_CSVs.TabIndex = 5;
            rbnSearchWith_CSVs.TabStop = true;
            rbnSearchWith_CSVs.Text = "CSV(s)";
            rbnSearchWith_CSVs.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(290, 357);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(80, 30);
            btnReplace.TabIndex = 22;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(204, 357);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(80, 30);
            btnUndo.TabIndex = 23;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            // 
            // cbxSaveSearchesToCSV
            // 
            cbxSaveSearchesToCSV.AutoSize = true;
            cbxSaveSearchesToCSV.Location = new Point(376, 364);
            cbxSaveSearchesToCSV.Name = "cbxSaveSearchesToCSV";
            cbxSaveSearchesToCSV.Size = new Size(137, 19);
            cbxSaveSearchesToCSV.TabIndex = 24;
            cbxSaveSearchesToCSV.Text = "Save Searches to CSV";
            cbxSaveSearchesToCSV.UseVisualStyleBackColor = true;
            // 
            // btnManualEntry_Switch
            // 
            btnManualEntry_Switch.Location = new Point(443, 56);
            btnManualEntry_Switch.Name = "btnManualEntry_Switch";
            btnManualEntry_Switch.Size = new Size(80, 30);
            btnManualEntry_Switch.TabIndex = 25;
            btnManualEntry_Switch.Text = "Switch";
            btnManualEntry_Switch.UseVisualStyleBackColor = true;
            // 
            // frmGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 419);
            Controls.Add(cbxSaveSearchesToCSV);
            Controls.Add(btnUndo);
            Controls.Add(btnReplace);
            Controls.Add(gbxSearchWith);
            Controls.Add(btnCSV_New);
            Controls.Add(btnSearchIn_Clear);
            Controls.Add(btnCSV_Clear);
            Controls.Add(btnSearchIn_Browse);
            Controls.Add(sbrStatusBar);
            Controls.Add(cbxCaseSensitiveMatching);
            Controls.Add(cbxMatchWholeWordsOnly);
            Controls.Add(gbxFindMode);
            Controls.Add(cbxCreateBackups);
            Controls.Add(gbxFindWithin);
            Controls.Add(gbxSearchIn);
            Controls.Add(tbxSearchIn);
            Controls.Add(tbxReplace);
            Controls.Add(thxFind);
            Controls.Add(lbxCSVs);
            Controls.Add(btnManualEntry_Switch);
            Controls.Add(btnCSV_Browse);
            Controls.Add(lbxSearchIn);
            Name = "frmGUI";
            Text = "Form1";
            Load += GUI_Load;
            gbxSearchIn.ResumeLayout(false);
            gbxSearchIn.PerformLayout();
            gbxFindWithin.ResumeLayout(false);
            gbxFindWithin.PerformLayout();
            gbxFindMode.ResumeLayout(false);
            gbxFindMode.PerformLayout();
            sbrStatusBar.ResumeLayout(false);
            sbrStatusBar.PerformLayout();
            gbxSearchWith.ResumeLayout(false);
            gbxSearchWith.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox thxFind;
        private TextBox tbxReplace;
        private TextBox tbxSearchIn;
        private ListBox lbxCSVs;
        private ListBox lbxSearchIn;
        private RadioButton rbnSearchIn_Directories;
        private RadioButton rbnSearchInFiles;
        private RadioButton rbnSearchInText;
        private GroupBox gbxSearchIn;
        private GroupBox gbxFindWithin;
        private CheckBox cbxFindWithin_FileContents;
        private CheckBox cbxFindWithin_DirectoryName;
        private CheckBox cbxFindWithin_FileName;
        private CheckBox cbxCreateBackups;
        private RadioButton rbnFindMode_Normal;
        private RadioButton rbnFindMode_Extended;
        private RadioButton rbnFindMode_RegEx;
        private GroupBox gbxFindMode;
        private CheckBox cbxMatchWholeWordsOnly;
        private CheckBox cbxCaseSensitiveMatching;
        private StatusStrip sbrStatusBar;
        private ToolStripStatusLabel lblStatus;
        private ToolStripProgressBar pbrProgressBar;
        private ToolStripStatusLabel lblProgress;
        private Button btnCSV_Browse;
        private Button btnSearchIn_Browse;
        private Button btnCSV_Clear;
        private Button btnSearchIn_Clear;
        private Button btnCSV_New;
        private GroupBox gbxSearchWith;
        private RadioButton rbnSearchWith_ManualEntry;
        private RadioButton rbnSearchWith_CSVs;
        private Button btnReplace;
        private Button btnUndo;
        private CheckBox cbxSaveSearchesToCSV;
        private Button btnManualEntry_Switch;
    }
}