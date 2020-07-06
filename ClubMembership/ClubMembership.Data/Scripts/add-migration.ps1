param([Parameter(Mandatory=$true)][string]$migrationName)
dotnet ef --project ../ --startup-project ../../Server migrations add $migrationName