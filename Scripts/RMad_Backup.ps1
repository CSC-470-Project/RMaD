#RMad Database location
$source = "C:\DSU\CSC470\Git\Project\RMaD\RMaD\RMaD\RMaD\bin\Debug"

#Archive database location
$archive = "C:\DSU\CSC470\Git\Project\RMaD\RMadBackup\Archive"

#Name of the zip file
$Name = "rmad.zip"

#Backup file store location
$destination = "C:\DSU\CSC470\Git\Project\RMaD\RMadBackup"

#Join archive file location and file name
$ArchiveFile = Join-Path -Path $archive -ChildPath $Name

#Creating Archived directory
MD $archive -EA 0 | Out-Null

#Delete old archive file 
If(Test-path $ArchiveFile) {Remove-item $ArchiveFile}

#Compression assembly
Add-Type -assembly "system.io.compression.filesystem"

#zip the file
[io.compression.zipfile]::CreateFromDirectory($source, $ArchiveFile)

#Copy archived file to final location
Copy-Item -Path $ArchiveFile -Destination $destination -Force