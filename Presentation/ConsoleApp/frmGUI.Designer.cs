namespace FindAndReplace
{
	using System.Drawing;
	using System.Windows.Forms;

	partial class FRMGui
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
				this.components.Dispose();
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
			gbxFindWithin = new GroupBox();
			cbxFindWithin_FileContents = new CheckBox();
			cbxFindWithin_DirectoryName = new CheckBox();
			cbxFindWithin_FileName = new CheckBox();
			gbxSearchWith = new GroupBox();
			rbnSearchWith_CSVs = new RadioButton();
			rbnSearchWith_ManualEntry = new RadioButton();
			tbxFind = new TextBox();
			tbxReplace = new TextBox();
			lbxCSVs = new ListBox();
			btnManualEntry_Switch = new Button();
			btnCSV_Browse = new Button();
			btnCSV_Clear = new Button();
			btnCSV_New = new Button();
			gbxFindMode = new GroupBox();
			rbnFindMode_RegEx = new RadioButton();
			rbnFindMode_Extended = new RadioButton();
			rbnFindMode_Normal = new RadioButton();
			gbxSearchIn = new GroupBox();
			rbnSearchIn_Files = new RadioButton();
			rbnSearchIn_Text = new RadioButton();
			rbnSearchIn_Directories = new RadioButton();
			tbxSearchIn = new TextBox();
			lbxSearchIn = new ListBox();
			btnSearchIn_Browse = new Button();
			btnSearchIn_Clear = new Button();
			cbxMatchWholeWordsOnly = new CheckBox();
			cbxCaseSensitiveMatching = new CheckBox();
			cbxCreateBackups = new CheckBox();
			gbxSaveSearches = new GroupBox();
			rbnSaveSearches_Append = new RadioButton();
			rbnSaveSearches_Disable = new RadioButton();
			rbnSaveSearches_New = new RadioButton();
			rbnSaveSearches_Overwirte = new RadioButton();
			btnReplace = new Button();
			btnUndo = new Button();
			sbrStatusBar = new StatusStrip();
			lblStatus = new ToolStripStatusLabel();
			pbrProgressBar = new ToolStripProgressBar();
			lblProgress = new ToolStripStatusLabel();
			gbxFindWithin.SuspendLayout();
			gbxSearchWith.SuspendLayout();
			gbxFindMode.SuspendLayout();
			gbxSearchIn.SuspendLayout();
			sbrStatusBar.SuspendLayout();
			gbxSaveSearches.SuspendLayout();
			this.SuspendLayout();
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
			// 
			// cbxFindWithin_FileContents
			// 
			cbxFindWithin_FileContents.AutoSize = true;
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
			// rbnSearchWith_ManualEntry
			// 
			rbnSearchWith_ManualEntry.AutoSize = true;
			rbnSearchWith_ManualEntry.Location = new Point(98, 13);
			rbnSearchWith_ManualEntry.Name = "rbnSearchWith_ManualEntry";
			rbnSearchWith_ManualEntry.Size = new Size(95, 19);
			rbnSearchWith_ManualEntry.TabIndex = 6;
			rbnSearchWith_ManualEntry.TabStop = true;
			rbnSearchWith_ManualEntry.Text = "Manual Entry";
			rbnSearchWith_ManualEntry.UseVisualStyleBackColor = true;
			// 
			// tbxFind
			// 
			tbxFind.Location = new Point(204, 56);
			tbxFind.Name = "tbxFind";
			tbxFind.Size = new Size(232, 23);
			tbxFind.TabIndex = 0;
			// 
			// tbxReplace
			// 
			tbxReplace.Location = new Point(204, 85);
			tbxReplace.Name = "tbxReplace";
			tbxReplace.Size = new Size(232, 23);
			tbxReplace.TabIndex = 1;
			// 
			// lbxCSVs
			// 
			lbxCSVs.AllowDrop = true;
			lbxCSVs.FormattingEnabled = true;
			lbxCSVs.HorizontalScrollbar = true;
			lbxCSVs.ItemHeight = 15;
			lbxCSVs.Location = new Point(204, 56);
			lbxCSVs.Name = "lbxCSVs";
			lbxCSVs.Size = new Size(232, 49);
			lbxCSVs.TabIndex = 3;
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
			// btnCSV_Browse
			// 
			btnCSV_Browse.Location = new Point(442, 56);
			btnCSV_Browse.Name = "btnCSV_Browse";
			btnCSV_Browse.Size = new Size(80, 30);
			btnCSV_Browse.TabIndex = 17;
			btnCSV_Browse.Text = "Browse...";
			btnCSV_Browse.UseVisualStyleBackColor = true;
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
			// btnCSV_New
			// 
			btnCSV_New.Location = new Point(442, 92);
			btnCSV_New.Name = "btnCSV_New";
			btnCSV_New.Size = new Size(80, 30);
			btnCSV_New.TabIndex = 21;
			btnCSV_New.Text = "New";
			btnCSV_New.UseVisualStyleBackColor = true;
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
			// rbnFindMode_Extended
			// 
			rbnFindMode_Extended.AutoSize = true;
			rbnFindMode_Extended.Location = new Point(6, 47);
			rbnFindMode_Extended.Name = "rbnFindMode_Extended";
			rbnFindMode_Extended.Size = new Size(257, 19);
			rbnFindMode_Extended.TabIndex = 11;
			rbnFindMode_Extended.TabStop = true;
			rbnFindMode_Extended.Text = "Extended (\\n, \\r, \\t, \\', \\\", \\\\, \\0, \\a, \\b, \\f, \\v)";
			rbnFindMode_Extended.UseVisualStyleBackColor = true;
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
			// gbxSearchIn
			// 
			gbxSearchIn.Controls.Add(rbnSearchIn_Files);
			gbxSearchIn.Controls.Add(rbnSearchIn_Text);
			gbxSearchIn.Controls.Add(rbnSearchIn_Directories);
			gbxSearchIn.Location = new Point(204, 116);
			gbxSearchIn.Name = "gbxSearchIn";
			gbxSearchIn.Size = new Size(232, 38);
			gbxSearchIn.TabIndex = 8;
			gbxSearchIn.TabStop = false;
			gbxSearchIn.Text = "Search In";
			// 
			// rbnSearchIn_Files
			// 
			rbnSearchIn_Files.AutoSize = true;
			rbnSearchIn_Files.Location = new Point(98, 13);
			rbnSearchIn_Files.Name = "rbnSearchIn_Files";
			rbnSearchIn_Files.Size = new Size(48, 19);
			rbnSearchIn_Files.TabIndex = 6;
			rbnSearchIn_Files.TabStop = true;
			rbnSearchIn_Files.Text = "Files";
			rbnSearchIn_Files.UseVisualStyleBackColor = true;
			// 
			// rbnSearchIn_Text
			// 
			rbnSearchIn_Text.AutoSize = true;
			rbnSearchIn_Text.Location = new Point(152, 13);
			rbnSearchIn_Text.Name = "rbnSearchIn_Text";
			rbnSearchIn_Text.Size = new Size(46, 19);
			rbnSearchIn_Text.TabIndex = 7;
			rbnSearchIn_Text.TabStop = true;
			rbnSearchIn_Text.Text = "Text";
			rbnSearchIn_Text.UseVisualStyleBackColor = true;
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
			// tbxSearchIn
			// 
			tbxSearchIn.Location = new Point(204, 163);
			tbxSearchIn.Multiline = true;
			tbxSearchIn.Name = "tbxSearchIn";
			tbxSearchIn.ScrollBars = ScrollBars.Both;
			tbxSearchIn.Size = new Size(232, 188);
			tbxSearchIn.TabIndex = 2;
			// 
			// lbxSearchIn
			// 
			lbxSearchIn.AllowDrop = true;
			lbxSearchIn.FormattingEnabled = true;
			lbxSearchIn.HorizontalScrollbar = true;
			lbxSearchIn.ItemHeight = 15;
			lbxSearchIn.Location = new Point(204, 163);
			lbxSearchIn.Name = "lbxSearchIn";
			lbxSearchIn.Size = new Size(232, 184);
			lbxSearchIn.TabIndex = 4;
			// 
			// btnSearchIn_Browse
			// 
			btnSearchIn_Browse.Location = new Point(443, 163);
			btnSearchIn_Browse.Name = "btnSearchIn_Browse";
			btnSearchIn_Browse.Size = new Size(80, 30);
			btnSearchIn_Browse.TabIndex = 18;
			btnSearchIn_Browse.Text = "Browse...";
			btnSearchIn_Browse.UseVisualStyleBackColor = true;
			// 
			// btnSearchIn_Clear
			// 
			btnSearchIn_Clear.Location = new Point(529, 163);
			btnSearchIn_Clear.Name = "btnSearchIn_Clear";
			btnSearchIn_Clear.Size = new Size(80, 30);
			btnSearchIn_Clear.TabIndex = 20;
			btnSearchIn_Clear.Text = "Clear";
			btnSearchIn_Clear.UseVisualStyleBackColor = true;
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
			// cbxMatchWholeWordsOnly
			// 
			cbxMatchWholeWordsOnly.AutoSize = true;
			cbxMatchWholeWordsOnly.Location = new Point(18, 217);
			cbxMatchWholeWordsOnly.Name = "cbxMatchWholeWordsOnly";
			cbxMatchWholeWordsOnly.Size = new Size(162, 19);
			cbxMatchWholeWordsOnly.TabIndex = 14;
			cbxMatchWholeWordsOnly.Text = "Match Whole Words Only";
			cbxMatchWholeWordsOnly.UseVisualStyleBackColor = true;
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
			// sbrStatusBar
			// 
			sbrStatusBar.Items.AddRange(new ToolStripItem[] { lblStatus, pbrProgressBar, lblProgress });
			sbrStatusBar.Location = new Point(0, 474);
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
			// gbxSaveSearches
			// 
			gbxSaveSearches.Controls.Add(rbnSaveSearches_Overwirte);
			gbxSaveSearches.Controls.Add(rbnSaveSearches_New);
			gbxSaveSearches.Controls.Add(rbnSaveSearches_Append);
			gbxSaveSearches.Controls.Add(rbnSaveSearches_Disable);
			gbxSaveSearches.Location = new Point(12, 288);
			gbxSaveSearches.Name = "gbxSaveSearches";
			gbxSaveSearches.Size = new Size(183, 121);
			gbxSaveSearches.TabIndex = 26;
			gbxSaveSearches.TabStop = false;
			gbxSaveSearches.Text = "Create CSV from searches";
			// 
			// rbnSaveSearches_Disable
			// 
			rbnSaveSearches_Disable.AutoSize = true;
			rbnSaveSearches_Disable.Location = new Point(6, 47);
			rbnSaveSearches_Disable.Name = "rbnSaveSearches_Disable";
			rbnSaveSearches_Disable.Size = new Size(63, 19);
			rbnSaveSearches_Disable.TabIndex = 0;
			rbnSaveSearches_Disable.TabStop = true;
			rbnSaveSearches_Disable.Text = "Disable";
			rbnSaveSearches_Disable.UseVisualStyleBackColor = true;
			// 
			// rbnSaveSearches_Append
			// 
			rbnSaveSearches_Append.AutoSize = true;
			rbnSaveSearches_Append.Location = new Point(6, 22);
			rbnSaveSearches_Append.Name = "rbnSaveSearches_Append";
			rbnSaveSearches_Append.Size = new Size(67, 19);
			rbnSaveSearches_Append.TabIndex = 1;
			rbnSaveSearches_Append.TabStop = true;
			rbnSaveSearches_Append.Text = "Append";
			rbnSaveSearches_Append.UseVisualStyleBackColor = true;
			// 
			// rbnSaveSearches_New
			// 
			rbnSaveSearches_New.AutoSize = true;
			rbnSaveSearches_New.Location = new Point(6, 72);
			rbnSaveSearches_New.Name = "rbnSaveSearches_New";
			rbnSaveSearches_New.Size = new Size(49, 19);
			rbnSaveSearches_New.TabIndex = 2;
			rbnSaveSearches_New.TabStop = true;
			rbnSaveSearches_New.Text = "New";
			rbnSaveSearches_New.UseVisualStyleBackColor = true;
			// 
			// rbnSaveSearches_Overwirte
			// 
			rbnSaveSearches_Overwirte.AutoSize = true;
			rbnSaveSearches_Overwirte.Location = new Point(6, 97);
			rbnSaveSearches_Overwirte.Name = "rbnSaveSearches_Overwirte";
			rbnSaveSearches_Overwirte.Size = new Size(76, 19);
			rbnSaveSearches_Overwirte.TabIndex = 3;
			rbnSaveSearches_Overwirte.TabStop = true;
			rbnSaveSearches_Overwirte.Text = "Overwrite";
			rbnSaveSearches_Overwirte.UseVisualStyleBackColor = true;
			// 
			// FRMGui
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(619, 496);
			this.Controls.Add(gbxSaveSearches);
			this.Controls.Add(btnUndo);
			this.Controls.Add(btnReplace);
			this.Controls.Add(gbxSearchWith);
			this.Controls.Add(btnCSV_New);
			this.Controls.Add(btnSearchIn_Clear);
			this.Controls.Add(btnCSV_Clear);
			this.Controls.Add(btnSearchIn_Browse);
			this.Controls.Add(sbrStatusBar);
			this.Controls.Add(cbxCaseSensitiveMatching);
			this.Controls.Add(cbxMatchWholeWordsOnly);
			this.Controls.Add(gbxFindMode);
			this.Controls.Add(cbxCreateBackups);
			this.Controls.Add(gbxFindWithin);
			this.Controls.Add(gbxSearchIn);
			this.Controls.Add(tbxSearchIn);
			this.Controls.Add(tbxReplace);
			this.Controls.Add(tbxFind);
			this.Controls.Add(lbxCSVs);
			this.Controls.Add(btnManualEntry_Switch);
			this.Controls.Add(btnCSV_Browse);
			this.Controls.Add(lbxSearchIn);
			this.Name = "FRMGui";
			this.Text = "Find and Replace";
			this.Load += this.subFrm_OnLoad;
			gbxFindWithin.ResumeLayout(false);
			gbxFindWithin.PerformLayout();
			gbxSearchWith.ResumeLayout(false);
			gbxSearchWith.PerformLayout();
			gbxFindMode.ResumeLayout(false);
			gbxFindMode.PerformLayout();
			gbxSearchIn.ResumeLayout(false);
			gbxSearchIn.PerformLayout();
			sbrStatusBar.ResumeLayout(false);
			sbrStatusBar.PerformLayout();
			gbxSaveSearches.ResumeLayout(false);
			gbxSaveSearches.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private TextBox tbxFind;
		private TextBox tbxReplace;
		private TextBox tbxSearchIn;
		private ListBox lbxCSVs;
		private ListBox lbxSearchIn;
		private RadioButton rbnSearchIn_Directories;
		private RadioButton rbnSearchIn_Files;
		private RadioButton rbnSearchIn_Text;
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
		private Button btnManualEntry_Switch;
		private GroupBox gbxSaveSearches;
		private RadioButton rbnSaveSearches_Disable;
		private RadioButton rbnSaveSearches_Overwirte;
		private RadioButton rbnSaveSearches_New;
		private RadioButton rbnSaveSearches_Append;
	}
}