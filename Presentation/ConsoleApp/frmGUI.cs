// <copyright file="FRMGui.cs" company="Matthew Klemetsen">
// Copyright (c) Matthew Klemetsen. All rights reserved.
// </copyright>

namespace FindAndReplace.Presentation.ConsoleApp
{
	using System;
	using System.Windows.Forms;
	using FindAndReplace.Core.DataStructures;
	using FindAndReplace.Core.Ports.Incoming;

#pragma warning disable IDE1006 // Naming Styles
	public partial class FRMGui : Form
#pragma warning restore IDE1006 // Naming Styles
	{
		public FRMGui(IFCBulkSearch p_objBulkSearch, IFCStringReplaceWithOptions p_objStringReplaceWithOptions, IFCCsvManagement p_objCsvManagement)
		{
			// Map dependencies
			this.objBulkSearch = p_objBulkSearch;
			this.objStringReplaceWithOptions = p_objStringReplaceWithOptions;
			this.objCsvManagement = p_objCsvManagement;

			// Add and configure controls
			this.InitializeComponent();

			// Add event handlers
			this.Load += this.subFrm_OnLoad;
			this.subAddButtonHandlers();
			this.subAddRadioButtonHandlers();
			this.subAddListboxHandlers();
			this.subAddStatusBarHandlers();
		}

		private void subFrm_OnLoad(object objSender, EventArgs objEventArgs)
		{
			// Set default values (so that on change events are triggered - hides appropriate things)
			this.cbxFindWithin_FileContents.Checked = true;
			this.cbxFindWithin_FileContents.CheckState = CheckState.Checked;
			this.rbnSearchWith_CSVs.Checked = true;
			this.rbnSearchIn_Files.Checked = true;
			this.rbnFindMode_Extended.Checked = true;
			this.rbnBackup_InSubfolder.Checked = true;
			this.rbnSaveSearches_Disable.Checked = true;

			// Disable controls that are not yet functional
			this.cbxFindWithin_DirectoryName.Enabled = false;
			this.cbxFindWithin_FileName.Enabled = false;
			this.btnUndo.Enabled = false;
			this.rbnSaveSearches_Append.Enabled = false;
			this.rbnSaveSearches_Overwrite.Enabled = false;
			this.rbnSaveSearches_New.Enabled = false;
		}
	}
}