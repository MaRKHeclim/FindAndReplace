::SET NewWidth=1920
::SET NewHeight=1080
::SET MonitorToAdjust=0



SET ThisScriptsDirectory=%~dp0
SET PowerShellScriptName=FindandReplace
SET PowerShellScriptPath=%ThisScriptsDirectory%%PowerShellScriptName%
SET PowerShellScriptFullPath=%PowerShellScriptPath%.ps1


PowerShell -Command "Start-Process PowerShell -ArgumentList "^
			"'-STA -NoProfile -ExecutionPolicy Bypass "^
			"-Command ""$host.Runspace.ApartmentState;"^
			". %PowerShellScriptPath%;"^
			"%PowerShellScriptName%;Read-Host;""'"^
			

:: Add the next line to add a pause in the powershell
::			"Read-Host;"


::Pause
exit