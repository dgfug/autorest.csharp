#Requires -Version 6.0
$ErrorActionPreference = 'Stop'
$ProgressPreference = 'SilentlyContinue'

function DownloadAll([string[]]$files, [string]$baseUrl, [string]$downloadPath)
{
    foreach ($file in $files)
    {
        $text = (Invoke-WebRequest -Uri "$baseUrl/$file").Content
        $text.Trim() | Out-File (Join-Path $downloadPath $file)
    }
}

$downloadPath = Resolve-Path (Join-Path $PSScriptRoot '..' 'src' 'assets' 'Azure.Core.Shared')
Get-ChildItem $downloadPath -Filter *.cs | Remove-Item;
$files = 'ClientDiagnostics.cs', 'DiagnosticScope.cs', 'DiagnosticScopeFactory.cs', 'ContentTypeUtilities.cs', 'HttpMessageSanitizer.cs', 'OperationHelpers.cs', 'TaskExtensions.cs', 'Argument.cs', 'Multipart/MultipartFormDataContent.cs', 'Multipart/MultipartContent.cs', 'AzureKeyCredentialPolicy.cs', 'Argument.cs', 'AppContextSwitchHelper.cs'
$baseUrl = 'https://raw.githubusercontent.com/Azure/azure-sdk-for-net/master/sdk/core/Azure.Core/src/Shared/'
DownloadAll $files $baseUrl $downloadPath

#Download management Shared
$files = 'ClientContext.cs', 'SharedExtensions.cs', 'HttpMessageUtilities.cs'
$downloadPath = Resolve-Path (Join-Path $PSScriptRoot '..' 'src' 'assets' 'Management.Shared')
Get-ChildItem $downloadPath -Filter *.cs | Remove-Item;
$baseUrl = 'https://raw.githubusercontent.com/Azure/azure-sdk-for-net/main/sdk/resourcemanager/Azure.ResourceManager/src/Shared/'
DownloadAll $files $baseUrl $downloadPath
