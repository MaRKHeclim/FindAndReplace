namespace FindAndReplace.Presentation.ConsoleApp
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Windows.Forms;
	using FindAndReplace.Core.DataStructures;
	using FindAndReplace.Core.Ports.Incoming;

	public partial class FRMGui
	{
		private readonly IFCBulkSearch objBulkSearch;
		private readonly IFCStringReplaceWithOptions objStringReplaceWithOptions;
		private readonly IFCCsvManagement objCsvManagement;

		private void subAddButtonHandlers()
		{
			this.btnManualEntry_Switch.Click += this.subBtnManualEntry_Switch_OnClick;
			this.btnCSV_Browse.Click += this.subBtnCsv_Browse_OnClick;
			this.btnCSV_Clear.Click += this.subBtnCsv_Clear_OnClick;
			this.btnCSV_New.Click += this.subBtnCsv_New_OnClick;
			this.btnSearchIn_Browse.Click += this.subBtnSearchIn_Browse_OnClick;
			this.btnSearchIn_Clear.Click += this.subBtnSearchIn_Clear_OnClick;
			this.btnUndo.Click += this.subBtnUndo_OnClick;
			this.btnReplace.Click += this.subBtnReplace_OnClick;
		}

		// ******************************************************************* //
		//
		// Simple handlers and handlers that pass events to other methods.
		//
		// ******************************************************************* //
		private void subBtnManualEntry_Switch_OnClick(object objSender, EventArgs objEventArgs)
		{
			string vstOrigFindText = this.tbxFind.Text;
			this.tbxFind.Text = this.tbxReplace.Text;
			this.tbxReplace.Text = vstOrigFindText;
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
			// Create header and example rows
			// Save to file
			// Add to listbox
			// Open file
			throw new NotImplementedException();
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

		private void subBtnUndo_OnClick(object objSender, EventArgs objEventArgs)
		{
			// TODO: Implement this method.
			throw new NotImplementedException();
		}

		private void subBtnReplace_OnClick(object objSender, EventArgs objEventArgs)
		{
			this.subReplace();
		}

		// ******************************************************************* //
		//
		// Methods that are called by other methods above.
		//
		// ******************************************************************* //
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

		private void subReplace()
		{
			// Do common prep steps
			ENMFindMode enmFindMode;
			if (this.rbnFindMode_RegEx.Checked)
			{
				enmFindMode = ENMFindMode.RegularExpression;
			}
			else if (this.rbnFindMode_Extended.Checked)
			{
				enmFindMode = ENMFindMode.Extended;
			}
			else
			{
				enmFindMode = ENMFindMode.Normal;
			}

			List<CLSFindReplaceRecord> enbFindReplaceRecords = new List<CLSFindReplaceRecord>();
			CLSFindReplaceRecord objFindReplaceRecord = new CLSFindReplaceRecord(this.tbxFind.Text, this.tbxReplace.Text, enmFindMode, this.cbxCaseSensitiveMatching.Checked, this.cbxMatchWholeWordsOnly.Checked, false, false);

			if (this.rbnSearchWith_ManualEntry.Checked)
			{
				// TODO: Update this when checkboxes are added.
				this.objCsvManagement.subAddFindReplaceRecord(objFindReplaceRecord);
				enbFindReplaceRecords.Add(objFindReplaceRecord);
			}
			else
			{
				//IList<string> lstCSVs = new List<string>();
				//foreach (string vstCSV in this.lbxCSVs.Items)
				//{
				//	lstCSVs.Add(vstCSV);
				//}
				enbFindReplaceRecords = this.objCsvManagement.fncMakeFindReplaceRecordList((IEnumerable<string>)this.lbxCSVs.Items).ToList();
			}

			// Perform the replacement
			if (this.rbnSearchIn_Text.Checked && this.rbnSearchWith_CSVs.Checked)
			{
				// TODO: Update this when checkboxes are added.
				this.objStringReplaceWithOptions.fncStringReplaceWithOptions(this.tbxSearchIn.Text, this.tbxFind.Text, this.tbxReplace.Text, enmFindMode, this.cbxCaseSensitiveMatching.Checked, this.cbxMatchWholeWordsOnly.Checked, false, false);
			}
			else if (this.rbnSearchIn_Text.Checked && this.rbnSearchWith_ManualEntry.Checked)
			{
				this.objStringReplaceWithOptions.fncStringReplaceList(this.tbxSearchIn.Text, enbFindReplaceRecords);
			}
			else if (!this.rbnSearchIn_Text.Checked)
			{
				this.objBulkSearch.subSearchFilesAndFolders((IEnumerable<string>)this.lbxSearchIn.Items, enbFindReplaceRecords);
			}
			else
			{
				throw new Exception("Unhandled combination of search in and search with. How on earth did you end up here?");
			}
		}
	}
}
