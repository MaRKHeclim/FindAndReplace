<# This form was created using POSHGUI.com  a free online gui designer for PowerShell
.NAME
    FindAndReplace
#>

Add-Type -AssemblyName System.Windows.Forms
[System.Windows.Forms.Application]::EnableVisualStyles()

$InputForm                       = New-Object system.Windows.Forms.Form
$InputForm.ClientSize            = '460,400'
$InputForm.text                  = "Find and Replace"
$InputForm.TopMost               = $false

$listboxDirectories              = New-Object system.Windows.Forms.ListBox
$listboxDirectories.text         = "listBox"
$listboxDirectories.width        = 300
$listboxDirectories.height       = 207
$listboxDirectories.location     = New-Object System.Drawing.Point(15,140)

$groupboxRadioButtons            = New-Object system.Windows.Forms.Groupbox
$groupboxRadioButtons.height     = 32
$groupboxRadioButtons.width      = 300
$groupboxRadioButtons.location   = New-Object System.Drawing.Point(15,105)

$labelCSV                        = New-Object system.Windows.Forms.Label
$labelCSV.text                   = "Find-Replace CSV"
$labelCSV.AutoSize               = $true
$labelCSV.width                  = 25
$labelCSV.height                 = 10
$labelCSV.location               = New-Object System.Drawing.Point(17,5)
$labelCSV.Font                   = 'Microsoft Sans Serif,10'

$radiobuttonDirectory            = New-Object system.Windows.Forms.RadioButton
$radiobuttonDirectory.text       = "Directories"
$radiobuttonDirectory.AutoSize   = $true
$radiobuttonDirectory.width      = 104
$radiobuttonDirectory.height     = 20
$radiobuttonDirectory.location   = New-Object System.Drawing.Point(5,8)
$radiobuttonDirectory.Font       = 'Microsoft Sans Serif,10'

$radiobuttonFiles                = New-Object system.Windows.Forms.RadioButton
$radiobuttonFiles.text           = "Files"
$radiobuttonFiles.AutoSize       = $true
$radiobuttonFiles.width          = 104
$radiobuttonFiles.height         = 20
$radiobuttonFiles.location       = New-Object System.Drawing.Point(100,8)
$radiobuttonFiles.Font           = 'Microsoft Sans Serif,10'

$listboxFileList                 = New-Object system.Windows.Forms.ListBox
$listboxFileList.text            = "listBox"
$listboxFileList.width           = 300
$listboxFileList.height          = 170
$listboxFileList.location        = New-Object System.Drawing.Point(15,177)

$buttonBrowseCSV                 = New-Object system.Windows.Forms.Button
$buttonBrowseCSV.text            = "Browse..."
$buttonBrowseCSV.width           = 70
$buttonBrowseCSV.height          = 30
$buttonBrowseCSV.location        = New-Object System.Drawing.Point(320,30)
$buttonBrowseCSV.Font            = 'Microsoft Sans Serif,10'

$buttonNew                       = New-Object system.Windows.Forms.Button
$buttonNew.text                  = "New"
$buttonNew.width                 = 70
$buttonNew.height                = 30
$buttonNew.location              = New-Object System.Drawing.Point(320,70)
$buttonNew.Font                  = 'Microsoft Sans Serif,10'

$buttonBrowseDirectory           = New-Object system.Windows.Forms.Button
$buttonBrowseDirectory.text      = "Browse..."
$buttonBrowseDirectory.width     = 70
$buttonBrowseDirectory.height    = 30
$buttonBrowseDirectory.location  = New-Object System.Drawing.Point(320,140)
$buttonBrowseDirectory.Font      = 'Microsoft Sans Serif,10'

$buttonBrowseFiles               = New-Object system.Windows.Forms.Button
$buttonBrowseFiles.text          = "Browse..."
$buttonBrowseFiles.width         = 70
$buttonBrowseFiles.height        = 30
$buttonBrowseFiles.location      = New-Object System.Drawing.Point(320,177)
$buttonBrowseFiles.Font          = 'Microsoft Sans Serif,10'

$buttonReplace                   = New-Object system.Windows.Forms.Button
$buttonReplace.text              = "Replace List"
$buttonReplace.width             = 90
$buttonReplace.height            = 30
$buttonReplace.location          = New-Object System.Drawing.Point(190,351)
$buttonReplace.Font              = 'Microsoft Sans Serif,10'

$buttonClearFileList             = New-Object system.Windows.Forms.Button
$buttonClearFileList.text        = "Clear"
$buttonClearFileList.width       = 50
$buttonClearFileList.height      = 30
$buttonClearFileList.location    = New-Object System.Drawing.Point(394,177)
$buttonClearFileList.Font        = 'Microsoft Sans Serif,10'

$checkboxBackupFiles             = New-Object system.Windows.Forms.CheckBox
$checkboxBackupFiles.text        = "Backup Files"
$checkboxBackupFiles.AutoSize    = $false
$checkboxBackupFiles.width       = 143
$checkboxBackupFiles.height      = 20
$checkboxBackupFiles.location    = New-Object System.Drawing.Point(17,358)
$checkboxBackupFiles.Font        = 'Microsoft Sans Serif,10'

$listboxCSVs                     = New-Object system.Windows.Forms.ListBox
$listboxCSVs.text                = "listBox"
$listboxCSVs.width               = 300
$listboxCSVs.height              = 70
$listboxCSVs.location            = New-Object System.Drawing.Point(15,30)

$buttonClearCSVs                 = New-Object system.Windows.Forms.Button
$buttonClearCSVs.text            = "Clear"
$buttonClearCSVs.width           = 50
$buttonClearCSVs.height          = 30
$buttonClearCSVs.location        = New-Object System.Drawing.Point(395,30)
$buttonClearCSVs.Font            = 'Microsoft Sans Serif,10'

$buttonClearDirectory            = New-Object system.Windows.Forms.Button
$buttonClearDirectory.text       = "Clear"
$buttonClearDirectory.width      = 50
$buttonClearDirectory.height     = 30
$buttonClearDirectory.location   = New-Object System.Drawing.Point(394,140)
$buttonClearDirectory.Font       = 'Microsoft Sans Serif,10'

$InputForm.controls.AddRange(@($listboxDirectories,$groupboxRadioButtons,$labelCSV,$listboxFileList,$buttonBrowseCSV,$buttonNew,$buttonBrowseDirectory,$buttonBrowseFiles,$buttonReplace,$buttonClearFileList,$checkboxBackupFiles,$listboxCSVs,$buttonClearCSVs,$buttonClearDirectory))
$groupboxRadioButtons.controls.AddRange(@($radiobuttonDirectory,$radiobuttonFiles))



######################################################################################################################################################################################
#
#                                                       Code Above Here was Auto-Generated
#
#                                                       Set Properties that couldn't be automatically set
#
######################################################################################################################################################################################

$listboxCSVs.AllowDrop = $True
$listboxDirectories.AllowDrop = $True
$listboxFileList.AllowDrop = $True

$listboxCSVs.HorizontalScrollbar = $True
$listboxDirectories.HorizontalScrollbar = $True
$listboxFileList.HorizontalScrollbar = $True

######################################################################################################################################################################################
#
#                                                       Event Handlers Here
#
######################################################################################################################################################################################

function buttonBrowseCSV_OnClick ($sender, $event) 
{ 
    browseFiles $listboxCSVs $True
}
function buttonBrowseDirectory_OnClick ($sender, $event) 
{ 
    browseFolders $listboxDirectories
}
function buttonBrowseFiles_OnClick ($sender, $event) 
{ 
    browseFiles $listboxFileList $False
}
function buttonClearCSVs_OnClick ($sender, $event) 
{ 
    $listboxCSVs.Items.Clear()
    updateListBoxSize($listboxCSVs)
}
function buttonClearDirectory_OnClick ($sender, $event) 
{ 
    $listboxDirectories.Items.Clear()
    updateListBoxSize($listboxDirectories)
}
function buttonClearFileList_OnClick ($sender, $event) 
{
    $listboxFileList.Items.Clear()
    updateListBoxSize($listboxFileList)
}
function buttonNew_OnClick ($sender, $event) 
{ 
    createNewFindReplaceCSV
}
function buttonReplace_OnClick ($sender, $event) 
{ 
    findAndReplace
}
$listboxCSVs_OnDragOver = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxCSVs_OnDragOver
    onDragOver $this $_ $True $False
}
$listboxCSVs_OnDragDrop = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxCSVs_OnDragDrop
    foreach ($filename in $_.Data.GetData([Windows.Forms.DataFormats]::FileDrop)) # $event = [System.Windows.Forms.DragEventArgs]
    {
		$listboxCSVs.Items.Add($filename)
	}
}
$listboxDirectories_OnDragOver = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxDirectories_OnDragOver
    onDragOver $this $_ $False $True
}
$listboxDirectories_OnDragDrop = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxDirectories_OnDragDrop
    foreach ($filename in $_.Data.GetData([Windows.Forms.DataFormats]::FileDrop)) # $event = [System.Windows.Forms.DragEventArgs]
    {
		$listboxDirectories.Items.Add($filename)
	}
}
$listboxFileList_OnDragOver = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxFileList_OnDragOver
    onDragOver $this $_ $True $False
}
$listboxFileList_OnDragDrop = [System.Windows.Forms.DragEventHandler]{ 
    #Write-Host listboxFileList_OnDragDrop
    foreach ($filename in $_.Data.GetData([Windows.Forms.DataFormats]::FileDrop)) # $event = [System.Windows.Forms.DragEventArgs]
    {
		$listboxFileList.Items.Add($filename)
	}
}
function radiobuttonDirectory_OnCheckedChanged ($sender, $event) 
{ 
    if($radiobuttonDirectory.checked -eq $True)
    {
        $listboxDirectories.visible = $True
        $buttonBrowseDirectory.visible = $True
        $buttonClearDirectory.visible = $True
        
        $listboxFileList.visible = $False
        $buttonBrowseFiles.visible = $False
        $buttonClearFileList.visible = $False
    }
    else
    {
        $listboxDirectories.visible = $False
        $buttonBrowseDirectory.visible = $False
        $buttonClearDirectory.visible = $False
        
        $listboxFileList.visible = $True
        $buttonBrowseFiles.visible = $True
        $buttonClearFileList.visible = $True
    }
}
function radiobuttonFiles_OnCheckedChanged ($sender, $event) 
{ 
    if($radiobuttonFiles.checked -eq $True)
    {
        $listboxDirectories.visible = $False
        $buttonBrowseDirectory.visible = $False
        $buttonClearDirectory.visible = $False
        
        $listboxFileList.visible = $True
        $buttonBrowseFiles.visible = $True
        $buttonClearFileList.visible = $True
    }
    else
    {
        $listboxDirectories.visible = $True
        $buttonBrowseDirectory.visible = $True
        $buttonClearDirectory.visible = $True
        
        $listboxFileList.visible = $False
        $buttonBrowseFiles.visible = $False
        $buttonClearFileList.visible = $False
    }
}

######################################################################################################################################################################################
#
#                                                       Functional Logic Below
#
######################################################################################################################################################################################

$findAndReplaceList = New-Object System.Data.DataTable "New CSV"
Out-Null -inputObject $findAndReplaceList.columns.add("Find")
Out-Null -inputObject $findAndReplaceList.columns.add("Replace")

#handles what happens when the mouse enters a list box object
#changes the mouse icon and affects the drop operation
function onDragOver ($sender, $event, $allowFiles, $allowFolders)
{
    #Write-Host onDragOver
    #Write-Host "Allow Files: $($allowFiles) Allow Folders: $($allowFolders)"
    $allow = $False
    if ($event.Data.GetDataPresent([Windows.Forms.DataFormats]::FileDrop)) # $event = [System.Windows.Forms.DragEventArgs]
	{
	    foreach ($filename in $event.Data.GetData([Windows.Forms.DataFormats]::FileDrop)) # $event = [System.Windows.Forms.DragEventArgs]
        {
    	    if($allowFiles -and ($filename -like "*.*"))
    	    {
                #Write-Host "I am allowing this file"
                #$event.Effect = 'Copy'
                $allow = $True
    	    }
    	    elseif($allowFolders -and ($filename -notlike "*.*"))
    	    {
    	        #Write-Host "I am allowing this folder"
    	        #$event.Effect = 'Copy'
    	        $allow = $True
    	    }
    	    else
    	    {
    	        #Write-Host "I am denying this"
    	        #$event.Effect = 'None'
    	        $allow = $False
    	        break
    	    }
        }
	}
	if($allow)
	{
	    $event.Effect = 'Copy'
	}
	else
	{
	    $event.Effect = 'None'
	}
}

#handles getting files
function browseFiles ($returnLocation, $CSVsOnly)
{
    $fileBrowser = New-Object System.Windows.Forms.OpenFileDialog
    $fileBrowser.InitialDirectory = [System.Environment+SpecialFolder]'MyComputer'
    $fileBrowser.Multiselect = $True
    if($CSVsOnly)
    {
        $fileBrowser.Filter = "CSV (Comma delimited) (*.csv)|*.csv|All files (*.*)|*.*"
    }
    else
    {
        $fileBrowser.Filter = "All files (*.*)|*.*"
    }
    
    $result = $fileBrowser.ShowDialog()
    if($result -eq "OK")
    {
        #Write-Host ($fileBrowser | Format-List | Out-String)
        $path = $FileBrowser.FileNames
        if($path -like "*\*") 
        {
        	#Write-Host $path #Lists selected files (optional)
        	
        	foreach($file in Get-ChildItem $path)
        	{
        	    #Write-Host $file
        	    $returnLocation.Items.Add($file)
        	}
        }
    }
    updateListBoxSize($returnLocation)
}

#handles getting folders
function browseFolders ($returnLocation)
{
    $folderBrowser = New-Object System.Windows.Forms.FolderBrowserDialog
    $folderBrowser.RootFolder = [System.Environment+SpecialFolder]'MyComputer'
    $folderBrowser.ShowNewFolderButton = $False
    $folderBrowser.Description = "Select a Folder"
    
    $result = $folderBrowser.ShowDialog()
    if($result -eq "OK")
    {
        $returnLocation.Items.Add($folderBrowser.SelectedPath)
    }
    updateListBoxSize($returnLocation)
}

#Deal with horizontal scrolling in list boxes
function updateListBoxSize ($listBox)
{
    # Create a Graphics object to use when determining the size of the largest item in the ListBox.
    $g = $listBox.CreateGraphics()
    
    $hzSize = 0
    # Determine the size for HorizontalExtent using the MeasureString method
    foreach($item in Get-ChildItem $listBox.Items)
    {
        $currentItemSize = $g.MeasureString($item.ToString(), $listBox.Font).Width
        if($currentItemSize -gt $hzSize)
        {
            $hzSize = $currentItemSize
        }
    }
    # Set the HorizontalExtent property.
    $listBox.HorizontalExtent = $hzSize
    #Show/Hide Scrollbar
    if($hzSize -gt $listBox.width)
    {
        $listBox.HorizontalScrollbar = $True
    }
    else
    {
        $listBox.HorizontalScrollbar = $False
    }
    $g.Dispose()
}

function createNewFindReplaceCSV()
{
    #Create table with headers
    #Define Table
    $table = New-Object System.Data.DataTable "New CSV"
    #Add Columns to Table
    $table.columns.add("Find")
    $table.columns.add("Replace")
    #Put an example row in the table
    $row = $table.NewRow()
    $row.Find = "Find Me!"
    $row.Replace = "Replace with Me!"
    #Add row to table
    $table.Rows.Add($row)
    #Open save file dialog
    $saveBrowser = New-Object System.Windows.Forms.SaveFileDialog
    $saveBrowser.Filter = "CSV (Comma delimited) (*.csv)|*.csv|All files (*.*)|*.*"
    $saveBrowser.InitialDirectory = [System.Environment+SpecialFolder]'MyComputer'
    $saveBrowser.FileName = "FindAndReplaceList.csv"
    $saveBrowser.DefaultExt = "csv"
    $saveBrowser.AddExtension = $True
    $result = $saveBrowser.ShowDialog()
    if($result -eq "OK")
    {
        #Write File
        $tabCsv = $table | Export-Csv -Path $saveBrowser.FileName -NoTypeInformation;
        #Add File to CSV List
        $listboxCSVs.Items.Add($saveBrowser.FileName)
    }
}










function findAndReplace()
{
    loadSearchCriteria
    
    #if backup box is checked - create a filename.bak
    
    #if files iterate through files load the file perform find and replace save the file
    if($radiobuttonFiles.checked -eq $True)
    {
        Write-Host "Replacing items in Files"
        foreach($file in $listboxFileList.Items)
        {
            Write-Host $file
            $fileContent = (Get-Content $file -ReadCount 0) -join "`r`n"
            $newFileContent = performFindAndReplace $fileContent
            #$newFileContent | Write-Host
            Set-Content -Path $file -Value $newFileContent
        }
    }
    #if folders iterate through the folders then iterate through files load the file perform find and replace save the file
    if($radiobuttonDirectory.checked -eq $True)
    {
        Write-Host "Replacing items in Directories"
        foreach($directory in $listboxDirectories.Items)
        {
            $fileList = Get-ChildItem -Path $directory -Name
            foreach($file in $fileList)
            {
                $file = $directory + "\" + $file
                $file | Write-Host
                $fileContent = Get-Content $file
                $newFileContent = performFindAndReplace $fileContent
                Set-Content -Path $file -Value $newFileContent
            }
        }
    }
    #if text perform find and replace return results to dialog box
    
    
    
    #$rowNumber = -1
    #foreach($row in $global:findAndReplaceList)
    #{
    #    $rownumber++
    #    Write-Host "Row$($rownumber): Find: $($row.Find) Replace: $($row.Replace)"
    #}
}











function loadSearchCriteria()
{
    #for each .csv in the listbox load the find and replace criteria into $findAndReplaceList
    #$listboxCSVs.Items.count | Write-Host
    #$localFindAndReplaceList = $global:findAndReplaceList
    $global:findAndReplaceList = New-Object System.Data.DataTable "New CSV"
    Out-Null -inputObject $findAndReplaceList.columns.add("Find")
    Out-Null -inputObject $findAndReplaceList.columns.add("Replace")
    foreach($file in $listboxCSVs.Items)
    {
        $file | Write-Host
        if($file -like "*.csv")
        {
            $currentCSVAsFile = Get-Content -Path $file
            $headers = $currentCSVAsFile[0] -split ","
            $currentCSV = Import-Csv -Path $file -Header $headers
            $currentCSV.count | Write-Host
            $rowNumber = -1
            foreach($row in $currentCSV)
            {
                $rownumber++
                if($rownumber -ne 0)
                {
                    #Write-Host "Row$($rownumber): Find: $($row.Find) Replace: $($row.Replace)"
                    $newRow = $global:findAndReplaceList.NewRow()
                    $newRow.Find = $row.Find
                    $newRow.Replace = $row.Replace
                    $global:findAndReplaceList.Rows.Add($newRow)
                }
            }
        }
    }
    #remove duplicates
    $global:findAndReplaceList = $global:findAndReplaceList | Sort Find,Replace -Unique
}

function performFindAndReplace($text)
{
    foreach($row in $global:findAndReplaceList)
    {
        #if($text -match $row.Find)
        #{
            #Write-Host "LineNumber: $($lineNumber) Line: $($line) Find: $($row.Find) Replace: $($row.Replace)"
            $text = $text -replace $row.Find, $row.Replace
        #}
    }
    
    return $text
}
















######################################################################################################################################################################################
#
#                                                       Add Event Handlers to Objects
#
######################################################################################################################################################################################

$buttonBrowseCSV.Add_Click({ buttonBrowseCSV_OnClick $this $_ })
$buttonBrowseDirectory.Add_Click({ buttonBrowseDirectory_OnClick $this $_ })
$buttonBrowseFiles.Add_Click({ buttonBrowseFiles_OnClick $this $_ })
$buttonClearCSVs.Add_Click({ buttonClearCSVs_OnClick $this $_ })
$buttonClearDirectory.Add_Click({ buttonClearDirectory_OnClick $this $_ })
$buttonClearFileList.Add_Click({ buttonClearFileList_OnClick $this $_ })
$buttonNew.Add_Click({ buttonNew_OnClick $this $_ })
$buttonReplace.Add_Click({ buttonReplace_OnClick $this $_ })
$listboxCSVs.Add_DragOver( $listboxCSVs_OnDragOver )
$listboxCSVs.Add_DragDrop( $listboxCSVs_OnDragDrop )
$listboxDirectories.Add_DragOver( $listboxDirectories_OnDragOver )
$listboxDirectories.Add_DragDrop( $listboxDirectories_OnDragDrop )
$listboxFileList.Add_DragOver( $listboxFileList_OnDragOver )
$listboxFileList.Add_DragDrop( $listboxFileList_OnDragDrop )
$radiobuttonDirectory.Add_CheckedChanged({ radiobuttonDirectory_OnCheckedChanged $this $_ })
$radiobuttonFiles.Add_CheckedChanged({ radiobuttonFiles_OnCheckedChanged $this $_ })


#Set the default checked state - Done after adding event handlers so that the CheckedChanged event fires and hides the correct objects. 
$radiobuttonFiles.checked = $True

#Display the Form window
[void]$InputForm.ShowDialog()