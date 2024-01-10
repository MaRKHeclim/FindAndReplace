// <copyright file="FRMGui.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace
{
	using System;
	using System.Windows.Forms;
	using FindAndReplace.Core.Ports.Incoming;

	public partial class FRMGui : Form
	{
		private readonly IFCBulkSearch objBulkSearch;
		private readonly IFCStringReplaceWithOptions objStringReplaceWithOptions;

		/// <summary>
		/// Triggers external Event Handlers to occur with the Form Closed Event. Add handlers to this object to trigger them when the form closes.
		/// </summary>
		public event EventHandler<FormClosedEventArgs> objFormClosedHandlers;

		public FRMGui(IFCBulkSearch p_objBulkSearch, IFCStringReplaceWithOptions p_objStringReplaceWithOptions)
		{
			// Map dependencies
			this.objBulkSearch = p_objBulkSearch;
			this.objStringReplaceWithOptions = p_objStringReplaceWithOptions;

			// Add and configure controls
			this.InitializeComponent();

			// Add event handlers
			this.rbnSearchWith_CSVs.CheckedChanged += this.subRbnSearchWithCSVs_OnCheckedChanged;
			this.rbnSearchWith_ManualEntry.CheckedChanged += this.subRbnSearchWith_ManualEntry_OnCheckedChanged;
			this.btnCSV_Browse.Click += this.subBtnCsv_Browse_OnClick;
			this.btnCSV_Clear.Click += this.subBtnCsv_Clear_OnClick;
			this.btnCSV_New.Click += this.subBtnCsv_New_OnClick;
			this.rbnSearchIn_Directories.CheckedChanged += this.subRbnSearchIn_Directories_OnCheckedChanged;
			this.rbnSearchIn_Files.CheckedChanged += this.subRbnSearchIn_Files_OnCheckedChanged;
			this.rbnSearchIn_Text.CheckedChanged += this.subRbnSearchIn_Text_OnCheckedChanged;
			this.btnSearchIn_Browse.Click += this.subBtnSearchIn_Browse_OnClick;
			this.btnSearchIn_Clear.Click += this.subBtnSearchIn_Clear_OnClick;
		}

		#region Event Handlers

		private void subFrm_OnLoad(object objSender, EventArgs objEventArgs)
		{
			// Set default values (so that on change events are triggered - hides appropriate things)
			this.cbxFindWithin_FileContents.Checked = true;
			this.cbxFindWithin_FileContents.CheckState = CheckState.Checked;
			this.rbnSearchWith_CSVs.Checked = true;
			this.rbnSearchIn_Files.Checked = true;
			this.rbnFindMode_Extended.Checked = true;

			// Disable controls that are not yet implemented
			this.cbxFindWithin_DirectoryName.Enabled = false;
			this.cbxFindWithin_FileName.Enabled = false;
			this.btnUndo.Enabled = false;
		}

		private void subRbnSearchWithCSVs_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchWithRbns_OnSelectedValueChanged();
		}

		private void subRbnSearchWith_ManualEntry_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchWithRbns_OnSelectedValueChanged();
		}

		private void subBtnCsv_Browse_OnClick(object objSender, EventArgs objEventArgs)
		{
			this.subBrowseFiles(this.lbxCSVs, true);
		}

		private void subBtnCsv_Clear_OnClick(object objSender, EventArgs objEventArgs)
		{
			this.lbxCSVs.Items.Clear();
			this.subUpdateListBoxSize(this.lbxCSVs);
		}

		private void subBtnCsv_New_OnClick(object objSender, EventArgs objEventArgs)
		{
			// TODO: Implement this method.
			throw new NotImplementedException();
		}

		private void subRbnSearchIn_Directories_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchInRbns_OnSelectedValueChanged();
		}

		private void subRbnSearchIn_Files_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchInRbns_OnSelectedValueChanged();
		}

		private void subRbnSearchIn_Text_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchInRbns_OnSelectedValueChanged();
		}

		private void subBtnSearchIn_Browse_OnClick(object objSender, EventArgs objEventArgs)
		{
			if (this.rbnSearchIn_Directories.Checked)
			{
				this.subBrowseDirectories(this.lbxSearchIn);
			}
			else
			{
				this.subBrowseFiles(this.lbxSearchIn);
			}
		}

		private void subBtnSearchIn_Clear_OnClick(object objSender, EventArgs objEventArgs)
		{
			this.lbxSearchIn.Items.Clear();
			this.subUpdateListBoxSize(this.lbxSearchIn);
		}

		#endregion

		#region Private Methods

		private void subSearchWithRbns_OnSelectedValueChanged()
		{
			if (this.rbnSearchWith_ManualEntry.Checked)
			{
				// Show manual entry controls
				this.tbxFind.Visible = true;
				this.tbxReplace.Visible = true;
				this.btnManualEntry_Switch.Visible = true;

				// Hide CSV controls
				this.lbxCSVs.Visible = false;
				this.btnCSV_Browse.Visible = false;
				this.btnCSV_Clear.Visible = false;
				this.btnCSV_New.Visible = false;
			}
			else
			{
				// Hide manual entry controls
				this.tbxFind.Visible = false;
				this.tbxReplace.Visible = false;
				this.btnManualEntry_Switch.Visible = false;

				// Show CSV controls
				this.lbxCSVs.Visible = true;
				this.btnCSV_Browse.Visible = true;
				this.btnCSV_Clear.Visible = true;
				this.btnCSV_New.Visible = true;
			}
		}

		private void subSearchInRbns_OnSelectedValueChanged()
		{
			if (this.rbnSearchIn_Text.Checked)
			{
				// Hide file system controls
				this.btnSearchIn_Browse.Visible = false;
				this.btnSearchIn_Clear.Visible = false;
				this.lbxSearchIn.Visible = false;

				// Show text search textbox
				this.tbxSearchIn.Visible = true;
			}
			else
			{
				// Show file system controls
				this.btnSearchIn_Browse.Visible = true;
				this.btnSearchIn_Clear.Visible = true;
				this.lbxSearchIn.Visible = true;

				// Hide text search textbox
				this.tbxSearchIn.Visible = false;
			}

			// Clear listbox and textbox
			this.lbxSearchIn.Items.Clear();
			this.subUpdateListBoxSize(this.lbxSearchIn);

			this.tbxSearchIn.Text = string.Empty;
		}

		private void subBrowseFiles(ListBox p_lbxReturnLocation, bool p_vbnCSVsOnly = false)
		{
			OpenFileDialog ofdFileBrowser = new OpenFileDialog();
			ofdFileBrowser.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
			ofdFileBrowser.Multiselect = true;
			if (p_vbnCSVsOnly)
			{
				ofdFileBrowser.Filter = "CSV (Comma delimited) (*.csv)|*.csv|All files (*.*)|*.*";
			}
			else
			{
				ofdFileBrowser.Filter = "All files (*.*)|*.*";
			}

			var result = ofdFileBrowser.ShowDialog();
			if (result == DialogResult.OK)
			{
				p_lbxReturnLocation.Items.AddRange(ofdFileBrowser.FileNames);
			}

			this.subUpdateListBoxSize(p_lbxReturnLocation);
		}

		private void subBrowseDirectories(ListBox p_lbxReturnLocation)
		{
			FolderBrowserDialog fbdFolderBrowser = new FolderBrowserDialog();
			fbdFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
			fbdFolderBrowser.ShowNewFolderButton = false;
			fbdFolderBrowser.Description = "Select a folder to search in";

			var result = fbdFolderBrowser.ShowDialog();
			if (result == DialogResult.OK)
			{
				p_lbxReturnLocation.Items.Add(fbdFolderBrowser.SelectedPath);
			}

			this.subUpdateListBoxSize(p_lbxReturnLocation);
		}

		private void subUpdateListBoxSize(ListBox p_lbxReturnLocation)
		{
			var objGraphics = p_lbxReturnLocation.CreateGraphics();
			int intMaxWidth = 0;
			foreach (var objItem in p_lbxReturnLocation.Items)
			{
				intMaxWidth = Math.Max(intMaxWidth, (int)objGraphics.MeasureString(objItem.ToString(), p_lbxReturnLocation.Font).Width);
			}

			p_lbxReturnLocation.HorizontalExtent = intMaxWidth + 1;

			// Show/hide horizontal scrollbar
			if (p_lbxReturnLocation.HorizontalExtent > p_lbxReturnLocation.Width)
			{
				p_lbxReturnLocation.HorizontalScrollbar = true;
			}
			else
			{
				p_lbxReturnLocation.HorizontalScrollbar = false;
			}
		}

		#endregion
	}
}