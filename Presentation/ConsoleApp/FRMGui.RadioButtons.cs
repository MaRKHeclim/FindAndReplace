namespace FindAndReplace.Presentation.ConsoleApp
{
	using System;

	public partial class FRMGui
	{
		private void subAddRadioButtonHandlers()
		{
			this.rbnSearchWith_CSVs.CheckedChanged += this.subRbnSearchWithCSVs_OnCheckedChanged;
			this.rbnSearchWith_ManualEntry.CheckedChanged += this.subRbnSearchWith_ManualEntry_OnCheckedChanged;
			this.rbnSearchIn_Directories.CheckedChanged += this.subRbnSearchIn_Directories_OnCheckedChanged;
			this.rbnSearchIn_Files.CheckedChanged += this.subRbnSearchIn_Files_OnCheckedChanged;
			this.rbnSearchIn_Text.CheckedChanged += this.subRbnSearchIn_Text_OnCheckedChanged;
		}

		// ******************************************************************* //
		//
		// Simple handlers and handlers that pass events to other methods.
		//
		// ******************************************************************* //
		private void subRbnSearchWithCSVs_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchWithRbns_OnSelectedValueChanged();
		}

		private void subRbnSearchWith_ManualEntry_OnCheckedChanged(object objSender, EventArgs objEventArgs)
		{
			this.subSearchWithRbns_OnSelectedValueChanged();
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

		// ******************************************************************* //
		//
		// Methods that are called by other methods above.
		//
		// ******************************************************************* //
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

				// Disable Find Mode radio buttons, Match Whole Words checkbox, and Match Case checkbox
				this.rbnFindMode_Normal.Enabled = false;
				this.rbnFindMode_Extended.Enabled = false;
				this.rbnFindMode_RegEx.Enabled = false;
				this.cbxMatchWholeWordsOnly.Enabled = false;
				this.cbxCaseSensitiveMatching.Enabled = false;
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

				// Enable Find Mode radio buttons, Match Whole Words checkbox, and Match Case checkbox
				this.rbnFindMode_Normal.Enabled = true;
				this.rbnFindMode_Extended.Enabled = true;
				this.rbnFindMode_RegEx.Enabled = true;
				this.cbxMatchWholeWordsOnly.Enabled = true;
				this.cbxCaseSensitiveMatching.Enabled = true;
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
	}
}
