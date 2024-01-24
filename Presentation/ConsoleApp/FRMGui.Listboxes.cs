namespace FindAndReplace.Presentation.ConsoleApp
{
	using System;
	using System.IO;
	using System.Windows.Forms;

	public partial class FRMGui
	{
		private void subAddListboxHandlers()
		{
			this.lbxCSVs.DragOver += this.subLbxCSVs_OnDragOver;
			this.lbxCSVs.DragDrop += this.subLbxCSVs_OnDragDrop;
			this.lbxSearchIn.DragOver += this.subLbxSearchIn_OnDragOver;
			this.lbxSearchIn.DragDrop += this.subLbxSearchIn_OnDragDrop;
		}

		// ******************************************************************* //
		//
		// Simple handlers and handlers that pass events to other methods.
		//
		// ******************************************************************* //
		private void subLbxCSVs_OnDragOver(object objSender, DragEventArgs objEventArgs)
		{
			this.subOnDragOver(objEventArgs, false, true);
		}

		private void subLbxCSVs_OnDragDrop(object objSender, DragEventArgs objEventArgs)
		{
			this.subOnDragDrop(this.lbxCSVs, objEventArgs);
		}

		private void subLbxSearchIn_OnDragOver(object objSender, DragEventArgs objEventArgs)
		{
			this.subOnDragOver(objEventArgs, this.rbnSearchIn_Directories.Checked, false);
		}

		private void subLbxSearchIn_OnDragDrop(object objSender, DragEventArgs objEventArgs)
		{
			this.subOnDragDrop(this.lbxSearchIn, objEventArgs);
		}

		// ******************************************************************* //
		//
		// Methods that are called by other methods above.
		//
		// ******************************************************************* //
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

		private void subOnDragOver(DragEventArgs p_objEventArgs, bool p_vbnAllowFolders, bool p_vbnCSVsOnly)
		{
			bool vbnAllowDrop = false;
			if (p_objEventArgs.Data.GetDataPresent(DataFormats.FileDrop))
			{
				foreach (string vstFile in (string[])p_objEventArgs.Data.GetData(DataFormats.FileDrop))
				{
					if (!p_vbnAllowFolders && File.Exists(vstFile))
					{
						if (p_vbnCSVsOnly)
						{
							if (Path.GetExtension(vstFile).ToLower() == ".csv")
							{
								vbnAllowDrop = true;
							}
							else
							{
								vbnAllowDrop = false;
								break;
							}
						}
						else
						{
							vbnAllowDrop = true;
						}
					}
					else if (p_vbnAllowFolders && Directory.Exists(vstFile))
					{
						vbnAllowDrop = true;
					}
					else
					{
						vbnAllowDrop = false;
						break;
					}
				}

				if (vbnAllowDrop)
				{
					p_objEventArgs.Effect = DragDropEffects.Copy;
				}
				else
				{
					p_objEventArgs.Effect = DragDropEffects.None;
				}
			}
		}

		private void subOnDragDrop(ListBox p_lbxReturnLocation, DragEventArgs p_objEventArgs)
		{
			foreach (string vstFile in (string[])p_objEventArgs.Data.GetData(DataFormats.FileDrop))
			{
				p_lbxReturnLocation.Items.Add(vstFile);
			}

			this.subUpdateListBoxSize(p_lbxReturnLocation);
		}
	}
}
