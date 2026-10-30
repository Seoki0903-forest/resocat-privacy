$ErrorActionPreference = 'Stop'
$taskRoot = $PSScriptRoot
$taskRepo = Split-Path -Parent $taskRoot
$taskOutput = Join-Path $taskRepo 'downloads'
$taskCompiler = Join-Path $env:WINDIR 'Microsoft.NET/Framework64/v4.0.30319/csc.exe'
New-Item -ItemType Directory -Path $taskOutput -Force | Out-Null
& $taskCompiler /nologo /target:winexe /optimize+ /utf8output /reference:System.Windows.Forms.dll /reference:System.Drawing.dll /reference:System.Net.Http.dll /reference:System.IO.Compression.dll /reference:System.IO.Compression.FileSystem.dll "/out:$taskOutput/ResoCat-ADB-Helper.exe" (Join-Path $taskRoot 'source/ResoCatAdbHelper.cs')
if ($LASTEXITCODE -ne 0) { throw 'Helper compilation failed.' }
$taskHash = (Get-FileHash -LiteralPath (Join-Path $taskOutput 'ResoCat-ADB-Helper.exe') -Algorithm SHA256).Hash.ToLowerInvariant()
[IO.File]::WriteAllText((Join-Path $taskOutput 'SHA256SUMS.txt'), "$taskHash  ResoCat-ADB-Helper.exe`n", [Text.UTF8Encoding]::new($false))
Write-Output "Built helper 1.0.3 without embedded executable payloads: $taskHash"
