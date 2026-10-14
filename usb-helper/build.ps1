$ErrorActionPreference = 'Stop'
$taskRoot = $PSScriptRoot
$taskPackage = Join-Path $taskRoot 'package/ResoCat-ADB-Helper'
$taskAdb = Join-Path $env:LOCALAPPDATA 'Android/Sdk/platform-tools'
$taskCompiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework64/v4.0.30319/csc.exe'
New-Item -ItemType Directory -Path (Join-Path $taskPackage 'adb') -Force | Out-Null
foreach ($taskName in @('adb.exe', 'AdbWinApi.dll', 'AdbWinUsbApi.dll', 'libwinpthread-1.dll', 'NOTICE.txt')) {
    Copy-Item -LiteralPath (Join-Path $taskAdb $taskName) -Destination (Join-Path $taskPackage 'adb') -Force
}
$taskResources = @('adb.exe', 'AdbWinApi.dll', 'AdbWinUsbApi.dll', 'libwinpthread-1.dll', 'NOTICE.txt') | ForEach-Object {
    '/resource:' + (Join-Path $taskAdb $_) + ',adb.' + $_
}
& $taskCompiler /nologo /target:winexe /optimize+ /utf8output /reference:System.Windows.Forms.dll /reference:System.Drawing.dll "/out:$taskPackage/ResoCat-ADB-Helper.exe" $taskResources (Join-Path $taskRoot 'source/ResoCatAdbHelper.cs')
if ($LASTEXITCODE -ne 0) { throw 'Helper compilation failed.' }
$taskProcess = Start-Process -FilePath (Join-Path $taskPackage 'ResoCat-ADB-Helper.exe') -ArgumentList '--self-test' -PassThru -Wait -WindowStyle Hidden -RedirectStandardOutput (Join-Path $taskRoot 'self-test.txt') -RedirectStandardError (Join-Path $taskRoot 'self-test-errors.txt')
if ($taskProcess.ExitCode -ne 0) { throw 'Helper self-test failed. See self-test-errors.txt.' }
Copy-Item -LiteralPath (Join-Path $taskRoot 'README.md') -Destination $taskPackage -Force
Copy-Item -LiteralPath (Join-Path $taskRoot 'GUIDE.md') -Destination $taskPackage -Force
Copy-Item -LiteralPath (Join-Path $taskRoot 'ResoCat-USB-Helper-Guide.txt') -Destination $taskPackage -Force
Copy-Item -LiteralPath (Join-Path $taskRoot 'build.ps1') -Destination $taskPackage -Force
New-Item -ItemType Directory -Path (Join-Path $taskPackage 'source') -Force | Out-Null
Copy-Item -LiteralPath (Join-Path $taskRoot 'source/ResoCatAdbHelper.cs') -Destination (Join-Path $taskPackage 'source') -Force
$taskLegacySource = Join-Path $taskPackage 'ResoCatAdbHelper.cs'
if (Test-Path -LiteralPath $taskLegacySource) { Remove-Item -LiteralPath $taskLegacySource }
Compress-Archive -LiteralPath $taskPackage -DestinationPath (Join-Path $taskRoot 'ResoCat-ADB-Helper-1.0.2-Windows.zip') -Force
Get-FileHash -LiteralPath (Join-Path $taskRoot 'ResoCat-ADB-Helper-1.0.2-Windows.zip') -Algorithm SHA256
